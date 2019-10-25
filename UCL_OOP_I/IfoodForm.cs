using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UCL_OOP_I
{
    public partial class IfoodForm : Form
    {
        public IfoodForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            var xDoc = XDocument.Load(Form1.Endereço);
            var node = xDoc.Descendants("User").FirstOrDefault(us => us.Element("ID").Value == IdBox.Text);
            var pontos_atuais = Double.Parse(node.Element("Score").Value);

            if (node == null)
            {
                MessageBox.Show("User not Found!");
                xDoc.Save(Form1.Endereço);
                this.Close();
            }
            else if (pontos_atuais < 100000)
            {
                MessageBox.Show("You Need at least 100.000 Points to change for Uber Coupon! You have " + pontos_atuais + " Points");
            }
            else
            {
                string cupom = Cupom.cod_cupom();
                node.SetElementValue("Score", (pontos_atuais - 100000));
                MessageBox.Show("Cupom: R4P:IFOOD#" + cupom);

                MessageBox.Show("Restante de pontos: " + pontos_atuais);
            }
            xDoc.Save(Form1.Endereço);
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Close button
            this.Close();
        }
    }
}
