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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        private void main_Load(object sender, EventArgs e)
        {
            loadUsers();

        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ruwa\Documents\carsales.mdf;Integrated Security=True;Connect Timeout=30");
        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

    
        void loadUsers()
        {
            con.Open();
            string myquery = "select * from myusers";
            SqlDataAdapter dat = new SqlDataAdapter(myquery,con);
            SqlCommandBuilder buil = new SqlCommandBuilder(dat);
            var ds = new DataSet();
            dat.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
         

            try
            {
                con.Open();
                using (var cmd = new SqlCommand("insert into myusers values('" + txtUser.Text + "','" + txtFull.Text + "','" + txtPass.Text + "','" + txtEmail.Text + "')", con))
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully added new user");
                    con.Close();
                    names();
                    loadUsers();
                }
               

            }
            catch(Exception ex)
            {
                MessageBox.Show("Something wrong"+ ex);

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
            
        {
            if (txtPass.Text == "")
            {
                MessageBox.Show("Please this should not be empty");
            }
         
            else
            {
                try
                {
                   
                    con.Open();
                    string delquery = "delete from myusers where username ='" + txtUser.Text + "';";
                    SqlCommand del = new SqlCommand(delquery, con);
                    del.ExecuteNonQuery();
                    MessageBox.Show("User data deleted successfully");
                    con.Close();
                    names();
                    loadUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("\nError somewhere" + ex);
                }
            }
               

            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string fullname = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string pass = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            string email = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            if (name == "")
            {
                MessageBox.Show("Please this should not be empty");
            }

            else
            {
                txtUser.Text = name;
                txtFull.Text = fullname;
                txtPass.Text = pass;
                txtEmail.Text = email;

            }

        }

        void names()
        {
            txtFull.Text = "";
            txtUser.Text = "";
            txtPass.Text = "";
            txtEmail.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          

            if (txtUser.Text == "")
            {
                MessageBox.Show("Please this should not be empty");
            }

            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update myusers set username ='" + txtUser.Text + "',fullname = '" + txtFull.Text + "',password = '" + txtPass.Text + "',email ='" + txtEmail.Text + "' where username = '" + txtUser.Text + "';", con);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully updated user");
                    con.Close();

                    loadUsers();
                }

                catch(Exception ex)
                {
                    MessageBox.Show("Error\n" + ex);
                }

            
            }
           
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtFull.Text = "";
            txtUser.Text = "";
            txtPass.Text = "";
            txtEmail.Text = "";
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDash fr = new frmDash();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dash ds = new Dash();
            
            this.Hide();
            ds.Show();
        }
        /*CREATE TABLE[dbo].[customers]
(
[CustomerId] INT NOT NULL PRIMARY KEY,
[CustomerName] VARCHAR(20) NOT NULL,
[CustomerEmail] VARCHAR(20) NOT NULL,
[Username] VARCHAR(20) NOT NULL,
[CustomerPhone] BIGINT(10) NOT NULL,
)*/
    }
}
