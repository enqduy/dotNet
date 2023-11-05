using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class KhachHang
    {
        private string hoTen;
        private bool gioiTinh;
        private int slm;
        private double donGia;

        public KhachHang()
        {
            hoTen = string.Empty;
            gioiTinh = false;
            slm = 0;
            donGia = 0;
        }

        public KhachHang(string hoTen, bool gioiTinh, int slm, double donGia)
        {
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.slm = slm;
            this.donGia = donGia;
        }

        public string getHoTen()
        {
            return hoTen;
        }
        public void setHoTen(string hoTen)
        {
            this.hoTen= hoTen;
        }
        public int getSlm()
        {
            return slm;
        }
        public void setSlm(int slm)
        {
            this.slm= slm;
        }
         public double getDonGia()
        {
            return donGia;
        }
        public void setDonGia(double donGia)
        {
            this.donGia= donGia;
        }
        public bool getGioiTinh()
        {
            return gioiTinh;
        }

        public virtual double Tong()
        {
            return donGia*slm;
        }
     
    }
}
