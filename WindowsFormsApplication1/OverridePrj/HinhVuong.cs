using System;

namespace OverridePrj
{
    public class HinhVuong : Shape
    {
        public HinhVuong(int a = 0, int b = 0) : base(a, b)
        {
        }

        public override int tinhDienTich()
        {
            Console.WriteLine("Dien tich cua class Vuông: ");
            return (chieu_cao * chieu_cao);
        }

        public override int tinhChuVi()
        {
            Console.WriteLine("Chu vi cua hinh vuong: ");
            return 2*(chieu_cao + chieu_rong);
        }
    }
}