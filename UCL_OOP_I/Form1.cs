using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace UCL_OOP_I
{
    public partial class Form1 : Form
    {
        public static string Endereço { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            //Input trash
            Trash_register trash = new Trash_register();
            trash.ShowDialog();
        }

        private void User_register_Click(object sender, EventArgs e)
        {
            User_register user_register = new User_register();
            user_register.ShowDialog();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            //Close button
            this.Close();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            MyScores score = new MyScores();
            score.ShowDialog();
        }

        private void PictureBox7_Click_1(object sender, EventArgs e)
        {
            rewards recompensa = new rewards();
            recompensa.ShowDialog();
        }

        private void Folderconfig_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select your XML Recycle4Points DataBase Path";
            if (fbd.ShowDialog() == DialogResult.OK)
                MessageBox.Show(" Selected " + fbd.SelectedPath);
            Endereço = fbd.SelectedPath+"\\User_UCL.Xml";

        }
    }
}
