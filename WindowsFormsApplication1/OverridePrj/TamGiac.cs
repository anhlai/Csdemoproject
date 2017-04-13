using System;

namespace OverridePrj
{
    public class TamGiac : Shape
    {
        public TamGiac(int a = 0, int b = 0) : base(a, b)
        {

        }
        public override int tinhDienTich()
        {
            Console.WriteLine("Dien tich cua class TamGiac: ");
            return (chieu_cao * chieu_rong / 2);
        }
    }
}