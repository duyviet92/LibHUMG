using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibHUMG
{
    public partial class Frmbaocaomuontra : Form
    {
        public Frmbaocaomuontra()
        {
            InitializeComponent();
        }

        private void Frmbaocao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetbaocao1.SoMuon' table. You can move, or remove it, as needed.
            //this.SoMuonTableAdapter.Fill(this.DataSetbaocao1.SoMuon);

            //this.reportViewer1.RefreshReport();
            //  this.SoMuonTableAdapter.Fill(this.DataSetbaocao1.SoMuon);

            //this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                lblhienthi.Text = "Yêu Cầu Nhập Mã Độc Giả";
            }
            else
            {
                this.SoMuonTableAdapter.Fill(this.DataSetbaocao1.SoMuon, int.Parse(textBox1.Text));

                this.reportViewer1.RefreshReport();
            }
        }
    }
}
