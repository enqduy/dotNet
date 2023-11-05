using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp3
{ 
    class Program
    {
        static List<KhachHangVIP> ds = new List<KhachHangVIP>();
        static void Main(string[] args)
        {
            int a;
            do
            {
                Console.WriteLine("============MENU=============");
                Console.WriteLine("1. Nhap thong tin");
                Console.WriteLine("2. Hien thi danh sach");
                Console.WriteLine("3. Xoa khach hang");
                Console.WriteLine("4. Thoat");
                Console.Write("Nhap lua chon: ");
                a = Convert.ToInt32(Console.ReadLine());
                switch(a)
                {
                    case 1:
                        nhap();
                        break;
                    case 2:
                        sx();
                        break;
                    case 3:
                        xoa();
                        break;
                    case 4:
                        return;
                    default: 
                        Console.WriteLine("Khong hop le");
                       break;


                }
            }while (true);
            static void nhap()
            {
                Console.WriteLine("1. Nhap khach hang");
                Console.WriteLine("2. Nhap khach hang VIP");
                int b = Convert.ToInt32(Console.ReadLine());
                if (b == 1)
                {
                    Console.Write("Nhap ten khach hang: ");
                    string hoTen = Convert.ToString(Console.ReadLine());
                    Console.Write("Nhap gioi tinh (true- Nam, false- Nu): ");
                    bool gioiTinh = Convert.ToBoolean(Console.ReadLine());
                    Console.Write("Nhap so luong mua: ");
                    int slm = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nhap don gia: ");
                    double donGia = Convert.ToDouble(Console.ReadLine());
                    KhachHangVIP kh = new KhachHangVIP(hoTen, gioiTinh, slm, donGia, " ");
                    int count = 0;
                    foreach( KhachHangVIP n in ds)
                    {
                        if (n.getHoTen().CompareTo(kh.getHoTen()) == 0)
                        {
                            Console.WriteLine("Trung ten khach hang");
                            break;
                        }
                        else
                            count++;
                    }
                    if (count == ds.Count)
                        ds.Add(kh);

                }
                if(b == 2)
                {
                    Console.Write("Nhap ten khach hang: ");
                    string hoTen = Convert.ToString(Console.ReadLine());
                    Console.Write("Nhap gioi tinh (true- Nam, false- Nu): ");
                    bool gioiTinh = Convert.ToBoolean(Console.ReadLine());
                    Console.Write("Nhap so luong mua: ");
                    int slm = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nhap don gia: ");
                    double donGia = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Nhap loai: ");
                    string loai = Convert.ToString(Console.ReadLine());
                    KhachHangVIP kh = new KhachHangVIP(hoTen, gioiTinh, slm, donGia, loai);
                    int count = 0;
                    foreach (KhachHangVIP n in ds)
                    {
                        if (n.getHoTen().CompareTo(kh.getHoTen()) == 0)
                        {
                            Console.WriteLine("Trung ten khach hang");
                            break;
                        }
                        else
                            count++;
                    }
                    if (count == ds.Count)
                        ds.Add(kh);

                }
                if (b != 1 && b!=2) 
                {
                    Console.WriteLine("Khong hop le");
                    nhap();
                }
            }

            static void xuat()
            {
                foreach(KhachHangVIP n in ds)
                {
                    if(n.getLoai() == " ")
                    {
                        Console.WriteLine($"Ho ten: {n.getHoTen()}, gioi tinh: {n.getGioiTinh()}, so luong mua: {n.getSlm()}, don gia: {n.getDonGia()}, Tong tien: {n.Tong()}");
                    }
                    else
                    {
                        Console.WriteLine($"Ho ten: {n.getHoTen()}, gioi tinh: {n.getGioiTinh()}, so luong mua: {n.getSlm()}, don gia: {n.getDonGia()},Loai: {n.getLoai()} ,Tong tien: {n.Tong()}");
                    }
                }

            }
            static void sx()
            {
               var a=  ds.OrderBy(x => x.Tong());
               foreach(KhachHangVIP n in a)
                {
                    if (n.getLoai() == " ")
                    {
                        Console.WriteLine($"Ho ten: {n.getHoTen()}, gioi tinh: {n.getGioiTinh()}, so luong mua: {n.getSlm()}, don gia: {n.getDonGia()}, Tong tien: {n.Tong()}");
                    }
                    else
                    {
                        Console.WriteLine($"Ho ten: {n.getHoTen()}, gioi tinh: {n.getGioiTinh()}, so luong mua: {n.getSlm()}, don gia: {n.getDonGia()},Loai: {n.getLoai()} ,Tong tien: {n.Tong()}");
                    }
                }
            }

            static void xoa()
            {
                Console.Write("Nhap ten khach hang muon xoa: ");
                string name = Console.ReadLine();
                KhachHangVIP removekh = ds.Find(p => p.getHoTen()==name);
                bool ok =  ds.Remove(removekh);
                if(ok)
                {
                    Console.WriteLine("Khach hang da duoc xoa");
                    xuat();
                }
                else {
                    Console.WriteLine("Khong tim thay ten khach hang");
                    xuat();

                }
            }

        }

        
    }

















}