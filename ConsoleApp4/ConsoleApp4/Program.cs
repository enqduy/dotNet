using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static List<SinhVienDT> ds = new List<SinhVienDT> ();
        static int a;
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("=======MENU======");
                Console.WriteLine("1. Nhap them sinh vien");
                Console.WriteLine("2. Hien thi");
                Console.WriteLine("3. Xet tuyen");
                Console.WriteLine("4. Tim kiem");
                Console.WriteLine("5. Thoat");
                Console.Write("Nhap lua chon: ");
                a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Nhap();
                        break;
                    case 2:
                        Xuat(ds);
                        break;
                    case 3:
                        XetTuyen();
                        break;
                    case 4:
                        TimKiem();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Khong hop le, nhap lai!");
                        break;
                }
            }while(true);
        }
        static void Nhap()
        {
            SinhVienDT a = new SinhVienDT();
            int count = 0;
            a.Input();
            foreach(SinhVienDT s in ds)
            {
                if (s.getMasv() == a.getMasv())
                {
                    Console.WriteLine("Khong duoc nhap trung ma sinh vien");
                    break;
                }
                else
                {
                    count++;
                }
            }
            if(count == ds.Count)
                ds.Add(a);
        }

        static void Xuat(List<SinhVienDT> ds)
        {
            Console.WriteLine("{0, 15} {1,15} {2,15} {3,15}{4,15}{5,15}{6,15}", "Ma SV", "Ho Ten", "Diem python", "Diem Java", "Diem English", "Diem uu tien", "Tong diem");
            foreach(SinhVienDT s in ds)
            {
                s.Output();
            }
        }

        static void XetTuyen()
        {
            Console.Write("Nhap diem xet tuyen: ");
            float a = float.Parse(Console.ReadLine());
            List<SinhVienDT> b = new List<SinhVienDT>();
            foreach(SinhVienDT s in ds)
            {
                if (s.Tong() >= a)
                    b.Add(s);
            }
            if(b.Count == 0)
            {
                Console.WriteLine("Khong co sinh vien nao du dieu kien");
            }
            else
            {
                Console.WriteLine("Danh sach sinh vien du dieu kien");
                Xuat(b);
            }
        }

        static void TimKiem()
        {
            Console.Write("Nhap ma sinh vien: ");
            string msv = Console.ReadLine();
            SinhVienDT a = ds.Find(p => p.getMasv() == msv);
            if(a == null)
            {
                Console.WriteLine("Khong co ma sinh vien");
            } else
            {
                Console.WriteLine("{0, 15} {1,15} {2,15} {3,15}{4,15}{5,15}{6,15}", "Ma SV", "Ho Ten", "Diem python", "Diem Java", "Diem English", "Diem uu tien", "Tong diem");
                a.Output();
            }
        }
    }
}