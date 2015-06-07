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
using Excel = Microsoft.Office.Interop.Excel;

namespace LibHUMG
{
    public partial class FrmTraSach : Form
    {
        public FrmTraSach()
        {
            InitializeComponent();
        }
         DataLayer.SoMuon sm = new DataLayer.SoMuon();
        CuonSach_BLL cuonbll = new CuonSach_BLL();
        DocGia_BLL docbll = new DocGia_BLL();
        SoMuon_BLL somuonbll = new SoMuon_BLL();
        DataTable dt;
        bool kt = true;
        thietlapquyen tl = new thietlapquyen();
        
        public void LoadMaSach()
        {
            try
            {
                dt = cuonbll.GetData();
                cbomacuonsach.DataSource = dt;
                cbomacuonsach.DisplayMember = "MaCuonSach";
                cbomacuonsach.ValueMember = "CuonSachID";
            }
            catch
            {
                MessageBox.Show("Không thể tải dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void loaddocgia(){
            try
            {
                dt = docbll.GetDocGia();
                cbMaDG_TraSach.DataSource = dt;
                cbMaDG_TraSach.DisplayMember = "MaDocGia";
                cbMaDG_TraSach.ValueMember = "DocGiaID";
            }
            catch
            {
                MessageBox.Show("Không thể tải dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        private void btnTraSach_Click(object sender, EventArgs e)
        {
            txtsomuonid.Enabled = false;
            btnTraSach.Enabled = false;
            kt = false;
            tinhtoan();
           // txttrangthai.Enabled = true;
            btnLuu.Enabled = true;
        }
        public void GanGiaTri()
        {
            sm.SoMuonID=int.Parse(txtsomuonid.Text.ToString());
            sm.DocGiaID = int.Parse(cbMaDG_TraSach.SelectedValue.ToString());
            sm.CuonSachID = int.Parse(cbomacuonsach.SelectedValue.ToString());
            sm.NgayMuon = dtNgayMuon_TraSach.Value.ToString("MM/dd/yyyy");
            sm.NgayTra = dtNgayHenTra_TraSach.Value.ToString("MM/dd/yyyy");
            sm.TienPhat = lbltienphat.Text.ToString();
            sm.GhiChu = txttrangthai.Text.ToString();
            //sm.TrangThai = txttrangthai.ToString();
            //daus.NGAYCAP = dateTimePicker1.Value.ToString("dd/MM/yyyy");
        }
        DateTime a, b;
        TimeSpan c;
        int songay;
        int tien;
        public void tinhtoan() {
            a = dtpngaytrasach.Value;
            b = dtNgayHenTra_TraSach.Value;
             c = a - b;
             if (c.Days < 0)
             {
                 songay = 0;
             }
             else
             {
                 songay = c.Days;
             }
             tien = songay * 1000;
            lbltienphat.Text = tien.ToString();

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            txtsomuonid.Enabled = false;
            //somuonbll.CapNhatSoMuon(sm.SoMuonID, sm.CuonSachID, sm.DocGiaID, sm.NgayMuon, sm.NgayTra, sm.TienPhat);
            somuonbll.CapNhatSoMuon(int.Parse(txtsomuonid.Text.ToString()), int.Parse(cbomacuonsach.SelectedValue.ToString()), int.Parse(cbMaDG_TraSach.SelectedValue.ToString()), dtNgayMuon_TraSach.Value.ToString("MM/dd/yyyy"), dtNgayHenTra_TraSach.Value.ToString("MM/dd/yyyy"), lbltienphat.Text.ToString(),txttrangthai.Text.ToString());
            FrmTraSach_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain frm = new FrmMain();
            frm.Show();
        }

        private void Dgvtrasach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtsomuonid.DataBindings.Clear();
           // txttrangthai.DataBindings.Clear();
            dtNgayMuon_TraSach.DataBindings.Clear();
            dtNgayHenTra_TraSach.DataBindings.Clear();
            cbMaDG_TraSach.DataBindings.Clear();
            cbomacuonsach.DataBindings.Clear();
            lbltienphat.DataBindings.Clear();
            txttrangthai.DataBindings.Clear();
            txtsomuonid.DataBindings.Add("text", dt, "SoMuonID");
           //txtMaSach_TraSach.DataBindings.Add("text", dt, "CuonSachID");
            //txttrangthai.DataBindings.Add("text", dt, "TrangThai");
            cbMaDG_TraSach.DataBindings.Add("text", dt, "MaDocGia");
            cbomacuonsach.DataBindings.Add("text", dt, "MaCuonSach");
            dtNgayMuon_TraSach.DataBindings.Add("text", dt, "NgayMuon");
            dtNgayHenTra_TraSach.DataBindings.Add("text", dt, "NgayTra");
            lbltienphat.DataBindings.Add("text",dt,"TienPhat");
            txttrangthai.DataBindings.Add("text", dt, "GhiChu");
        }

        private void FrmTraSach_Load(object sender, EventArgs e)
        {
            btnTraSach.Enabled = true;
            loaddocgia();
            LoadMaSach();
            txtsomuonid.Enabled = false;
            Dgvtrasach.AutoGenerateColumns = false;

            try
            {
                dt = somuonbll.GetData();

                SMID.DataPropertyName = dt.Columns[2].ToString();
                MaDG.DataPropertyName = dt.Columns[1].ToString();
                MaS.DataPropertyName = dt.Columns[0].ToString();
                NgayM.DataPropertyName = dt.Columns[5].ToString();
                NgayHT.DataPropertyName = dt.Columns[6].ToString();
                TP.DataPropertyName = dt.Columns[7].ToString();
                TinhTrang.DataPropertyName=dt.Columns[9].ToString();
                Dgvtrasach.DataSource = dt;
                // MessageBox.Show("1");
            }
            catch
            {
                MessageBox.Show("Không thể tải dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
      
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            
            ExportToExcel excel = new ExportToExcel();
            DataTable dt = (DataTable) Dgvtrasach.DataSource;
            excel.Export(dt, "Danh sach", "DANH SÁCH ");
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
                    
                Dgvtrasach.DataSource = SoMuon_BLL.GetListByName(textBox1.Text);
        }

        private void hgg(object sender, EventArgs e)
        {

        }

    }
}
