using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNuoc
{
    class CongNhan : HoDan
    {
        public static decimal giaDinhMuc = int.Parse(Database.GetValue("select GiaDinhMuc from DonGia where MaLoai = '" + Constant.MaCongNhan + "'").ToString());
        public static decimal giaVuotDinhMuc = int.Parse(Database.GetValue("select GiaVuotDinhMuc from DonGia where MaLoai = '" + Constant.MaCongNhan + "'").ToString());
        public static int soDinhMuc = int.Parse(Database.GetValue("select SoDinhMuc from DonGia where MaLoai = '" + Constant.MaCongNhan + "'").ToString());

        public CongNhan() : base()
        {

        }

        public CongNhan(string maHo, string hoTen, string maNhanh, int maHoc) : base(maHo, hoTen, maNhanh, maHoc)
        {

        }

        public override decimal TinhTienSuDung(int soKhoi)
        {
            if (soKhoi <= soDinhMuc)    //Nếu số sử dụng <= số định mức thì thành tiền chỉ = số khối sử dụng * số tiền giá định mức
            {
                return soKhoi * giaDinhMuc;
            }
            return soDinhMuc * giaDinhMuc + giaVuotDinhMuc * (soKhoi - soDinhMuc);  //Nếu vượt quá số định mức thì phần vượt sẽ cộng dồn theo công thức
        }

    }
}
