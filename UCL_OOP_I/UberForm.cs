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
            var xDoc = XDocument.Load(User_register.Get_endereço());
            var node = xDoc.Descendants("User").FirstOrDefault(us => us.Element("ID").Value == IdBox.Text);
            var pontos_atuais = Double.Parse(node.Element("Score").Value);
            
            if (node == null)
            {
                MessageBox.Show("User not Found!");
                xDoc.Save(User_register.Get_endereço());
                this.Close();
            }else if (pontos_atuais < 80000)
            {
                MessageBox.Show("You Need at least 80.000 Points to change for Uber Coupon! You have "+ pontos_atuais + " Points");
            }
            else
            {
                string cupom = Cupom.cod_cupom();
                node.SetElementValue("Score", (pontos_atuais-80000));
                MessageBox.Show("Cupom: R4P:UBER#"+ cupom);
            }
            xDoc.Save(User_register.Get_endereço());
            this.Close();
        }

    }
}
