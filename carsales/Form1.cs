using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carsales
{
    public partial class frmDash : Form
    {
        public frmDash()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void frmDash_Load(object sender, EventArgs e)
        {

        }

        private void ckShowpass_CheckedChanged(object sender, EventArgs e)
        {
            String pass = txtPass.Text;
            if (ckShowpass.Checked == true)
            
                txtPass.Text = pass;
            
            else
            
                txtPass.Text = "*****";
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPass.Text = "";

        }
    }
}
