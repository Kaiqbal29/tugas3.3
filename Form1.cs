using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiLatihanTiga3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var nama = txtNama.Text;
            var pendidikan = txtPendidikan.Text;
            var pekerjaaan = txtpekerjaan.Text;

            txtPesan1.Text = string.Format("Hallo {0}", nama);
            txtPesan2.Text = string.Format("Pendidkan Anda {0} ya?", pendidikan);
            txtPesan3.Text = string.Format("Anda Seorang {0}, Hebat", pekerjaaan);

        }
    }
}
