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
    public partial class products : Form
    {
        public products()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ruwa\Documents\carsales.mdf;Integrated Security=True;Connect Timeout=30");

        void catFill()
        {
            string selcat = " select * from categories";
            SqlCommand selc = new SqlCommand(selcat, con);
            SqlDataReader srd;

            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CategoryName", typeof(string));
                srd = selc.ExecuteReader();
                dt.Load(srd);
                cmdPro.ValueMember = "CategoryName";
                cmdPro.DataSource = dt;
                cmdSearch.ValueMember = "CategoryName";
                cmdSearch.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is not right");
            }
        }
       
        void loadProducts()
        {
            con.Open();
            string myquery = "select * from product ";
            SqlDataAdapter dat = new SqlDataAdapter(myquery, con);
            SqlCommandBuilder buil = new SqlCommandBuilder(dat);
            var ds = new DataSet();
            dat.Fill(ds);
            productsDataGrid.DataSource = ds.Tables[0];
            con.Close();
        }
        void searchFilter()
        {
            con.Open();
            string myquery = "select * from product where CategoryName= '" + cmdSearch.SelectedValue.ToString() + "'";
            SqlDataAdapter dat = new SqlDataAdapter(myquery, con);
            SqlCommandBuilder buil = new SqlCommandBuilder(dat);
            var ds = new DataSet();
            dat.Fill(ds);
            productsDataGrid.DataSource = ds.Tables[0];
            con.Close();
        }
        private void txtCusPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void products_Load(object sender, EventArgs e)
        {
            catFill();
            loadProducts();
       
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                using (var cmd = new SqlCommand("insert into product values('" + txtProId.Text + "','" + txtPro.Text + "','" + txtQua.Text + "','" + txtPrice.Text + "','" + cmdPro.SelectedValue.ToString() + "')", con))
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully added " + txtPro.Text + " to products list");
                    con.Close();
                    loadProducts();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong\n" + ex);

            }
        }

        private void btnUpdateProd_Click(object sender, EventArgs e)
        {
            if (txtPro.Text == "")
            {
                MessageBox.Show("Please this should not be empty");
            }

            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update product set ProductId ='" + txtProId.Text + "',ProductName = '" + txtPro.Text + "',Quantity= '" + txtQua.Text + "',Price='" + txtPrice.Text + "', Category='" + cmdPro.SelectedValue.ToString() + "' where ProductId = '" + txtProId.Text + "';", con);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully updated " + txtPro.Text);
                    con.Close();
                    loadProducts();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error\n" + ex);
                }


            }
        }

        private void productsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string proId = productsDataGrid.SelectedRows[0].Cells[0].Value.ToString();
            string proname = productsDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            string quant= productsDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            string price = productsDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            string catg = productsDataGrid.SelectedRows[0].Cells[4].Value.ToString();

            if (proId == "")
            {
                MessageBox.Show("Please this should not be empty");
            }

            else
            {
                txtProId.Text = proId;
                txtPro.Text = proname;
                txtQua.Text = quant;
                txtPrice.Text = price;
                cmdPro.SelectedValue = catg;

            }
        }

        private void btnDeProd_Click(object sender, EventArgs e)
        {

            if (txtPro.Text == "")
            {
                MessageBox.Show("Please this should not be empty");
            }

            else
            {
                try
                {

                    con.Open();
                    string delquery = "delete from product where ProductName ='" + txtPro.Text + "';";
                    SqlCommand del = new SqlCommand(delquery, con);
                    del.ExecuteNonQuery();
                    MessageBox.Show(""+ txtPro.Text+" deleted successfully");
                    con.Close();
                    loadProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("\nError somewhere" + ex);
                }
            }
        }

        private void btnClearProd_Click(object sender, EventArgs e)
        {
            txtPro.Text = "";
            txtProId.Text = "";
            txtQua.Text = "";
            txtPrice.Text = "";
           
        }

        private void panelOrder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchFilter();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadProducts();
        }
    }
}