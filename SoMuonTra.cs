using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BusinessLayer;
namespace LibHUMG
{
    public partial class SoMuonTra : Form
    {
        public SoMuonTra()
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
                cbomacuonsach.DisplayMember = "TenCuonSach";
                cbomacuonsach.ValueMember = "CuonSachID";
            }
            catch
            {
                MessageBox.Show("Không thể tải dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void LoadTinhTrang()
        {
            try
            {
                dt = cuonbll.GetData();
                cbomacuonsach.DataSource = dt;
                cbomacuonsach.DisplayMember = "TinhTrang";
                cbomacuonsach.ValueMember = "CuonSachID";
            }
            catch
            {
                MessageBox.Show("Không thể tải dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void LoadDocGia()
        {
            try
            {
                dt = docbll.GetDocGia();
                cbMaDG.DataSource = dt;
                cbMaDG.DisplayMember = "MaDocGia";
                cbMaDG.ValueMember = "DocGiaID";
                
            }
            catch
            {
                MessageBox.Show("Không thể tải dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void cbChonMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void SoMuonTra_Load(object sender, EventArgs e)
        {
            txtsomuonid.Enabled = false;
            LoadMaSach();
            LoadDocGia();
            dgvmuontra.AutoGenerateColumns = false;
            
            try
            {
                dt = somuonbll.GetData();

                SoMuonID.DataPropertyName = dt.Columns[2].ToString();
               TenCuonSach.DataPropertyName=dt.Columns[8].ToString();
              // TenCuonSach.DataPropertyName=Convert.ToString((GetTenCuonSach(int.Parse(dt.Columns[0].ToString()))));
                DocGiaID.DataPropertyName = dt.Columns[1].ToString();
                NgayMuon.DataPropertyName = dt.Columns[5].ToString();
                NgayTra.DataPropertyName = dt.Columns[6].ToString();
                dgvmuontra.DataSource = dt;
                // MessageBox.Show("1");
            }
            catch
            {
                MessageBox.Show("Không thể tải dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
        }

       // private string GetTenCuonSach(int CuonSachID)
       // {
            //string tencuonsach = "";
            //DataTable dt = new CuonSach_BLL().truyXuatDuLieuBang_CuonSach();

            //if (dt.Rows.Count > 0)
            //{
            //    foreach (dâ dr in dt.Rows)
            //    {
            //        if (int.Parse(dt.Columns["CuonSachID"].ToString()) == CuonSachID)
            //        {
            //            tencuonsach = dr["TenCuonSach"].ToString();
            //            break;
            //        }
            //    }
            //}

            //return tencuonsach;
       // }
        private void btnMuonMoi_Click(object sender, EventArgs e)
        {
            txtsomuonid.Enabled = false;
            txtsomuonid.Clear();
        }
        public void GanGiaTri()
        {
            sm.CuonSachID = int.Parse(cbomacuonsach.SelectedValue.ToString());
            sm.DocGiaID = int.Parse(cbMaDG.SelectedValue.ToString());
            sm.NgayMuon = dtNgayMuon.Value.ToString("dd/MM/yyyy");
            sm.NgayTra = dtNgayHenTra.Value.ToString("dd/MM/yyyy");
           
            
            //daus.NGAYCAP = dateTimePicker1.Value.ToString("dd/MM/yyyy");
        }

        private void btnChoMuon_Click(object sender, EventArgs e)
        {
            GanGiaTri();
            txtsomuonid.Enabled = false;
            // MessageBox.Show("1"); 
            // FrmDauSach.GanGiaTri();
            somuonbll.ThemSoMuon1( sm.CuonSachID,sm.DocGiaID, sm.NgayMuon, sm.NgayTra);
            SoMuonTra_Load(sender, e);
        }
        private void Dgsomuontra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbomacuonsach.DataBindings.Clear();
            cbMaDG.DataBindings.Clear();
            txtsomuonid.DataBindings.Add("text", dt, "SoMuonID");
            cbomacuonsach.DataBindings.Add("text", dt, "TenCuonSach");
            cbMaDG.DataBindings.Add("text", dt, "DocGiaID");
            dtNgayMuon.DataBindings.Add("text", dt, "NgayMuon");
            dtNgayHenTra.DataBindings.Add("text", dt, "NgayTra");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain frm = new FrmMain();
            frm.Show();
        }

        private void txtseach_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {

        }

      
    }
}
