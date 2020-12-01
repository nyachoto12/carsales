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
    public partial class orders : Form
    {
        public orders()
        {
            InitializeComponent();
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
            ordersDataGrid.DataSource = ds.Tables[0];
            con.Close();
        }
        void loadProducts()
        {
            con.Open();
            string myquery = "select * from product ";
            SqlDataAdapter dat = new SqlDataAdapter(myquery, con);
            SqlCommandBuilder buil = new SqlCommandBuilder(dat);
            var ds = new DataSet();
            dat.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
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
               // cmdPro.ValueMember = "CategoryName";
              //  cmdPro.DataSource = dt;
                cmdSearch.ValueMember = "CategoryName";
                cmdSearch.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is not right\n" + ex);
            }
        }

        int newQuantity = 0;
        void updateStock()
        {
            con.Open();
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            newQuantity = stock - Convert.ToInt32(txtoqty.Text);
            string upprod = "update product set Quantity = " + newQuantity + " where ProductId = " + id + ";";
            SqlCommand upd = new SqlCommand(upprod, con);
            upd.ExecuteNonQuery();
            con.Close();
            loadProducts();
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ordersDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //string orderid = ordersDataGrid.SelectedRows[0].Cells[0].Value.ToString();
            //string cato = ordersDataGrid.SelectedRows[0].Cells[0].Value.ToString();
            string cn = ordersDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            if (cn =="")
            {
                MessageBox.Show("Please this should not be empty");
            }
              
            else
            {
              //  txtOrderid.Text = cato;
                txtCN.Text = cn;

            }
        }
        int num = 0;
        int qty, uprice, totaprice;
        string prod;
        DataTable table = new DataTable();
        private void orders_Load(object sender, EventArgs e)
        {
            string mydate = ORDERdATE.Text;
            mydate.Replace(",", "");
            MessageBox.Show("Successfully added order for '" + mydate.ToString() + "'");
            loadCustomers();
            loadProducts();
            catFill();
            
            table.Columns.Add("Number", typeof(int));

            table.Columns.Add("Product", typeof(string));

            table.Columns.Add("Quantity", typeof(int));

            table.Columns.Add("Unit Price" , typeof(int ));

            table.Columns.Add("Total" , typeof(int));
            

            myorder.DataSource = table;
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {

        }

        private void orderProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void cmdSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "select * from product where Category= '" + cmdSearch.SelectedValue.ToString() + "'";
                SqlDataAdapter dat = new SqlDataAdapter(query, con);
                SqlCommandBuilder buil = new SqlCommandBuilder(dat);
                var ds = new DataSet();
                dat.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
            catch(Exception ex)
            {
              
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtOrderid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCatoID_TextChanged(object sender, EventArgs e)
        {

        }
        int flag = 0;
        int stock = 0;
        int sum = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            prod = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            //qty = Convert.ToInt32(txtoqty.Text);
            stock = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            uprice = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
            //totaprice = qty * uprice;
            flag = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtoqty.Text == "")
            {
                MessageBox.Show("Please enter the quantity of the product");
            }
            
            else if(flag == 0)
            {
                MessageBox.Show("Please select a product");
            }
            else if (Convert.ToInt32(txtoqty.Text) > stock)
            {
                MessageBox.Show("Your quantity exceeds \n"+ stock +" units\n  of stock available");
            }

            else
            {
                num = num + 1;
                qty = Convert.ToInt32(txtoqty.Text);
                totaprice = qty * uprice;
                table.Rows.Add(num, prod,qty,uprice,totaprice);
                myorder.DataSource = table;
                flag = 0;
                sum = sum + totaprice;
                txtTot.Text = sum.ToString();
                updateStock();

            }
           
        }
      
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadProducts();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(txtOrderid.Text =="" || txtCN.Text == "" || ORDERdATE.Text == "" || txtTot.Text =="")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                
                try
                {
                    con.Open();

                    using (var cmd = new SqlCommand("insert into " + " orderstbl (OrderId,CustomerName,OrderDate,Total)" + " values(@OrderId,@CustomerName,@OrderDate,@Total)", con))
                    {
                        cmd.Parameters.Add(new SqlParameter("@OrderId", Convert.ToInt32(txtOrderid.Text)));
                        cmd.Parameters.Add(new SqlParameter("@CustomerName", txtCN.Text));
                        cmd.Parameters.Add(new SqlParameter("@OrderDate", this.ORDERdATE.Value));
                        cmd.Parameters.Add(new SqlParameter("@Total", Convert.ToInt32(txtTot.Text)));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully added order for '" + txtCN.Text + "'");
                        con.Close();
                        //loadProducts();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something wrong\n" + ex);

                }
            }
        }

        private void txtCN_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            vieworders orders = new vieworders();
            orders.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOrderid.Text = "";
            txtCN.Text = "";
            txtoqty.Text = "";
            
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Dash ds = new Dash();
            
            this.Hide();
            ds.Show();
        }

        private void ORDERdATE_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
