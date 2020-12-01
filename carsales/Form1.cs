using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace carsales
{
    public partial class frmDash : Form
    {
        public frmDash()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ruwa\Documents\carsales.mdf;Integrated Security=True;Connect Timeout=30");
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            main ma = new main();
            ma.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter log = new SqlDataAdapter("select Count(*) from myusers where username = '" + txtUsername.Text + "' and  password = '" + txtPass.Text + "';", con);
            DataTable dt = new DataTable();
            log.Fill(dt);
            if(dt.Rows[0][0].ToString() == "1")
            {
                Dash myd = new Dash();
                myd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password not correct");
            }
            con.Close();
        }

        private void btnLogin_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
