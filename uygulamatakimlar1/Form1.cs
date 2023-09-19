using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulamatakimlar1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                    }

        private void btnTakim1_Click(object sender, EventArgs e)
        {
            lblTakim.BackColor = Color.Blue;
            lblTakim.ForeColor = Color.Yellow;
            lblTakim.Text = "ŞAMPİYON FENERBAHÇE";
        }

        private void btnTakim2_Click(object sender, EventArgs e)
        {
            lblTakim.BackColor = Color.Black;
            lblTakim.ForeColor = Color.White;
            lblTakim.Text = "BEŞİKTAŞ";
        }

        private void btnTakim3_Click(object sender, EventArgs e)
        {
            lblTakim.BackColor = Color.Red;
            lblTakim.ForeColor = Color.Yellow;
            lblTakim.Text = "GALATASARAY";
        }

        private void btnTakim4_Click(object sender, EventArgs e)
        {
            lblTakim.BackColor = Color.Green;
            lblTakim.ForeColor = Color.White;
            lblTakim.Text = "BURSASPOR";
        }
    }
}
