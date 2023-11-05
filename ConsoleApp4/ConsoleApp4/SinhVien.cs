using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class SinhVien
    {
        protected string masv;
        protected string hoTen;
        protected float python;
        protected float java;

        public SinhVien(string masv, string hoTen, float python, float java)
        {
            this.masv = masv;
            this.hoTen = hoTen;
            this.python = python;
            this.java = java;
        }
        public SinhVien()
        { 
            this.masv = string.Empty;
            this.hoTen = string.Empty;
            this.python = 0;
            this.java = 0;
        }
        public string getTen()
        {
            return masv;
        }
        public void setTen(string hoTen) 
        {
            this.hoTen=hoTen;
        }
        public float getPython()
        {
            return python;
        }
        public void setPython(float python)
        {
            this.python = python;
        }
        public float getJava()
        {
            return java;
        }
        public void setJava(float java)
        {
            this.java = java;
        }
        public string getMasv()
        {
            return masv;
        }
        public void setMasv(string masv)
        {
            this.masv = masv;
        }
        public float Tong()
        {
            return java + python;
        }
    }
}
