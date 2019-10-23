using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCL_OOP_I {
    public partial class rewards : Form {
        public rewards()
        {
            InitializeComponent();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            UberForm Uber = new UberForm();
            Uber.ShowDialog();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            IfoodForm Ifood = new IfoodForm();
            Ifood.ShowDialog();
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            AmazonForm Amazon = new AmazonForm();
            Amazon.ShowDialog();
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            CréditoForm Crédito = new CréditoForm();
            Crédito.ShowDialog();
        }
    }
}
