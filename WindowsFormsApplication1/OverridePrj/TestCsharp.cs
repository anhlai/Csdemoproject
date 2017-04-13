using System;

namespace OverridePrj
{
    public class TestCsharp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tinh da hinh trong C#");
            Console.WriteLine("Vi du minh hoa Da hinh dong");
            Console.WriteLine("--------------------------");

            HienThiDuLieu c = new HienThiDuLieu();
            HinhChuNhat r = new HinhChuNhat(10, 7);
            TamGiac t = new TamGiac(10, 5);
            c.hienThiDienTich(r);
            c.hienThiDienTich(t);

            HienThiDuLieu ht = new HienThiDuLieu();
            HinhVuong hv = new HinhVuong(10, 10);
            c.hienThiDienTich(hv);

            Console.ReadKey();
        }
    }
}