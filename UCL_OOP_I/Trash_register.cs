using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static UCL_OOP_I.Trash;

namespace UCL_OOP_I
{
    public partial class Trash_register : Form
    {
        public Trash_register()
        {
            InitializeComponent();
            comboBoxTrashType.Items.Add(TrashType.Glass);
            comboBoxTrashType.Items.Add(TrashType.Metal);
            comboBoxTrashType.Items.Add(TrashType.Paper);
            comboBoxTrashType.Items.Add(TrashType.Plastic);
            qualitybox.Items.Add(TrashQuality.Excellent);
            qualitybox.Items.Add(TrashQuality.Average);
            qualitybox.Items.Add(TrashQuality.Good);
            qualitybox.Items.Add(TrashQuality.Poor);
            qualitybox.Items.Add(TrashQuality.Low);
        }

        private void ComboBoxTrashType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Clsbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Recycle_button_Click(object sender, EventArgs e)
        {
            var xDoc = XDocument.Load("C:\\Users\\Isaque\\Documents\\Isaque\\UCL_User.Xml");
            var node = xDoc.Descendants("User").FirstOrDefault(us => us.Element("ID").Value == id_user.Text);

            if(node == null)
            {
                MessageBox.Show("User not Found!");
                xDoc.Save("C:\\Users\\Isaque\\Documents\\Isaque\\UCL_User.Xml");
                this.Close();
            }

            var new_score = (Int32.Parse(node.Element("Score").Value)) + Calcular_pontos(Double.Parse(trash_weight.Text));
            new_score = Multiplicador_qualidade(new_score);
            node.SetElementValue("Score", new_score);

            MessageBox.Show("Success! Thanks for your collaboration =)");
            xDoc.Save("C:\\Users\\Isaque\\Documents\\Isaque\\UCL_User.Xml");
        }

        private double Calcular_pontos(double trash_weight)
        {
            double Pontos = 0;
            TrashType x = (TrashType) comboBoxTrashType.SelectedItem;
            switch (x)
            {
                case TrashType.Glass:
                    Pontos = trash_weight * (10);
                    break;
                case TrashType.Metal:
                    Pontos = trash_weight *(15);
                    break;
                case TrashType.Paper:
                    Pontos = trash_weight * (20);
                    break;
                case TrashType.Plastic:
                    Pontos = trash_weight * (25);
                    break;
            }
            return Pontos;
        }

        private double Multiplicador_qualidade(double Score)
        {
            TrashQuality choice = (TrashQuality)comboBoxTrashType.SelectedItem;
            switch (choice)
            {
                case TrashQuality.Excellent:
                    Score *= (2);
                    break;
                case TrashQuality.Good:
                    Score *= (1.5);
                    break;
                case TrashQuality.Average:
                    Score *= (1);
                    break;
                case TrashQuality.Poor:
                    Score *= (0.5);
                    break;
                case TrashQuality.Low:
                    Score *= (0.1);
                    break;
            }
            return Score;
        }
    }
}
