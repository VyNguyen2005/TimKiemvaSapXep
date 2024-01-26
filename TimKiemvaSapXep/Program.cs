using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimKiemvaSapXep
{
    class Program
    {
        static void RandomArray(int[] a, int n)
        {
            Random r = new Random();
            for(int i = 0; i<n; i++)
            {
                a[i] = r.Next(50);
            }
        }
        static void ExportArray(int[] a, int n)
        {
            for(int i = 0; i<n; i++)
            {
                Console.Write($"{a[i]}  ");
            }
        }
        static int LinearSearch(int[] a, int n, int x)
        {
            int i = 0;
            while(i<n && a[i] != x)
            {
                i++;
            }
            if (i == n)
            {
                return -1;
            }
            else
            {
                return i;
            }
        }
        static int BinarySearch(int[] a, int n, int x)
        {
            int left, right, mid;
            left = 0;
            right = n - 1;
            while(left <= right)
            {
                mid = (left + right) / 2;
                if(a[mid] == x)
                {
                    return mid;
                }
                else if(a[mid] < x)
                {
                    return left = mid + 1;
                }
                else
                {
                    return right = mid - 1;
                }
            }
            return -1;
        }
        static void InterChangeSort(int[] a, int n)
        {
            int tam;
            for (int i = 0; i < n - 1; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if(a[i] > a[j])
                    {
                        tam = a[i];
                        a[i] = a[j];
                        a[j] = tam;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[100];
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            RandomArray(a, n);

            Console.WriteLine("Mang ngau nhien ban dau: ");
            ExportArray(a, n);
            Console.WriteLine(" ");
            Console.Write("\nNhap phan tu can tim kiem: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Ket qua tim kiem tuyen tinh: ");
            int indextt = LinearSearch(a, n, x);
            if(indextt == -1)
            {
                Console.WriteLine($"{x} khong xuat hien trong mang");
            }
            else
            {
                Console.WriteLine($"{x} xuat hien trong mang tai vi tri {indextt}");
            }

            Console.WriteLine(" ");
            InterChangeSort(a, n);
            Console.WriteLine("Mang sau khi sap xep tang dan: ");
            ExportArray(a, n);
            
            Console.WriteLine("\nKet qua tim kiem nhi phan: ");
            int indexnp = LinearSearch(a, n, x);
            if (indexnp == -1)
            {
                Console.WriteLine($"{x} khong xuat hien trong mang");
            }
            else
            {
                Console.WriteLine($"{x} xuat hien trong mang tai vi tri {indexnp}");
            }

            Console.ReadLine();
        }
    }
}
