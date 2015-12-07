using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Pilot
{
    class BenhNhan: Khoa
    {
        private static int _mabn = 1;
        public BenhNhan() {
            _mabn++;
        }
        public int MaBN { get { return _mabn; } set { _mabn = value; } }
        public string Hoten { get; set; }
        public string Gioitinh { get; set; }
        public int Namsinh { get; set; }
        public string Diachi {get; set;}
        public string Chuandoan { get; set; }
    }
}
