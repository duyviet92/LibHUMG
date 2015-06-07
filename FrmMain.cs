using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibHUMG
{
    public partial class FrmMain : Form
    {
        public static string Nhom = "";
        DangNhap frm = new DangNhap();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            DangNhap frm = new DangNhap();
            frm.Show();
            this.Hide();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btndocgia_Click(object sender, EventArgs e)
        {
            FrmDocGia frm = new FrmDocGia();
            frm.Show();
            this.Close();
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            FrmNhanVien frm = new FrmNhanVien();
            frm.Show();
            this.Close();

        }

        private void btnnxb_Click(object sender, EventArgs e)
        {
            FrmNxb frm = new FrmNxb();
            frm.Show();
            this.Close();
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            FrmTacGia frm = new FrmTacGia();
            frm.Show();
            this.Close();
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            FrmTheloai frm = new FrmTheloai();
            frm.Show();
            this.Close();
        }

        private void btnmuon_Click(object sender, EventArgs e)
        {
            SoMuonTra frm = new SoMuonTra();
            this.Close();
            frm.Show();
        }

        private void btntra_Click(object sender, EventArgs e)
        {
            FrmTraSach frm = new FrmTraSach();
            frm.Show();
            this.Close();
        }

        private void btndausach_Click(object sender, EventArgs e)
        {
            FrmDauSach frm = new FrmDauSach();
            frm.Show();
            this.Close();
        }

        private void btncuonsach_Click(object sender, EventArgs e)
        {
            CuonSach frm = new CuonSach();
            frm.Show();
            this.Close();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //btncuonsach.Enabled = false;
            switch (Nhom)
            {
                case "cc": 
               { 
                chophep();
                break;
                }
                case "nv":
               {
                   khongchophep();
                   break;
               }
            }
        }

        private void khongchophep()
        {
            btncuonsach.Enabled = false;
            Rbhethong.Enabled = true;
            RbmuonTra.Enabled = true;
        }

        private void chophep()
        {
            ribquanlydanhmuc.Enabled = true;
            Rbhethong.Enabled = true;
            RbmuonTra.Enabled = true;
        }

        private void InHoaDon_Click(object sender, EventArgs e)
        {
            Frmbaocaomuontra frm = new Frmbaocaomuontra();
            this.Close();
            frm.Show();
        }
    }
}
