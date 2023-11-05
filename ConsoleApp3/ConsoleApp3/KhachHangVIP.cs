using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class KhachHangVIP : KhachHang
    {
        private string loai;

        public void setLoai(string loai)
        {
            this.loai = loai;
        }
        public string getLoai()
        {
            return this.loai;
        }

        public KhachHangVIP():base()
        {
            loai = string.Empty;
        }
        public KhachHangVIP(string hoTen, bool gioiTinh, int slm, double donGia, string loai) : base(hoTen, gioiTinh,slm, donGia)
        {
            this.loai = loai;
        }
        public override double Tong()
        {
            if (this.loai.CompareTo("vip") == 0)
                return base.Tong() * 0.8;
            else if (this.loai.CompareTo("vang") == 0)
                return base.Tong() * 0.9;
            else if (this.loai.CompareTo("bac") == 0)
                return base.Tong() * 0.95;
            else 
                return base.Tong();
        }
    }
}
