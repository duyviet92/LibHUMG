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
    public partial class FrmDocGia : Form
    {
       BusinessLayer.DocGia_BLL DocGia = new BusinessLayer.DocGia_BLL();
        thietlapquyen tl = new thietlapquyen();
        DataTable dt;
        bool kt = true;
        public FrmDocGia()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //txtdocgiaid.
            txtdocgiaid.DataBindings.Add("text", dt, "DocGiaID");
            txtdocgiaid.Clear();
            txtemail.Clear();
            txtdt.Clear();
            txttt.Clear();
            txtuser.Clear();
            txtpass.Clear();
            txtmadocgia.Clear();
            txttendocgia.Clear();
            txtqq.Clear();
            txtqq.Enabled = true;
            //tl.ChoPhep(this); 
            txttendocgia.Enabled = true;
            txtdocgiaid.Focus();
            txtmadocgia.Enabled = true;
            txtemail.Enabled = true;
            txttt.Enabled = true;
            txtuser.Enabled = true;
            txtpass.Enabled = true;
            txtdocgiaid.Enabled = false; 
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
                    DocGia.XoaDocGia(int.Parse((txtdocgiaid.Text).ToString()));
                    MessageBox.Show("Đã xóa bản ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    FrmDocGia_Load(sender, e);
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
            txtemail.Enabled = true;
            txttt.Enabled = true;
            txtuser.Enabled = true;
            txtpass.Enabled = true; txtdt.Enabled = true;
            txtqq.Enabled = true;
            txttendocgia.Enabled = true;
            txtdocgiaid.Enabled = false;
            txtmadocgia.Enabled = false;
            btnThem.Enabled = false;
            btnxoa.Enabled = false;
            Btnluu.Enabled = true;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private string gt;
        private int docgiaid;
        int sodt;
        private void Btnluu_Click(object sender, EventArgs e)
        {
             
            if (rdbnam.Checked == true)
                gt = "Nam";
            else if (rdbnu.Checked == true)
                gt = "Nữ";
            //sodt = int.Parse(txtdt.Text.ToString());
           string email=txtemail.Text;
            if (txtmadocgia.Text == "")
            {
                lbldocgia.Text = "(*) Nhập Mã Độc Giả";
                btnThem.Enabled = true;
            }
            if (email.IndexOf("@") == -1 || email.IndexOf(".") == -1)
            {
                lblemail.Text = "(*)Y/C:Email dạng abc@gmail.com ";
                btnThem.Enabled = true;
            }
            else if (kt)
            {
                //Thuc hien viec them du lieu.
                btnThem.Enabled = true;
                txtdocgiaid.Enabled = false;
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
                tl.KhongChoPhep(this);

                try
                {
                    // MessageBox.Show("1"); 

                    DocGia.ThemDocGia(int.Parse(txtmadocgia.Text.ToString()), txttendocgia.Text, dtpns.Value.ToString("dd/MM/yyyy"), gt, txtqq.Text, txtdt.Text, txtemail.Text, dtpngaydk.Value.ToString("dd/MM/yyyy"), dtpngaytt.Value.ToString("dd/MM/yyyy"), dtpngaysd.Value.ToString("dd/MM/yyyy"), txttt.Text, txtuser.Text, txtpass.Text);
                    FrmDocGia_Load(sender, e);
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

                    DocGia.CapNhatDocGia(int.Parse(txtdocgiaid.Text.ToString()), int.Parse(txtmadocgia.Text.ToString()), txttendocgia.Text, dtpns.Value.ToString("dd/MM/yyyy"), gt, txtqq.Text, txtdt.Text, txtemail.Text, dtpngaydk.Value.ToString("dd/MM/yyyy"), dtpngaytt.Value.ToString("dd/MM/yyyy"), dtpngaysd.Value.ToString("dd/MM/yyyy"), txttt.Text, txtuser.Text, txtpass.Text);
                    FrmDocGia_Load(sender, e);
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

            txtdocgiaid.DataBindings.Clear();
            txtmadocgia.DataBindings.Clear();
            txttendocgia.DataBindings.Clear();
            txtqq.DataBindings.Clear();
            txtdt.DataBindings.Clear();
            txtemail.DataBindings.Clear();
            dtpns.DataBindings.Clear();
            dtpngaydk.DataBindings.Clear();
            dtpngaytt.DataBindings.Clear();
            dtpngaysd.DataBindings.Clear();
            txttt.DataBindings.Clear();
            txtuser.DataBindings.Clear();
            txtpass.DataBindings.Clear();
            txtdocgiaid.DataBindings.Add("text", dt, "DocGiaID");
            txtmadocgia.DataBindings.Add("text", dt, "MaDocGia");
            txttendocgia.DataBindings.Add("text", dt, "HoTen");
            txtqq.DataBindings.Add("text", dt, "QueQuan");
            txtdt.DataBindings.Add("text", dt, "DienThoai");
            txtemail.DataBindings.Add("text", dt, "Email");
            dtpns.DataBindings.Add("text", dt, "NgaySinh");
            dtpngaydk.DataBindings.Add("text", dt, "NgayDangKy");
            dtpngaytt.DataBindings.Add("text", dt, "NgayTaoThe");
            dtpngaysd.DataBindings.Add("text", dt, "Hansd");
            txttt.DataBindings.Add("text", dt, "TrangThai");
            txtuser.DataBindings.Add("text", dt, "Username");
            txtpass.DataBindings.Add("text", dt, "Password");
        }

        private void FrmDocGia_Load(object sender, EventArgs e)
        {
              tl.KhongChoPhep(this);
            dgvdocgia.AutoGenerateColumns = false;
           
            try
            {
                dt = DocGia.GetDocGia();
               
                DocGiaID.DataPropertyName = dt.Columns[0].ToString();
                MaDocGia.DataPropertyName = dt.Columns[1].ToString();
               HoTen.DataPropertyName = dt.Columns[2].ToString();
              GioiTinh.DataPropertyName = dt.Columns[3].ToString();
               NgaySinh.DataPropertyName = dt.Columns[4].ToString();
               QueQuan.DataPropertyName = dt.Columns[5].ToString();
               DienThoai.DataPropertyName = dt.Columns[6].ToString();
               Email.DataPropertyName = dt.Columns[7].ToString();
               NgayDangKy.DataPropertyName = dt.Columns[8].ToString();
               NgayTaoThe.DataPropertyName = dt.Columns[9].ToString();
               Hansd.DataPropertyName = dt.Columns[10].ToString();
               TrangThai.DataPropertyName = dt.Columns[11].ToString();
               Username.DataPropertyName = dt.Columns[12].ToString();
               Password.DataPropertyName = dt.Columns[13].ToString();
                dgvdocgia.DataSource = dt;
               // MessageBox.Show("1");
            }
            catch
            {
                MessageBox.Show("Không thể tải dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain frm = new FrmMain();
            frm.Show();
        }
    }
}
