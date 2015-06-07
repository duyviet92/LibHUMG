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
using DataLayer;

namespace LibHUMG
{
    public partial class FrmNhanVien : Form
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

            //tl.ChoPhep(this);
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
            if (MessageBox.Show("Bạn có muốn xóa bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    nhanvien.XoaNV(int.Parse((txtnhanvienid.Text).ToString()));
                    MessageBox.Show("Đã xóa bản ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    FrmNhanVien_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa  DocGia này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            return;
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
            //nhanvienid = int.Parse((txtnhanvienid.Text).ToString());
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
            if (kt)
            {
                //Thuc hien viec them du lieu.
                btnThem.Enabled = true;
                txtnhanvienid.Enabled = false;
                tl.KhongChoPhep(this);

                try
                {
                    //MessageBox.Show("1");
                    GanGiaTri();
                    nhanvien.ThemNV(manv, tennv, gt,  diachi, dienthoai,  user, pass);
                    FrmNhanVien_Load(sender, e);
                    //MessageBox.Show("1");
                }
                catch
                {
                    MessageBox.Show("Không thể thêm dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Btnluu.Enabled = false;
            }
            else if (kt == false)
            {
                //Thuc hien viec sua du lieu
                try
                {
                    GanGiaTri();
                    nhanvien.CapNhatNV(nhanvienid, manv, tennv, gt,diachi,  dienthoai, user, pass);
                    FrmNhanVien_Load(sender, e);
                }
                catch
                {

                    MessageBox.Show("Không thể thêm dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                btnThem.Enabled = true;
                btnxoa.Enabled = true;
            }
            Btnluu.Enabled = false;
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
            txtmanv.DataBindings.Add("text", dt, "MaNV");
            txttennv.DataBindings.Add("text", dt, "TenNV");
            txtqq.DataBindings.Add("text", dt, "DiaChi");
            txtdt.DataBindings.Add("text", dt, "DienThoai");
            txtuser.DataBindings.Add("text", dt, "Username");
            txtpass.DataBindings.Add("text", dt, "Password");
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {

            tl.KhongChoPhep(this);
            dgvdocgia.AutoGenerateColumns = false;

            try
            {
                dt = nhanvien.GetNhanVien();

                NVID.DataPropertyName = dt.Columns[0].ToString();
                MaNV1.DataPropertyName = dt.Columns[1].ToString();
                HoTen1.DataPropertyName = dt.Columns[2].ToString();
                GioiTinh.DataPropertyName = dt.Columns[3].ToString();
                QueQuan.DataPropertyName = dt.Columns[4].ToString();
                DienThoai1.DataPropertyName = dt.Columns[5].ToString();
                Username.DataPropertyName = dt.Columns[6].ToString();
                Password.DataPropertyName = dt.Columns[7].ToString();
                dgvdocgia.DataSource = dt;
                // MessageBox.Show("1");
            }
            catch
            {
                MessageBox.Show("Không thể tải dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain frm = new FrmMain();
            frm.Show();
        }
    }
}
