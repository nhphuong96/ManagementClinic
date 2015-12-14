using DatabaseLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Pilot
{
    class DataAccess
    {
        static SqlDatabase db = new SqlDatabase();

        public static int InsertGeneric(object item)
        {
            return db.ExecuteNonQuery(item.ToSqlInsert(), item.ToSqlParameter());
        }
        /// <summary>
        /// Model.DeleteGeneric(new {HanghoaId = 5}, "Hanghoa");
        /// Model.DeleteGeneric(new {x.HanghoaId}, "Hanghoa");
        /// </summary>
        /// <param name="item">new {HanghoaId = 5}, new {x.HanghoaId}</param>
        /// <param name="tableName">Hanghoa</param>
        /// <returns></returns>
        public static int DeleteGeneric(object item, string tableName)
        {
            var sql = item.ToSqlDelete(tableName);
            var param = item.ToSqlParameter();
            return db.ExecuteNonQuery(sql, param);
        }
        public static int UpdateGeneric(object item, string idColumn, string tableName = null)
        {
            return db.ExecuteNonQuery(item.ToSqlUpdate(idColumn, tableName), item.ToSqlParameter());
        }
        public static List<T> SelectGeneric<T>(object item, string tableName = null) where T : new()
        {
            return db.GetList<T>(item.ToSqlSelect(tableName), item.ToSqlParameter());
        }

    }
}
