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
    public partial class FrmDauSach : Form
    {
        DataLayer.DauSach daus = new DataLayer.DauSach();
        DauSach_BLL dausbll = new DauSach_BLL();
        TacGia_BLL tgia = new TacGia_BLL();
        Nxb_BLL nxb = new Nxb_BLL();
        TheLoai_BLL tloai = new TheLoai_BLL();
        DataTable dt;
        bool kt = true;
        thietlapquyen tl = new thietlapquyen();
        public void LoadTenTacGia()
        {
            try
            {
                dt = tgia.GetData();
                cbotacgia.DataSource = dt;
                cbotacgia.DisplayMember = "TenTacGia";
                cbotacgia.ValueMember = "TacGiaID";
            }
            catch
            {
                MessageBox.Show("Không thể tải dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void LoadNxb()
        {
            try
            {
                dt = nxb.GetNxb();
                cbonxb.DataSource = dt;
                cbonxb.DisplayMember = "TenNxb";
                cbonxb.ValueMember = "NxbID";
            }
            catch
            {
                MessageBox.Show("Không thể tải dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Load vao CBB The loai
        public void LoadTheLoai()
        {
            try
            {
                dt = tloai.getData();
                cbotheloai.DataSource = dt;
                cbotheloai.DisplayMember = "TenTheLoai";
                cbotheloai.ValueMember = "TheLoaiID";
            }
            catch
            {
                MessageBox.Show("Không thể tải dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void GanGiaTri()
        {
            daus.DauSachID = int.Parse(txtdausachid.Text.ToString());
            daus.MaDauSach = int.Parse(txtmadausach.Text.ToString());
            daus.TacGiaID = int.Parse(cbotacgia.SelectedValue.ToString());
            daus.NxbID = int.Parse(cbonxb.SelectedValue.ToString());
            daus.TheLoaiID = int.Parse(cbotheloai.SelectedValue.ToString());
            daus.TenSach = txttensach.Text;
            daus.TomTat = txttomtat.Text;
            daus.TuKhoa = txttukhoa.Text;
            daus.ThoiHan = txtthoihan.Text;
            daus.TongLuotMuon = int.Parse(txttongluot.Text.ToString());
            //daus.NGAYCAP = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            daus.SoCuonCon = int.Parse(txtsocon.Text.ToString());

        }
        
        public FrmDauSach()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // tl.ChoPhep(this);
            txtdausachid.DataBindings.Add("text", dt, "DauSachID");
            txtdausachid.Focus();
            txtmadausach.Enabled = true;
            txttensach.Enabled = true;
            txttomtat.Enabled = true;
            txttukhoa.Enabled = true;
            txtdausachid.Enabled = false;
            txttongluot.Enabled = true;
            txtsocon.Enabled = true;
            btnthem.Enabled = false;
            Btnluu.Enabled = true;
            txtmadausach.Clear();
            txttensach.Clear();
            txttomtat.Clear();
            txttukhoa.Clear();
            txtthoihan.Clear();
            txttongluot.Clear();
            txtsocon.Clear();
        }
      
        private void Btnluu_Click(object sender, EventArgs e)
        {
            if (kt)
            {
                //Thuc hien viec them du lieu.
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
                btnthem.Enabled = true;
                txtdausachid.Enabled = false;
                tl.KhongChoPhep(this);

                try
                {
                    GanGiaTri();
                    // MessageBox.Show("1"); 
                   // FrmDauSach.GanGiaTri();
                    dausbll.InsertDauSach(daus.MaDauSach, daus.TenSach, daus.TomTat, daus.TuKhoa, daus.ThoiHan, daus.TongLuotMuon, daus.SoCuonCon, daus.TacGiaID, daus.TheLoaiID, daus.NxbID);
                    FrmDauSach_Load(sender, e);
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
                    dausbll.UpdateDauSach(daus.DauSachID,daus.MaDauSach, daus.TenSach, daus.TomTat, daus.TuKhoa, daus.ThoiHan, daus.TongLuotMuon, daus.SoCuonCon, daus.TacGiaID, daus.TheLoaiID, daus.NxbID);
                    FrmDauSach_Load(sender, e);
                }
                catch
                {

                    MessageBox.Show("Không thể thêm dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                btnthem.Enabled = true;
                btnxoa.Enabled = true;
                btnsua.Enabled = true;
            }
            Btnluu.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  txtSearch.Enabled = true;
            if (MessageBox.Show("Bạn có muốn xóa bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    dausbll.XoaDausach(int.Parse((txtdausachid.Text).ToString()));
                    MessageBox.Show("Đã xóa bản ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    FrmDauSach_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa  DocGia này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            return;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // txtSearch.Enabled = true;
            btnsua.Enabled = false;
            kt = false;
            txtmadausach.Enabled = true;
            txttensach.Enabled = true;
            txttomtat.Enabled = true;
            txttukhoa.Enabled = true;
            txtthoihan.Enabled = true;
            txtdausachid.Enabled = false;
            txttongluot.Enabled = true;
            txtsocon.Enabled = true;
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            Btnluu.Enabled = true;
         
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {

            this.Close();
            FrmMain frm = new FrmMain();
            frm.Show();

        }

        private void dgvdausach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnthem.Enabled = true;
         //   txtSearch.Enabled = true;
            txtdausachid.DataBindings.Clear();
            txtmadausach.DataBindings.Clear();
            txttensach.DataBindings.Clear();
            txttomtat.DataBindings.Clear();
            txttongluot.DataBindings.Clear();
            txttukhoa.DataBindings.Clear();
            txtsocon.DataBindings.Clear();
            txtthoihan.DataBindings.Clear();
            txtdausachid.DataBindings.Add("text", dt, "DauSachID");
            txtmadausach.DataBindings.Add("text", dt, "MaDauSach");
            txttomtat.DataBindings.Add("text", dt, "TomTat");
            txttensach.DataBindings.Add("text", dt, "TenSach");
            txttukhoa.DataBindings.Add("text", dt, "TuKhoa");
            txtthoihan.DataBindings.Add("text", dt, "ThoiHan");
            txtsocon.DataBindings.Add("text", dt, "SoCuonCon");
            txttongluot.DataBindings.Add("text", dt, "TongLuotMuon");
        }

        private void FrmDauSach_Load(object sender, EventArgs e)
        {
           // txtSearch.Enabled = true;
            LoadNxb();
            LoadTenTacGia();
            LoadTheLoai();
            txtdausachid.Enabled = false;
            btnthem.Enabled = true;
            //tl.ChoPhep(this);
            dgvdausach.AutoGenerateColumns = false;

            try
            {
                dt = dausbll.GetData();

                DauSachID.DataPropertyName = dt.Columns[0].ToString();
                MaDauSach.DataPropertyName = dt.Columns[1].ToString();
                TacGiaID.DataPropertyName = dt.Columns[9].ToString();
                NxbID.DataPropertyName = dt.Columns[8].ToString();
                TheLoaiID.DataPropertyName = dt.Columns[10].ToString();
                TenSach.DataPropertyName = dt.Columns[5].ToString();
                TomTat.DataPropertyName = dt.Columns[6].ToString();
                TuKhoa.DataPropertyName = dt.Columns[7].ToString();
                ThoiHan.DataPropertyName = dt.Columns[2].ToString();
                TongLuotMuon.DataPropertyName = dt.Columns[3].ToString();
                SoCuonCon.DataPropertyName = dt.Columns[4].ToString();
                dgvdausach.DataSource = dt;
                // MessageBox.Show("1");
            }
            catch
            {
                MessageBox.Show("Không thể tải dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
