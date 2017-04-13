using System;

namespace OverridePrj
{
    public class HinhChuNhat : Shape
    {
        public HinhChuNhat(int a = 0, int b = 0) : base(a, b)
        {

        }

        public override int tinhDienTich()
        {
            Console.WriteLine("Dien tich cua class HinhChuNhat: ");
            return (chieu_cao * chieu_rong);
        }
    }
}