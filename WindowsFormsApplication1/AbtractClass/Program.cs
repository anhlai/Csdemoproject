using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtractClass
{
    class Program
    {
        abstract class NhanVien
        {
            public string HoTen;
            public int Tuoi;
            public bool GioiTinh;

            //Khai báo 1 phương thức trừu tượng bằng từ khoá abstract
            public abstract void CongViec();
        }

        interface INguoi
        {
            void LoaiNguoi();
        }

        class GiamDoc : NhanVien, INguoi
        {
            public string ChucVu;
            public override void CongViec()
            {
                
            }

            public void LoaiNguoi()
            {
                
            }
        }

        class KeToan : NhanVien
        {
            public string ChucVu;
            public override void CongViec()
            {
                
            }
        }

        static void Main(string[] args)
        {
            GiamDoc objGiamDoc = new GiamDoc();
            objGiamDoc.HoTen = "Nguyen Van A";
            objGiamDoc.Tuoi = 30;
            objGiamDoc.GioiTinh = true;
            objGiamDoc.ChucVu = "Giam Doc";
            System.Console.WriteLine("Lop Dan xuat 'GiamDoc': {0}, {1}, {2}, {3}",
                objGiamDoc.HoTen, objGiamDoc.Tuoi, objGiamDoc.GioiTinh, objGiamDoc.ChucVu);

            KeToan objKeToan = new KeToan();
            objKeToan.HoTen = "Nguyen Van B";
            objKeToan.Tuoi = 26;
            objKeToan.GioiTinh = true;
            objKeToan.ChucVu = "Ke Toan";
            System.Console.WriteLine("Lop Dan xuat 'Ke Toan': {0}, {1}, {2}, {3}",
                objKeToan.HoTen, objKeToan.Tuoi, objKeToan.GioiTinh, objKeToan.ChucVu);

            System.Console.ReadLine();
        }
    }
}
