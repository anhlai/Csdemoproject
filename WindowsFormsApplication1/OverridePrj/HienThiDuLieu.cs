using System;

namespace OverridePrj
{
    public class HienThiDuLieu
    {
        public void hienThiDienTich(Shape sh)
        {
            int a;
            a = sh.tinhDienTich();
            Console.WriteLine("Dien tich: {0}", a);

            int chuVi = sh.tinhChuVi();
            Console.WriteLine("Tinh chu vi: {0}", chuVi);
        }

        public HienThiDuLieu()
        {
        }
    }
}