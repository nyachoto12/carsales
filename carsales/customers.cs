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
    public partial class customers : Form
    {
        public customers()
        {
            InitializeComponent();
        }

        private void customers_Load(object sender, EventArgs e)
        {
            loadCustomers();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ruwa\Documents\carsales.mdf;Integrated Security=True;Connect Timeout=30");
        void loadCustomers()
        {
            con.Open();
            string myquery = "select * from customers";
            SqlDataAdapter dat = new SqlDataAdapter(myquery, con);
            SqlCommandBuilder buil = new SqlCommandBuilder(dat);
            var ds = new DataSet();
            dat.Fill(ds);
            customerDataGrid.DataSource = ds.Tables[0];
            con.Close();
        }
        private void btnAddCus_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                using (var cmd = new SqlCommand("insert into customers values('" + txtCusId.Text + "','" + txtCus.Text + "','" + txtCusEmail.Text + "','" + txtCusUser.Text+ "','" + txtCusPhone.Text + "')", con))
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully added new customer");
                    con.Close();
                    loadCustomers();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong" + ex);

            }
        }

        private void btnDeCus_Click(object sender, EventArgs e)
        {
            if (txtCus.Text == "")
            {
                MessageBox.Show("Please this should not be empty");
            }

            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update customers set CustomerId ='" + txtCusId.Text + "',CustomerName = '" + txtCus.Text + "',CustomerEmail= '" + txtCusEmail.Text + "',Username ='" + txtCusUser.Text + "', CustomerPhone='" + txtCusPhone.Text + "' where CustomerName = '" + txtCus.Text + "';", con);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully updated customer");
                    con.Close();
                    loadCustomers();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error\n" + ex);
                }


            }

        }

        private void customerDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cuId = customerDataGrid.SelectedRows[0].Cells[0].Value.ToString();
            string cname = customerDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            string cemail = customerDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            string cuser = customerDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            string cphone = customerDataGrid.SelectedRows[0].Cells[4].Value.ToString();

          
            if (cname == "")
            {
                MessageBox.Show("Please this should not be empty");
            }

            else
            {
                txtCusId.Text = cuId;
                txtCus.Text = cname;
                txtCusEmail.Text = cemail;
                txtCusUser.Text = cuser;
                txtCusPhone.Text = cphone;

                con.Open();
                SqlDataAdapter odc = new SqlDataAdapter("select count(*) from orderstbl where CustomerName = '" + txtCusUser.Text + "';", con);
                DataTable DT = new DataTable();
                odc.Fill(DT);
                labelOrder.Text = DT.Rows[0][0].ToString();
                SqlDataAdapter oc = new SqlDataAdapter("select sum(Total) from orderstbl where CustomerName = '" + txtCusUser.Text + "';", con);

                DataTable dt = new DataTable();
                oc.Fill(dt);
                label1Amount.Text = dt.Rows[0][0].ToString();
                SqlDataAdapter d = new SqlDataAdapter("select Max(OrderDate) from orderstbl where CustomerName = '" + txtCusUser.Text + "';", con);

                DataTable td = new DataTable();
                d.Fill(td);
                label1Date.Text = td.Rows[0][0].ToString();
                con.Close();
                txtMyN.Text = cname;

            }

        }

        private void btnClearCus_Click(object sender, EventArgs e)
        {
            txtCus.Text = "";
            txtCusEmail.Text = "";
            txtCusPhone.Text = "";
            txtCusUser.Text = "";
            txtCusId.Text = "";
        }

        private void txtCusPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelCus_Click(object sender, EventArgs e)
        {
           
            if (txtCus.Text == "")
            {
                MessageBox.Show("Please this should not be empty");
            }

            else
            {
                try
                {

                    con.Open();
                    string delquery = "delete from customers where username ='" + txtCus.Text + "';";
                    SqlCommand del = new SqlCommand(delquery, con);
                    del.ExecuteNonQuery();
                    MessageBox.Show("Customer data deleted successfully");
                    con.Close();
                    loadCustomers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("\nError somewhere" + ex);
                }
            }
        }

        private void btnAddCus_MouseHover(object sender, EventArgs e)
        {
            btnAddCus.BackColor = Color.Black;
        }

        private void btnAddCus_MouseLeave(object sender, EventArgs e)
        {
            btnAddCus.BackColor = Color.Teal;
        }

        private void txtMyN_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Dash ds = new Dash();
           
            this.Hide();
            ds.Show();
        }
    }
}
