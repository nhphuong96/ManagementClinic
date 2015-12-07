using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Pilot
{
    public static class ObjectExtensions
    {
        //insert into sinhvien([sinhvienid], [hoten], [tuoi]) values(@sinhvienid, @hoten, @tuoi)

        public static string ToSqlInsert(this object obj, string tableName = null) {
            if (string.IsNullOrWhiteSpace(tableName))
                tableName = obj.GetType().Name;
            var props = obj.GetType().GetProperties();
            var listPropertyName = props.Select(x => x.Name).ToList();
            var cols = string.Join(",", listPropertyName.Select(x => "[" + x + "]"));
            var param = string.Join(",", listPropertyName.Select(x => "@" + x));
            return string.Format("insert into {0} ({1}) values ({2})", tableName, cols, param);
        }
        //update sinhvien set hoten=@hoten, tuoi=@tuoi where sinhvienId=@sinhvienId;

        public static string ToSqlUpdate(this object obj, string IdColumn, string tableName = null) {
            if (string.IsNullOrWhiteSpace(tableName))
                tableName = obj.GetType().Name;
            var props = obj.GetType().GetProperties();
            var listPropertyName = props.Select(x => x.Name).Where(x => x != IdColumn).ToList();
            var set = string.Join(",", listPropertyName.Select(x => x + "=@" + x));
            return string.Format("update {0} set ({1}) where {2}=@{2}", tableName, set, IdColumn);

        }
        //select [sinhvienId], [hoten], [tuoi] from sinhvien

        public static string ToSqlSelect(this object obj, string tableName = null) {
            if (string.IsNullOrWhiteSpace(tableName))
                tableName = obj.GetType().Name;
            var props = obj.GetType().GetProperties();
            var listPropertyName = props.Select(x => x.Name).ToList();
            var cols = string.Join(",", listPropertyName.Select(x => "[" + x + "]"));
            return string.Format("select {0} from {1}", cols, tableName);
        }
        public static string ToSqlDelete(this object obj, string tableName = null) {
            var idColumn = obj.GetType().GetProperties().FirstOrDefault().Name;
            return string.Format("delete from {0} where {1}=@{1} ", tableName, idColumn);
        }
        public static List<SqlParameter> ToSqlParameter(this object obj) {
            var props = obj.GetType().GetProperties();
            var param = new List<SqlParameter>();
            foreach (var item in props) {
                param.Add(new SqlParameter{
                    ParameterName = item.Name,
                    Value = item.GetValue(obj) ?? DBNull.Value
                });
            }
            return param;
        }
    }
}
