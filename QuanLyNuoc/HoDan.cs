using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNuoc
{
    class HoDan
    {
        //Declare
        protected string maHo, hoTen, maNhanh;

        protected int maHoc;

        public int MaHoc { get => maHoc; set => maHoc = value; }
        public string MaHo { get => maHo; set => maHo = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string MaNhanh { get => maNhanh; set => maNhanh = value; }

        //Constructor
        public HoDan()
        {
            maHo = hoTen = maNhanh = "";
            maHoc = 0;
        }

        public HoDan(string maHo, string hoTen, string maNhanh, int maHoc)
        {
            this.maHo = maHo;
            this.hoTen = hoTen;
            this.maNhanh = maNhanh;
            this.maHoc = maHoc;
        }

        //function
        public virtual decimal TinhTienSuDung(int soKhoi)
        {
            return 0;
        }

    }
}
