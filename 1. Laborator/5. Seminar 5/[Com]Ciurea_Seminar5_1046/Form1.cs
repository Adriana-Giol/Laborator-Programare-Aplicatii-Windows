using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace _Com_Ciurea_Seminar5_1046
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnParsare_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("nbrfxrates.xml");
            //MessageBox.Show(sr.ReadToEnd());

            //Putem fisierul intr-un string, nu intr-un Message Box - doar citesc din fisier si afisez nicaieri
            string str = sr.ReadToEnd();
            sr.Close();


            XmlReader reader = XmlReader.Create(new StringReader(str));
            while (reader.Read()) 
            {
                if (reader.Name == "PublishingDate" && reader.NodeType == XmlNodeType.Element)
                {
                    //Sar de pe tag pe valoarea din interiorul tag-ului
                    reader.Read();

                    tbDataCurs.Text = reader.Value;
                }
                //Ne pozitionam pe nodul Rate si selectam Currency
                if (reader.Name == "Rate" && reader.NodeType == XmlNodeType.Element)
                {
                    string atribut = reader["currency"];
                    if (atribut == "EUR"){
                        reader.Read();
                        tbEUR.Text = reader.Value;

                    }
                    else
                         if (atribut == "USD")
                    {
                        reader.Read();
                        tbUSD.Text = reader.Value;

                    }
                    else
                         if (atribut == "GBP")
                    {
                        reader.Read();
                        tbGBP.Text = reader.Value;

                    }
                    else
                         if (atribut == "XAU")
                    {
                        reader.Read();
                        tbXAU.Text = reader.Value;

                    }
                }

            }
        }

        private void btnGenerare_Click(object sender, EventArgs e)
        {
            
            MemoryStream memStream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(memStream, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            writer.WriteStartDocument();

                writer.WriteStartElement("CursValutar");

                        writer.WriteStartElement("CursValutar");
                        writer.WriteValue(tbDataCurs.Text);
                        writer.WriteEndElement();

                        writer.WriteStartElement("CursEUR");
                        writer.WriteAttributeString("Value", "EUR");
                        writer.WriteValue(tbDataCurs.Text);
                        writer.WriteEndElement();

                        writer.WriteStartElement("Cursusd");
                        writer.WriteAttributeString("Value", "USD");
                        writer.WriteValue(tbDataCurs.Text); //Valoare nodului
                        writer.WriteEndElement();

                        writer.WriteStartElement("CursGBP");
                        writer.WriteAttributeString("Value", "GBP");
                        writer.WriteValue(tbDataCurs.Text);
                        writer.WriteEndElement();

                        writer.WriteStartElement("CursXAU");
                        writer.WriteAttributeString("Value", "XAU");
                        writer.WriteValue(tbDataCurs.Text);
                        writer.WriteEndElement();


            writer.WriteEndElement();

            writer.WriteEndDocument();

            writer.Close();

            //Preluare continutului 
            string str = Encoding.UTF8.GetString(memStream.ToArray());

            //Salvare fisier pe disc
            StreamWriter sw = new StreamWriter("fisier.xml");
            sw.WriteLine(str);
            sw.Close();
            MessageBox.Show("Am generat!");
        }
    }
}
