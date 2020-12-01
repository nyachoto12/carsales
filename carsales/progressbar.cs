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
    public partial class progressbar : Form
    {
        public progressbar()
        {
            InitializeComponent();
        }
        int st = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            st += 1;
            progressBar1.Value = st;
            if(progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                frmDash ds = new frmDash();
                this.Hide();
                ds.Show();
            }
        }

        private void progressbar_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
