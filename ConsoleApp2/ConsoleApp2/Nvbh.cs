using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Nvbh : Nhanvien
    {
        private double slb { get; set; }

        public Nvbh() : base() 
        { 
            slb = 0.0;
        }
        public Nvbh(string hoTen, DateTime date, double slb) : base( hoTen,date)
        {
            this.slb = slb;
        }
        public float HoaHong()
        {
            if (this.slb < 100)
                return 1000;
            else if (this.slb < 500 && this.slb > 100)
                return 2000;
            else
                return 3000;
        }
        public override string ToString()
        {
            return "Nhan vien: " + getTen()+ ", "+ "Ngay tuyen: "+ getNgayTuyen() + ", " + "so luong ban: "+ this.slb + ", Hoa hong: " +HoaHong();
        }
    }
}
