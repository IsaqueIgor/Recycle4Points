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
            comboBoxTrashType.Items.Add(TrashType.Eletronics);
            qualitybox.Items.Add(TrashQuality.Excellent);
            qualitybox.Items.Add(TrashQuality.Good);
            qualitybox.Items.Add(TrashQuality.Average);
            qualitybox.Items.Add(TrashQuality.Low);
            qualitybox.Items.Add(TrashQuality.Poor);
            comboBox1.Items.Add(Glass.Vidro_cristal);
            comboBox1.Items.Add(Paper.Papelão);
            comboBox1.Items.Add(Paper.Papel_comum);
            comboBox1.Items.Add(Paper.Revista);
            comboBox1.Items.Add(Paper.Jornal);
            comboBox1.Items.Add(Metal.Alumínio);
            comboBox1.Items.Add(Metal.Cobre);
            comboBox1.Items.Add(Metal.Outros_metais);
            comboBox1.Items.Add(Eletronics.Pilhas);
            comboBox1.Items.Add(Eletronics.PC);
            comboBox1.Items.Add(Eletronics.Impressora);
            comboBox1.Items.Add(Eletronics.Celular);
            comboBox1.Items.Add(Plastic.PET);
            comboBox1.Items.Add(Plastic.Sacola);
            comboBox1.Items.Add(Plastic.Isopor);
        }

        private void ComboBoxTrashType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Clsbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Recycle_button_Click(object sender, EventArgs e)
        {
            var xDoc = XDocument.Load(User_register.Get_endereço());
            var node = xDoc.Descendants("User").FirstOrDefault(us => us.Element("ID").Value == id_user.Text);

            if(node == null)
            {
                MessageBox.Show("User not Found!");
                xDoc.Save(User_register.Get_endereço());
                this.Close();
            }

            var new_score = (Int32.Parse(node.Element("Score").Value)) + Calcular_pontos(Double.Parse(trash_weight.Text));
            new_score = Multiplicador_qualidade(new_score);
            node.SetElementValue("Score", new_score);

            MessageBox.Show("Success! Thanks for your collaboration =)");
            xDoc.Save(User_register.Get_endereço());
        }

        private double Calcular_pontos(double trash_weight)
        {
            double Pontos = 0;
            TrashType x = (TrashType) comboBoxTrashType.SelectedItem;
            switch (x)
            {
                case TrashType.Paper:
                    Paper a = (Paper) comboBox1.SelectedItem;

                    switch (a)
                    {
                        case Paper.Papelão:
                            Pontos += (trash_weight*250);
                            break;
                        case Paper.Papel_comum:
                            Pontos += (trash_weight*300);
                            break;
                        case Paper.Revista:
                            Pontos += (trash_weight*250);
                            break;
                        case Paper.Jornal:
                            Pontos += (trash_weight*250);
                            break;
                    }
                    break;
                case TrashType.Metal:
                    Metal b = (Metal)comboBox1.SelectedItem;

                    switch (b)
                    {
                        case Metal.Alumínio:
                            Pontos += (trash_weight*3500);
                            break;
                        case Metal.Cobre:
                            Pontos += (trash_weight*7500);
                            break;
                        case Metal.Outros_metais:
                            Pontos += (trash_weight*300);
                            break;
                    }
                    break;
                case TrashType.Glass:
                    Glass c = (Glass)comboBox1.SelectedItem;

                    switch (c)
                    {
                        case Glass.Vidro_cristal:
                            Pontos += (trash_weight*80);
                            break;
                    }
                    break;
                case TrashType.Plastic:
                    Plastic d = (Plastic)comboBox1.SelectedItem;

                    switch (d)
                    {
                        case Plastic.PET:
                            Pontos += (trash_weight*800);
                            break;
                        case Plastic.Sacola:
                            Pontos += (trash_weight*300);
                            break;
                        case Plastic.Isopor:
                            Pontos += (trash_weight*40);
                            break;
                    }
                    break;
                case TrashType.Eletronics:
                    Eletronics e = (Eletronics)comboBox1.SelectedItem;

                    switch (e)
                    {
                        case Eletronics.Pilhas:
                            Pontos += (trash_weight*20);
                            break;
                        case Eletronics.PC:
                            Pontos += (trash_weight*800);
                            break;
                        case Eletronics.Celular:
                            Pontos += (trash_weight*1800);
                            break;
                        case Eletronics.Impressora:
                            Pontos += (trash_weight*1800);
                            break;
                    }
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
