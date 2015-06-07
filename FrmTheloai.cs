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
    public partial class FrmTheloai : Form
    {
         BusinessLayer.TheLoai_BLL TheLoai = new TheLoai_BLL();
        thietlapquyen tl = new thietlapquyen();
        DataTable dt;
        bool kt = true;
        public FrmTheloai()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            tl.ChoPhep(this);
            txttheloaiid.Focus();
            txttheloaiid.Enabled = false;
            btnThem.Enabled = false;
            Btnluu.Enabled = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    TheLoai.XoaDL(int.Parse((txttheloaiid.Text).ToString()));
                    MessageBox.Show("Đã xóa bản ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    FrmTheloai_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa  TacGia này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            return;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            kt = false;
            txttentheloai.Enabled = true;
            txttheloaiid.Enabled = false;
            txtmatheloai.Enabled = false;
            btnThem.Enabled = false;
            btnxoa.Enabled = false;
            Btnluu.Enabled = true;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {

        }

        private void Btnluu_Click(object sender, EventArgs e)
        {
            if (kt)
            {
                //Thuc hien viec them du lieu.
                btnThem.Enabled = true;
                txttheloaiid.Enabled = false;
                tl.KhongChoPhep(this);
                try
                {
                    TheLoai.InsertData( int.Parse((txtmatheloai.Text).ToString()), txttentheloai.Text);
                    FrmTheloai_Load(sender, e);
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
                    TheLoai.UpdateDL(int.Parse((txttheloaiid.Text).ToString()),int.Parse((txtmatheloai.Text).ToString()), txttentheloai.Text);
                    FrmTheloai_Load(sender, e);
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

        private void FrmTheloai_Load(object sender, EventArgs e)
        {
            
            tl.KhongChoPhep(this);
            DgvTacGia.AutoGenerateColumns = false;
           
            try
            {
                dt = TheLoai.getData();
               
                TheLoaiID.DataPropertyName = dt.Columns[0].ToString();
               MaTheLoai.DataPropertyName = dt.Columns[1].ToString();
               TenTheLoai.DataPropertyName = dt.Columns[2].ToString();
                DgvTacGia.DataSource = dt;
                //MessageBox.Show("1");
            }
            catch
            {
                MessageBox.Show("Không thể tải dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void DgvTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txttheloaiid.DataBindings.Clear();
            txtmatheloai.DataBindings.Clear();
            txttentheloai.DataBindings.Clear();
            txttheloaiid.DataBindings.Add("text", dt, "TheLoaiID");
            txtmatheloai.DataBindings.Add("text", dt, "MaTheLoai");
            txttentheloai.DataBindings.Add("text", dt, "TenTheLoai");
        }
       
    }
    }
