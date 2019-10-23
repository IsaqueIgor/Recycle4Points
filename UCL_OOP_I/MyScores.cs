using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace UCL_OOP_I
{

    public partial class MyScores : Form
    {
        public MyScores()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(User_register.Get_endereço());

            var listagem = new List<User>();

            foreach(XmlNode node in xDoc.SelectNodes("/Client/User"))
            {
                var single_user = new User
                {
                    Name = node.SelectSingleNode("Name").InnerText,
                    Age = Int32.Parse(node.SelectSingleNode("Age").InnerText),
                    User_id = Int32.Parse(node.SelectSingleNode("ID").InnerText),
                    Eco_points = Double.Parse(node.SelectSingleNode("Score").InnerText)
                };

                listagem.Add(single_user);
            }

            dataGridView1.DataSource = listagem;
        }

        private void MyScores_Load(object sender, EventArgs e)
        {
            userBindingSource.DataSource = new List<User>();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
