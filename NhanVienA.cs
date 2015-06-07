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
    public partial class NhanVienA : Form
    {
        BusinessLayer.NhanVien_BLL nhanvien = new BusinessLayer.NhanVien_BLL();
        thietlapquyen tl = new thietlapquyen();
        DataTable dt;
        bool kt = true;
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            tl.ChoPhep(this);
            txtnhanvienid.Focus();
            txtmanv.Enabled = true;
            txttennv.Enabled = true;
            txtuser.Enabled = true;
            txtpass.Enabled = true;
            txtnhanvienid.Enabled = false;
            txtdt.Enabled = true;
            txtqq.Enabled = true;
            btnThem.Enabled = false;
            Btnluu.Enabled = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            kt = false;
            txtnhanvienid.Enabled = false;
            txtmanv.Enabled = true;
            txttennv.Enabled = true;
            txtuser.Enabled = true;
            txtpass.Enabled = true;
            txtdt.Enabled = true;
            txtqq.Enabled = true;
            btnThem.Enabled = false;
            btnxoa.Enabled = false;
            Btnluu.Enabled = true;
        }
        private string gt; private int nhanvienid; private int manv; private string tennv;
        private string diachi; private string dienthoai;
        private string user; private string pass;
        public void GanGiaTri()
        {
            //  docgiaid = int.Parse((txtdocgiaid.Text).ToString());
            manv = int.Parse((txtmanv.Text).ToString());
            tennv = txtqq.Text;
            if (rdbnam.Checked == true)
                gt = "Nam";
            else if (rdbnu.Checked == true)
                gt = "Nữ";
            diachi = txtqq.Text;
            dienthoai = txtdt.Text;
            user = txtuser.Text;
            pass = txtpass.Text;
            // dsnv.MALUONG = cbbMaLuong.SelectedValue.ToString();
        }
        private void Btnluu_Click(object sender, EventArgs e)
        {

        }

        private void DgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtnhanvienid.DataBindings.Clear();
            txtmanv.DataBindings.Clear();
            txttennv.DataBindings.Clear();
            txtqq.DataBindings.Clear();
            txtdt.DataBindings.Clear();
            txtuser.DataBindings.Clear();
            txtpass.DataBindings.Clear();
            txtnhanvienid.DataBindings.Add("text", dt, "NhanVienID");
            txtmanv.DataBindings.Add("text", dt, "MaNhanVien");
            txttennv.DataBindings.Add("text", dt, "HoTen");
            txtqq.DataBindings.Add("text", dt, "DiaChi");
            txtdt.DataBindings.Add("text", dt, "DienThoai");
            txtuser.DataBindings.Add("text", dt, "Username");
            txtpass.DataBindings.Add("text", dt, "Password");
        }

        private void NhanVienA_Load(object sender, EventArgs e)
        {

        }
    }
}
