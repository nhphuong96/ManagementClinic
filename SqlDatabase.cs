using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Pilot
{
    public class SqlDatabase
    {
        public string ConnectionStringName { get; set; }
        public SqlDatabase(string conString = "data") {
            ConnectionStringName = conString;
        }
        public string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings[ConnectionStringName].ConnectionString;
            }
        }
        public DataTable GetDataTable(string cmdText, List<SqlParameter> param = null)
        {
            if (param == null)
            {
                param = new List<SqlParameter>();
            }
            CommandType cmdType = CommandType.Text;
            if (!cmdText.Contains(' '))
                cmdType = CommandType.StoredProcedure;
            var table = new DataTable();
            using (var con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    //cmd.Connection
                    cmd.CommandText = cmdText;
                    cmd.CommandType = cmdType;
                    foreach (var item in param)
                    {
                        cmd.Parameters.Add(item);
                    }
                    var reader = cmd.ExecuteReader();
                    table.Load(reader);
                    reader.Close();
                }
                con.Close();
                con.Dispose();
            }
            return table;
        }
        public int GetDataScalar(string cmdText) {
            using (var con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = cmdText;
                    cmd.CommandType = CommandType.Text;
                    int number = (Int32)cmd.ExecuteScalar();
                    con.Close();
                    return number;  
                }
            }
        }
        public int ExecuteNonQuery(string cmdText, List<SqlParameter> param = null) {
            if (param == null) {
                param = new List<SqlParameter>();
            }
            CommandType cmdType = CommandType.Text;
            if (!cmdText.Contains(' ')) 
                cmdType = CommandType.StoredProcedure;
            int result;
            using (var con = new SqlConnection(ConnectionString)) {
                using (var cmd = con.CreateCommand()) {
                    cmd.CommandText = cmdText;
                    cmd.CommandType = cmdType;
                    foreach (var item in param) {
                        cmd.Parameters.Add(item);
                    }
                    result = cmd.ExecuteNonQuery();
                }
                con.Close();
                con.Dispose();
            }
            return result;
        }
    }
    public static class DataExtensions {
        public static List<T> GetList<T>(this SqlDatabase db, string cmdText, List<SqlParameter> param = null) where T : new()
        {
            return db.GetDataTable(cmdText,param).To<T>();
        }
        public static void SetFromRow(this object item, DataRow row)
        {
            if (row == null)
                return;
            foreach (DataColumn c in row.Table.Columns)
            {
                PropertyInfo p = item.GetType().GetProperty(c.ColumnName);
                if (p != null && row[c] != DBNull.Value)
                {
                    p.SetValue(item, row[c], null);
                }
            }
        }
        public static T To<T>(this DataRow row) where T : new()
        {
            T item = new T();
            item.SetFromRow(row);
            return item;
        }
        public static List<T> To<T>(this DataTable tbl) where T : new()
        {
            List<T> listItems = new List<T>();
            foreach (DataRow r in tbl.Rows)
            {
                listItems.Add(r.To<T>());
            }
            return listItems;
        }
    }
}
