using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL.BUS;
namespace BTL
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }
        public static string us = "";
        private void btLogin_Click(object sender, EventArgs e)
        {
            {
                us = txtTK.Text;
                string pw = txtMK.Text;
                BUS_Login xulyuser = new BUS_Login();
                
                if (xulyuser.login(us, pw))
                {
                    FQuanLi f = new FQuanLi();
                    this.Hide();
                    MessageBox.Show("Đăng nhập thành công");
                    f.StartPosition = FormStartPosition.CenterScreen;
                    f.ShowDialog();
                    

                }
                else
                    MessageBox.Show("Sai UserName hoặc PassWord");
                
            }
        }
    }
}
