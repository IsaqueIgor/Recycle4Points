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
    public partial class UberForm : Form
    {
        public UberForm()
        {
            InitializeComponent();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            var xDoc = XDocument.Load("C:\\Users\\Isaque\\Documents\\Isaque\\UCL_User.Xml");
            var node = xDoc.Descendants("User").FirstOrDefault(us => us.Element("ID").Value == IdBox.Text);
            var pontos_atuais = Double.Parse(node.Element("Score").Value);
            if (node == null)
            {
                MessageBox.Show("User not Found!");
                xDoc.Save("C:\\Users\\Isaque\\Documents\\Isaque\\UCL_User.Xml");
                this.Close();
            }else if (pontos_atuais < 100)
            {
                MessageBox.Show("You Need at least 100 Points to change for Uber Coupon! You have "+ pontos_atuais + " Points");
            }
            else
            {
                node.SetElementValue("Score", (pontos_atuais-100));
                MessageBox.Show("Cupom: ECORIDE15");
            }
            xDoc.Save("C:\\Users\\Isaque\\Documents\\Isaque\\UCL_User.Xml");
            this.Close();
        }
    }
}
