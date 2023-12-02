using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WpfApp4
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

        public class nv
        {
            public string name { get; set; }
            public string phong { get; set; }
            public string date { get; set; }
            public string tien { get; set; }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            nv a = new nv();
            if (txtTen.Text == "" || cbL.Text == "" || dNgay.Text == "" || txtT.Text == "")
            {
                MessageBox.Show("Vui long nhap day du du lieu!");
            }
            else
            {
                
                try
                {
                   double money = float.Parse(txtT.Text);
                }
                catch
                {
                    MessageBox.Show("Vui long nhap lai so tien");
                    
                    txtT.Focus();
                }

                double tuoi = DateTime.Now.Subtract(dNgay.DisplayDate).TotalDays / 365;
                if (tuoi < 20 || tuoi > 62)
                {
                    MessageBox.Show("Tuoi khong hop le");
                }
                else if (float.Parse(txtT.Text) <= 0)
                {
                    MessageBox.Show("So tien khong hop le");
                }
                else
                {
                    double hh = 0;
                    double money = float.Parse(txtT.Text);
                    if (money < 1200)
                    {
                        hh = 0;
                    }
                    else if (money >= 1200 && money <= 4800)
                    {
                        hh = money * 6 / 100;
                    }
                    else
                    {
                        hh = money * 12 / 100;
                    }
                    string content = txtTen.Text + "|" + dNgay.Text + "|" + cbL.Text + "|" + txtT.Text + "|Hoa hong: " + hh;
                    listbox.Items.Add(content);
                }


            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtTen.Text = "";
            txtTen.Focus();
            txtT.Text = "";
            dNgay.Text = DateTime.Now.ToString();
            cbL.SelectedIndex = 4;
            listbox.Items.Remove(listbox.SelectedItem);
        }

        
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window1 a = new Window1();
            string thongtin = listbox.SelectedItem.ToString();
            string[] tt = thongtin.Split("|");
            a.txtTen2.Text = tt[0];
            a.txtT2.Text = tt[3];
            a.cbL2.Text = tt[2];
            a.dNgay2.Text = tt[1];
            a.Show();
          
        }

        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

