using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDL_GT_TH_02
{
    class IntArray
    {
        private int[] arr { get; set; }
        private int k { get; set; }
        private int x { get; set; }


        public IntArray() { }
        public IntArray(int k)
        {
            this.arr = new int[k];
            
        }

        public IntArray(int[] arr)
        {
            
        }

        public IntArray(IntArray obj) { }


        public void Nhap()
        {
            for (int i = 0; i< arr.Length; i++)
            {
                Console.Write("arr[" + i + "]=");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        public bool KiemTraKT(int k)
        {
            while (k < 1 || k > 200)
            {

                Console.WriteLine("Nhap lai kich thuoc mang: ");
                k = Int32.Parse(Console.ReadLine());

            }
            return true;
        }

        public void Xuat()
        {
            Console.Write("Hien thi mang:");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }

        public int TimTuanTu(int x)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }

        public int TimNhiPhan(int x)
        {
            int left , right ,mid; left = 0; right = arr.Length - 1;

            do
            {
                mid = (left + right)/2;
                if (arr[mid] == x)
                {
                    return mid;
                }else if(arr[mid] < x)
                {
                    left = mid + 1;
                }else if (arr[mid] > x)
                {
                    right = mid - 1;
                }
            } while (left <= right);
            return -1;
        }
    }

    
}
