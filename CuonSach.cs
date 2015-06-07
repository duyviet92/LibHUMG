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
    public partial class CuonSach : Form
    {
        public CuonSach()
        {
            InitializeComponent();
        }
      DataLayer.CuonSach cs = new DataLayer.CuonSach();
        CuonSach_BLL cuonbll = new CuonSach_BLL();
        DauSach_BLL daubll = new DauSach_BLL();
        
        DataTable dt;
        bool kt = true;
        thietlapquyen tl = new thietlapquyen();
        public void LoadTenSach()
        {
            try
            {
                dt = daubll.GetData();
                cboloadten.DataSource = dt;
                cboloadten.DisplayMember = "TenSach";
                cboloadten.ValueMember = "DauSachID";
            }
            catch
            {
                MessageBox.Show("Không thể tải dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void GanGiaTri()
        {
            //cs.CuonSachID = int.Parse(txtcuonid.Text.ToString());
            cs.MaCuonSach = int.Parse(txtmacuon.Text.ToString());
            cs.DauSachID = int.Parse(cboloadten.SelectedValue.ToString());
            cs.ViTri = txtvitri.Text;
            cs.LuotXem = txtluotxem.Text;
            cs.TinhTrang = txttt.Text;
            cs.TenCuonSach = txttencuon.Text;
            //daus.NGAYCAP = dateTimePicker1.Value.ToString("dd/MM/yyyy");
           

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
           // tl.ChoPhep(this);
            {
                txtcuonid.DataBindings.Add("text", dt, "CuonSachID");
                txtcuonid.Focus();
                txtmacuon.Enabled = true;
                txtluotxem.Enabled = true;
                txtvitri.Enabled = true;
                txttt.Enabled = true;
                txtcuonid.Enabled = false;
                btnThem.Enabled = false;
                Btnluu.Enabled = true;
            }
        }
      
        private void Btnluu_Click(object sender, EventArgs e)
        {
            if (kt)
            {
                //Thuc hien viec them du lieu.
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
                btnThem.Enabled = true;
                txtcuonid.Enabled = false;
                tl.KhongChoPhep(this);

                try
                {
                    GanGiaTri();
                    // MessageBox.Show("1"); 
                   // FrmDauSach.GanGiaTri();
                    cuonbll.ThemCuonSach(cs.MaCuonSach, cs.DauSachID, cs.ViTri, cs.TinhTrang, cs.LuotXem,cs.TenCuonSach);
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
                    cuonbll.CapNhatCuonSach(cs.CuonSachID,cs.MaCuonSach, cs.DauSachID, cs.ViTri, cs.TinhTrang, cs.LuotXem,cs.TenCuonSach);
                    FrmDauSach_Load(sender, e);
                }
                catch
                {

                    MessageBox.Show("Không thể thêm dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                btnThem.Enabled = true;
                btnxoa.Enabled = true;
                btnsua.Enabled = true;
            }
            Btnluu.Enabled = false;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            //txtseach.Enabled = true;
            if (MessageBox.Show("Bạn có muốn xóa bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    cuonbll.XoaCuonSach(int.Parse((txtcuonid.Text).ToString()));
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

        private void BtnSua_Click(object sender, EventArgs e)
        {
           // txtSearch.Enabled = true;
            btnsua.Enabled = false;
            kt = false;
            txtmacuon.Enabled = true;
            txtluotxem.Enabled = true;
            txtvitri.Enabled = true;
            txttt.Enabled = true;
           
            txtcuonid.Enabled = false;
           
            btnThem.Enabled = false;
            btnxoa.Enabled = false;
            Btnluu.Enabled = true;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void dgvdausach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtSearch.Enabled = true;
            txtcuonid.DataBindings.Clear();
            txtmacuon.DataBindings.Clear();
            txtvitri.DataBindings.Clear();
            txtluotxem.DataBindings.Clear();
            txttt.DataBindings.Clear();
            txttencuon.DataBindings.Clear();
            txtcuonid.DataBindings.Add("text", dt, "CuonSachID");
            txtmacuon.DataBindings.Add("text", dt, "MaCuonSach");
            txtvitri.DataBindings.Add("text", dt, "ViTri");
            txtluotxem.DataBindings.Add("text", dt, "LuotXem");
            txttt.DataBindings.Add("text", dt, "TrangThai");
            txttencuon.DataBindings.Add("text", dt, "TenCuonSach");
           
        }

        private void FrmDauSach_Load(object sender, EventArgs e)
        {
            //txtSearch.Enabled = true;
            //LoadTenTacGia();
          
            LoadTenSach();
            //LoadTheLoai();
            txtcuonid.Enabled = false;
            //tl.ChoPhep(this);
            dgvcuonsach.AutoGenerateColumns = false;

            try
            {
                dt = cuonbll.GetData();

                IDCuonSach.DataPropertyName = dt.Columns[0].ToString();
                MaCS.DataPropertyName = dt.Columns[1].ToString();
                TenS.DataPropertyName = dt.Columns[2].ToString();
                VTri.DataPropertyName = dt.Columns[3].ToString();
                LuotX.DataPropertyName = dt.Columns[4].ToString();
                TinhTr.DataPropertyName = dt.Columns[5].ToString();
                TenCuon.DataPropertyName = dt.Columns[6].ToString();
                dgvcuonsach.DataSource = dt;
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