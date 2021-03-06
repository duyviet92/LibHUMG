﻿using System;
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
    public partial class FrmNxb : Form
    {
        BusinessLayer.Nxb_BLL nxb = new Nxb_BLL();
        thietlapquyen tl = new thietlapquyen();
        DataTable dt;
        bool kt = true;
        public FrmNxb()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            tl.ChoPhep(this);
            txtnxbid.Focus();
            txtnxbid.Enabled = false;
            btnThem.Enabled = false;
            Btnluu.Enabled = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    nxb.XoaDL(int.Parse((txtnxbid.Text).ToString()));
                    MessageBox.Show("Đã xóa bản ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    FrmNxb_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa  Nxb này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            return;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            kt = false;
            txttennxb.Enabled = true;
            txtnxbid.Enabled = false;
            txtmanxb.Enabled = false;
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
                txtnxbid.Enabled = false;
                tl.KhongChoPhep(this);
                try
                {
                    nxb.InsertData( int.Parse((txtmanxb.Text).ToString()), txttennxb.Text);
                    FrmNxb_Load(sender, e);
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
                    nxb.UpdateDL(int.Parse((txtnxbid.Text).ToString()),int.Parse((txtmanxb.Text).ToString()), txttennxb.Text);
                    FrmNxb_Load(sender, e);
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

        private void FrmNxb_Load(object sender, EventArgs e)
        {
            
            tl.KhongChoPhep(this);
            Dgvnxb.AutoGenerateColumns = false;
           
            try
            {
                dt = nxb.GetNxb();
               
                NxbID.DataPropertyName = dt.Columns[0].ToString();
                MaNxb.DataPropertyName = dt.Columns[1].ToString();
               Tennxb.DataPropertyName = dt.Columns[2].ToString();
                Dgvnxb.DataSource = dt;
               // MessageBox.Show("1");
            }
            catch
            {
                MessageBox.Show("Không thể tải dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void Dgvnxb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmanxb.DataBindings.Clear();
            txttennxb.DataBindings.Clear();
            txtnxbid.DataBindings.Add("text", dt, "NxbID");
            txtmanxb.DataBindings.Add("text", dt, "MaNxb");
            txttennxb.DataBindings.Add("text", dt, "TenNxb");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
