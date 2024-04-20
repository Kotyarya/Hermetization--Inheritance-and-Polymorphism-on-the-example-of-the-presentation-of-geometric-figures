using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt2_Aksamitnyi62325
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        

        private void redirectToLabPart_ClickHandler(object sender, EventArgs e)
        {
            LabPart Form2 = new LabPart();
            this.Hide();
            Form2.Show();
        }

        private void redirectToIndPart_ClickHandler(object sender, EventArgs e)
        {
            IndPart Form3 = new IndPart();
            this.Hide();
            Form3.Show();
        }
    }
}
