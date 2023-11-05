using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        static List<Nvbh> ds = new List<Nvbh>();
        static void Main(string[] args)
        {
           
            int a;
            do
            {
                Console.WriteLine("==================================================");
                Console.WriteLine("1. Nhap thong tin nhan vien");
                Console.WriteLine("2. In danh sach");
                Console.WriteLine("3. Sap xep");
                Console.WriteLine("4. Thoat");
                a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        nhap(ds);
                        break;
                    case 2:
                        xuat();
                        break;
                    case 3:
                        Sapxep();
                        break;
                    case 4:
                        return;
                    default:
                        return;
                }

            }while (true);

            
        }
        static void nhap(List<Nvbh> ds)
        {
            Console.WriteLine("1. Nhap thong tin nhan vien");
            Console.WriteLine("2. Nhap thong tin nhan vien ban hang");
            int b = Convert.ToInt32(Console.ReadLine());
            if (b == 1)
            {
                Console.WriteLine("Nhap ho ten: ");
                string hoTen = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Nhap ngay tuyen dung(ngay-thang-nam): ");
                DateTime ngayTuyenDung = Convert.ToDateTime(Console.ReadLine());
                Nvbh n = new Nvbh(hoTen, ngayTuyenDung, -1);
                foreach (Nvbh nvbh in ds)
                {
                    if (n.getTen().CompareTo(nvbh.getTen()) == 0)
                    {
                        Console.WriteLine("Trung ten nhan vien");
                        break;
                    }
                }
            }
            else if (b == 2)
            {
                Console.WriteLine("Nhap ho ten: ");
                string hoTen = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Nhap ngay tuyen dung(ngay-thang-nam): ");
                DateTime ngayTuyenDung = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Nhap so luong ban: ");
                double slb = Convert.ToDouble(Console.ReadLine());
                Nvbh a = new Nvbh(hoTen, ngayTuyenDung, slb);
                foreach (Nvbh nvbh in ds)
                {
                    if (a.getTen().CompareTo(nvbh.getTen()) == 0)
                    {
                        Console.WriteLine("Trung ten nhan vien");
                        break;
                    }
                }

            }

        }
        static void xuat()
        {

        }
        static void Sapxep()
        {

        }
    }
   







}