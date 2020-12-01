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
    public partial class Dash : Form
    {
        public Dash()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Dash_Load(object sender, EventArgs e)
        {
         
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            products pr = new products();
            pr.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            categories pr = new categories();
            pr.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            orders pr = new orders();
            pr.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            customers pr = new customers();
            pr.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            main pr = new main();
            pr.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

      
        private void btnLog_Click(object sender, EventArgs e)
        {
            frmDash fr = new frmDash();
            this.Hide();
            fr.Show();
        }
    }
}
