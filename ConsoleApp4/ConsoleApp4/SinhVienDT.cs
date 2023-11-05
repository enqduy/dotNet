using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class SinhVienDT : SinhVien
    {
        protected float english;
        protected float uutien;

        public void Input()
        {
            Console.WriteLine("Nhap thong tin sinh vien!");
            Console.Write("Nhap ma sinh vien: ");
            masv = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap ho ten sinh vien: ");
            hoTen = Convert.ToString(Console.ReadLine());
            do
            {
                Console.Write("Nhap diem python: ");
                python = float.Parse(Console.ReadLine());
            } while (python < 0 || python > 10);
            do
            {
                Console.Write("Nhap diem java: ");
                java = float.Parse(Console.ReadLine());
            } while (java < 0 || java > 10);
            do
            {
                Console.Write("Nhap diem english: ");
                english = float.Parse(Console.ReadLine());
            }while(english < 0 || english > 10);

            if (english >8)
            {
                uutien = 1.0f;
            } else if(5 <= english && english<=8)
            {
                uutien = 0.5f;
            }
            else
            {
                uutien = 0f;
            }
        }
        public float Tong()
        {
            return (base.Tong()+english+uutien);
        }
        public void Output()
        {
            Console.WriteLine("{0, 15} {1,15} {2,15} {3,15}{4,15}{5,15}{6,15}", masv, hoTen, python, java, english, uutien, Tong());
        }
        public string XetTuyen(float mark)
        {
            if(Tong() >= mark) 
            {
                return "Duoc chon";
            }
            else
            {
                return "loai";
            }
        }
    }

}
