using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp3.Moduls;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        QlbnContext db = new QlbnContext();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            HienthiCB();

            Hienthi();

        }

        private void HienthiCB()
        {
            var a = from k in db.Khoas
                    select k;
            cbb.SelectedValuePath = "MaKhoa";
            cbb.DisplayMemberPath = "TenKhoa";
            cbb.ItemsSource = a.ToList();
            cbb.SelectedIndex = 0;

        }
        private void Hienthi()
        {
            var a = from k in db.BenhNhans
                    orderby k.SoNgayNamVien descending
                    select new
                    {
                        k.MaBn,
                        k.HoTen,
                        k.MaKhoa,
                        k.DiaChi,
                        k.SoNgayNamVien,
                        VienPhi = k.SoNgayNamVien * 60000
                    };
            dtg.ItemsSource = a.ToList();

        }

        private bool isCheck()
        {
           string t = "";
           if(txtMa.Text.CompareTo("")==0|| txtTen.Text.CompareTo("") == 0|| txtDiachi.Text.CompareTo("") == 0|| txtSo.Text.CompareTo("") == 0)
            {
                t += "Khong duoc de trong";
            }
           else
            {
                int a;
                if(int.TryParse(txtMa.Text, out a))
                {
                    if (int.Parse(txtMa.Text) < 0){
                        t += "Ma benh nhan phai lon hon 0";
                    } 
                }
                else
                {
                    t += "Nhap sai dinh dang";
                }
                if (int.TryParse(txtSo.Text, out a)){
                    if(int.Parse(txtSo.Text) <0)
                    {
                        t += "So ngay nhap vien phai lon 0";
                    }
                }
                else
                {
                    t += "Nhap sai dinh dang";
                }
                
            }
            if (t.CompareTo("") != 0)
            {
                MessageBox.Show(t);
                return false;
            }
            return true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (isCheck())
            {
                bool a = true;
                var b = from c in db.BenhNhans
                        where c.MaBn == int.Parse(txtMa.Text)
                        select c;
                if (b.ToList().Count > 0)
                {
                    MessageBox.Show("Ma benh nhan trung!", "Kiem tra du lieu", MessageBoxButton.OK, MessageBoxImage.Error);
                    a = false;
                }

                if (a)
                {
                    BenhNhan bn = new BenhNhan();
                    bn.MaBn = int.Parse(txtMa.Text);
                    bn.HoTen = txtTen.Text;
                    bn.DiaChi = txtDiachi.Text;
                    bn.MaKhoa = int.Parse(cbb.SelectedValue.ToString());
                    bn.SoNgayNamVien = int.Parse(txtSo.Text);
                    bn.VienPhi = int.Parse(txtSo.Text) * 60000;
                    db.Add(bn);
                    db.SaveChanges();
                    Hienthi();
                }
            }
            
        }

        private void dtg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dtg.SelectedItems != null)
            {
                Type a = dtg.SelectedItem.GetType();
                PropertyInfo[] p = a.GetProperties();
                txtMa.Text = p[0].GetValue(dtg.SelectedValue).ToString();
                txtTen.Text = p[1].GetValue(dtg.SelectedValue).ToString();
                txtDiachi.Text = p[3].GetValue(dtg.SelectedValue).ToString();
                txtSo.Text = p[4].GetValue(dtg.SelectedValue).ToString();
                var b = from k in db.Khoas
                        where k.MaKhoa == int.Parse(p[2].GetValue(dtg.SelectedValue).ToString())
                        select k.TenKhoa;
                foreach (var k in b)
                {
                    cbb.Text = k;
                }
                
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1();
            var a = from bn in db.BenhNhans
                    where bn.MaKhoa == 1
                    select new
                    {
                        bn.MaBn,
                        bn.HoTen,
                        bn.MaKhoa,
                        bn.DiaChi,
                        bn.SoNgayNamVien,
                        VienPhi = bn.SoNgayNamVien * 60000
                    };
            w.dtg1.ItemsSource = a.ToList();    
            
            w.Show();
        }
    }
}
