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
    public partial class categories : Form
    {
        public categories()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ruwa\Documents\carsales.mdf;Integrated Security=True;Connect Timeout=30");
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void categories_Load(object sender, EventArgs e)
        {
            loadCategories();
        }
        void loadCategories()
        {
            con.Open();
            string myquery = "select * from categories";
            SqlDataAdapter dat = new SqlDataAdapter(myquery, con);
            SqlCommandBuilder buil = new SqlCommandBuilder(dat);
            var ds = new DataSet();
            dat.Fill(ds);
            categoryDataGrid.DataSource = ds.Tables[0];
            con.Close();
        }
        private void btnAddCat_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                using (var cmd = new SqlCommand("insert into categories values('" + txtCatId.Text + "','" + txtCat.Text + "','" + txtDesc.Text + "')", con))
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully added " + txtCat.Text + " to categories");
                    con.Close();
                    loadCategories();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong" + ex);

            }
        }

        private void btnUpdateCat_Click(object sender, EventArgs e)
        {
            if (txtCat.Text == "")
            {
                MessageBox.Show("Please this should not be empty");
            }

            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update categories set CategoryId ='" + txtCatId.Text + "',CategoryName = '" + txtCat.Text + "',Description= '" + txtDesc.Text + "' where CategoryId = '" + txtCatId.Text + "';", con);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully updated " + txtCat.Text);
                    con.Close();
                    loadCategories();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error\n" + ex);
                }


            }
        }

        private void categoryDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string catId = categoryDataGrid.SelectedRows[0].Cells[0].Value.ToString();
            string catname = categoryDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            string catdesc = categoryDataGrid.SelectedRows[0].Cells[2].Value.ToString();

            if (catId == "")
            {
                MessageBox.Show("Please this should not be empty");
            }

            else
            {
                txtCatId.Text = catId;
                txtCat.Text = catname;
                txtDesc.Text = catdesc;

            }
        }

        private void btnDelCat_Click(object sender, EventArgs e)
        {
            if (txtCat.Text == "")
            {
                MessageBox.Show("Please this should not be empty");
            }

            else
            {
                try
                {

                    con.Open();
                    string delquery = "delete from categories where CategoryName ='" + txtCat.Text + "';";
                    SqlCommand del = new SqlCommand(delquery, con);
                    del.ExecuteNonQuery();
                    MessageBox.Show(""+txtCat.Text +" deleted successfully");
                    con.Close();
                    loadCategories();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("\nError somewhere" + ex);
                }
            }
        }

        private void btnClearCat_Click(object sender, EventArgs e)
        {
            txtCat.Text = "";
            txtCatId.Text = "";
            txtDesc.Text = "";
        }
    }
}
