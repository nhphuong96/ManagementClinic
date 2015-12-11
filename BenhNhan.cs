using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Pilot
{
    public class BenhNhan
    {
        public static int _mabn = 0;
        public BenhNhan() {
            MaBN++;
            Chandoan = "";
        }
        public int MaBN { get { return _mabn; } set { _mabn = value; } }
        public string Hoten { get; set; }
        public string Gioitinh { get; set; }
        public int Namsinh { get; set; }
        public string Diachi {get; set;}
        public string Donvi { get; set; }
        public string Chandoan { get; set; }
    }
}
