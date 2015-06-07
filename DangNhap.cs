using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace LibHUMG
{
    public partial class DangNhap : Form
    {
        dangnhap dn= new dangnhap();
        DataSet ds;
        public bool KiemTra()
        {
            if (txtuser.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtuser.Focus();
                return false;
            }
            else if (txtpass.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtpass.Focus();
                return false;
            }
            return true;
        }
        public DangNhap()
        {
            InitializeComponent();
        }
       private string user;
        private string pass;
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
             user = txtuser.Text;
            pass = txtpass.Text;
            
            bool kt;
            kt = KiemTra();
            if (kt == true)
            {

                user = txtuser.Text;
                pass = txtpass.Text;
                    ds = dn.KTDangNhap(user, pass);
                //Dem xem co ket qua khong?
                int dem;
                dem = ds.Tables[0].Rows.Count;
                //Neu ton tai user
                if (dem > 0)
                {
                    FrmMain main = new FrmMain();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtuser.Focus();
                    txtpass.Clear();
                    txtpass.Clear();
                }

            }
            else return;
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
    }
