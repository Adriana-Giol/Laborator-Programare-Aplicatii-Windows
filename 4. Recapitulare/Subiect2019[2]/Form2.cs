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

namespace Subiect2019_2_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "(*.txt)|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(dlg.FileName);

                string linie = null;
                while ((linie = sr.ReadLine()) != null)
                {
                    try
                    {
                        string nume = linie.Split(',')[0];
                        int cod = Convert.ToInt32(linie.Split(',')[1]);
                        string adresa = linie.Split(',')[2];
                        string tipClient = linie.Split(',')[3];
                        float suma = Convert.ToInt32(linie.Split(',')[4]);



                        ClientRauPlatnic c = new ClientRauPlatnic(nume, cod, adresa, tipClient, suma);
                        lista.Add(c);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                sr.Close();
                MessageBox.Show("Date incarcate!");
            }
    }
}
