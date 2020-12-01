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
    public partial class vieworders : Form
    {
        public vieworders()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ruwa\Documents\carsales.mdf;Integrated Security=True;Connect Timeout=30");

        private void button2_Click(object sender, EventArgs e)
        {
            orders myor = new orders();
            this.Hide();
            myor.Show();
        }
        void loadProducts()
        {
            con.Open();
            string myquery = "select * from orderstbl ";
            SqlDataAdapter dat = new SqlDataAdapter(myquery, con);
            SqlCommandBuilder buil = new SqlCommandBuilder(dat);
            var ds = new DataSet();
            dat.Fill(ds);
            VIEWSDataGrid.DataSource = ds.Tables[0];
            con.Close();
        }

        private void VIEWSDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vieworders_Load(object sender, EventArgs e)
        {
            loadProducts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Summary of Order Available", new Font("Times New Roman", 25, FontStyle.Bold), Brushes.Teal, new Point(230));
            e.Graphics.DrawString("Orders Id :"+ VIEWSDataGrid.SelectedRows[0].Cells[0].Value.ToString(), new Font("Times New Roman", 25, FontStyle.Regular), Brushes.Black, new Point(80,100));
            e.Graphics.DrawString("Customer Name :" + VIEWSDataGrid.SelectedRows[0].Cells[1].Value.ToString(), new Font("Times New Roman", 25, FontStyle.Regular), Brushes.Black, new Point(80,135));
            e.Graphics.DrawString("Order Date :" + VIEWSDataGrid.SelectedRows[0].Cells[2].Value.ToString(), new Font("Times New Roman", 25, FontStyle.Regular), Brushes.Black, new Point(80,170));
            e.Graphics.DrawString("Total :" + VIEWSDataGrid.SelectedRows[0].Cells[3].Value.ToString(), new Font("Times New Roman", 25, FontStyle.Bold), Brushes.Red, new Point(80,203));
            e.Graphics.DrawString("Powered by Encoders Unlimited DevTeam(2020)", new Font("Times New Roman", 15, FontStyle.Italic), Brushes.Teal, new Point(240,257));
        }
    }
}
