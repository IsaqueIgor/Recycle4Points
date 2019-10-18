using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace UCL_OOP_I
{
    public partial class User_register : Form
    {
        XmlSerializer xs;
        List<User> user_list;

        public User_register()
        {
            InitializeComponent();
            user_list = new List<User>();
            xs = new XmlSerializer(typeof(List<User>));
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Save button - Create User

            if (File.Exists("C:\\Users\\Isaque\\Documents\\Isaque\\UCL_User.Xml"))
            {
                Upload_user_xml();
            }
            else{
                Create_new_xml();
            }
            MessageBox.Show("User has been successfully saved!");
            this.Close();
        }
        private void Upload_user_xml()
        {
            XmlDocument doc = new XmlDocument();

            doc.Load("C:\\Users\\Isaque\\Documents\\Isaque\\UCL_User.Xml");
            XmlNode Client = doc.CreateElement("User");

            XmlNode Name = doc.CreateElement("Name");
                Name.InnerText = Namebox.Text;
                Client.AppendChild(Name);

            XmlNode Age = doc.CreateElement("Age");
                Age.InnerText = agebox.Text;
                Client.AppendChild(Age);

            XmlNode Id = doc.CreateElement("ID");
                Id.InnerText = idbox.Text;
                Client.AppendChild(Id);

            XmlNode Score = doc.CreateElement("Score");
                Score.InnerText = "0";
                Client.AppendChild(Score);

            doc.DocumentElement.AppendChild(Client);

            doc.Save("C:\\Users\\Isaque\\Documents\\Isaque\\UCL_User.Xml");
        }
        private void Create_new_xml()
        {
            XmlTextWriter xwriter = new XmlTextWriter("C:\\Users\\Isaque\\Documents\\Isaque\\UCL_User.Xml", Encoding.UTF8);
            xwriter.Formatting = Formatting.Indented;
            xwriter.WriteStartElement("Client");
            xwriter.WriteStartElement("User");
            xwriter.WriteStartElement("Name");
            xwriter.WriteString(Namebox.Text);
            xwriter.WriteEndElement();
            xwriter.WriteStartElement("Age");
            xwriter.WriteString(agebox.Text);
            xwriter.WriteEndElement();
            xwriter.WriteStartElement("ID");
            xwriter.WriteString(idbox.Text);
            xwriter.WriteEndElement();
            xwriter.WriteStartElement("Score");
            xwriter.WriteString("0");
            xwriter.WriteEndElement();
            xwriter.WriteEndElement();
            xwriter.WriteEndElement();
            xwriter.Close();
        }
        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
