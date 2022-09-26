using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CTDL_GT_TH_02;

namespace CTDLGT_TH_02
{
    class Program
    {
        static void TestTimTuanTu()
        {
            int k, x, kq;
            Console.WriteLine("TIM KIEM TUAN TU");
            Console.Write(">>Nhap so luong mang: ");
            int.TryParse(Console.ReadLine(), out k);
            IntArray obj = new IntArray(k);
            obj.KiemTraKT(k);
            obj.Nhap();
            Console.WriteLine(">>Cac phan tu:");
            obj.Xuat();
            Console.Write("\n>>Gia tri can tim x = ");
            int.TryParse(Console.ReadLine(), out x);
            kq = obj.TimTuanTu(x);
            if (kq == -1)
            {
                Console.WriteLine("->Khong ton tai {0}!", x);
            }
            else
                Console.WriteLine("->Co {0} tai vi tri {1} ", x, kq);


        }
        static void TestTimNhiPhan()
        {
            int k, x, kq;
            Console.WriteLine("TIM KIEM NHI PHAN");
            Console.Write(">>Nhap so luong mang: ");
            int.TryParse(Console.ReadLine(), out k);
            IntArray obj = new IntArray(k);
            obj.KiemTraKT(k);
            obj.Nhap();
            Console.WriteLine(">>Cac phan tu:");
            obj.Xuat();
            Console.Write("\n>>Gia tri can tim x = ");
            int.TryParse(Console.ReadLine(), out x);
            kq = obj.TimNhiPhan(x);
            if (kq == -1)
            {
                Console.WriteLine("->Khong ton tai {0}!", x);
            }
            else
                Console.WriteLine("->Co {0} tai vi tri {1} ", x, kq);
        }
        static void Main(string[] args)
        {
            TestTimTuanTu();
            TestTimNhiPhan();
        }
    }
}