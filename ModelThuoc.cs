using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Pilot
{
    class ModelThuoc
    {
        public static List<Thuoc> GetThuocItems()
        {
            var item = new Thuoc();
            return DataAccess.SelectGeneric<Thuoc>(item);
        }
        public static int AddThuoc(Thuoc item)
        {
            return DataAccess.InsertGeneric(item);
        }
        public static int UpdateThuoc(Thuoc item)
        {
            return DataAccess.UpdateGeneric(item, item.GetType().Name);
        }
        public static int DeleteThuoc(Thuoc item)
        {
            return DataAccess.DeleteGeneric(new { item.MaThuoc }, item.GetType().Name);  // đổi tên MSNV thành MSSV . chính là cột đầu tiên trong bảng
        }
    }
}
