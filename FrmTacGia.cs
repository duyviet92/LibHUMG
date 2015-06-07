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
    public partial class FrmTacGia : Form
    {
        BusinessLayer.TacGia_BLL TacGia = new TacGia_BLL();
        thietlapquyen tl = new thietlapquyen();
        DataTable dt;
        bool kt = true;
        public FrmTacGia()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            tl.ChoPhep(this);
            txtTacGiaid.Focus();
            txtTacGiaid.Enabled = false;
            btnThem.Enabled = false;
            Btnluu.Enabled = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    TacGia.XoaDL(int.Parse((txtTacGiaid.Text).ToString()));
                    MessageBox.Show("Đã xóa bản ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    FrmTacGia_Load(sender, e);
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
            txttenTacGia.Enabled = true;
            txtTacGiaid.Enabled = false;
            txtmaTacGia.Enabled = false;
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
                txtTacGiaid.Enabled = false;
                tl.KhongChoPhep(this);
                try
                {
                    TacGia.InsertData( int.Parse((txtmaTacGia.Text).ToString()), txttenTacGia.Text);
                    FrmTacGia_Load(sender, e);
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
                    TacGia.UpdateDL(int.Parse((txtTacGiaid.Text).ToString()),int.Parse((txtmaTacGia.Text).ToString()), txttenTacGia.Text);
                    FrmTacGia_Load(sender, e);
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

        private void FrmTacGia_Load(object sender, EventArgs e)
        {
            
            tl.KhongChoPhep(this);
            DgvTacGia.AutoGenerateColumns = false;
           
            try
            {
                dt = TacGia.GetData();
               
                TacGiaID.DataPropertyName = dt.Columns[0].ToString();
                MaTacGia.DataPropertyName = dt.Columns[1].ToString();
               TenTacGia.DataPropertyName = dt.Columns[2].ToString();
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

            txtTacGiaid.DataBindings.Clear();
            txtmaTacGia.DataBindings.Clear();
            txttenTacGia.DataBindings.Clear();
            txtTacGiaid.DataBindings.Add("text", dt, "TacGiaID");
            txtmaTacGia.DataBindings.Add("text", dt, "MaTacGia");
            txttenTacGia.DataBindings.Add("text", dt, "TenTacGia");
        }
       
    }
}
