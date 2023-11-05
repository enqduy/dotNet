using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Nhanvien
    {
        protected string hoTen;
        protected DateTime ngayTuyen;

        public string getTen()
        {
            return hoTen;
        }
        void setTen(string hoTen)
        {
            this.hoTen = hoTen;
        }
        public DateTime getNgayTuyen() {  
            return ngayTuyen;
        }
        public void setDate(DateTime date)
        {
            this.ngayTuyen = date;
        }
        public Nhanvien()
        {
            hoTen = string.Empty;
            ngayTuyen = DateTime.MinValue;
        }
        public Nhanvien(string hoTen, DateTime date)
        {
            this.hoTen = hoTen;
            this.ngayTuyen = date;
        }
    }
}
