using System;

namespace OverridePrj
{
    public class Shape
    {
        protected int chieu_rong, chieu_cao;
        public Shape(int a = 0, int b = 0)
        {
            chieu_rong = a;
            chieu_cao = b;
        }
        public virtual int tinhDienTich()
        {
            Console.WriteLine("Dien tich cua class cha: ");
            return 0;
        }

        public virtual int tinhChuVi()
        {
            Console.WriteLine("Chu vi cua class cha: ");
            return 0;
        }
    }
}