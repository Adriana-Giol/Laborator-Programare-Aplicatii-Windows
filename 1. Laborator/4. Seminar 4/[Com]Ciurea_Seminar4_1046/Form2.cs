using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Contine clasa Stream Writter din care vom apela metoda WriteLine() care face scrierea in fisier

namespace _Com_Ciurea_Seminar4_1046
{
    public partial class Form2 : Form
    {
        //Nu instantiem lista2 pentru ca nu este o alta colectie, ci doar o referinta catre colectia din Form1
        List<Student> lista2;
        public Form2(List<Student> lista)
        {
            InitializeComponent();
            lista2 = lista;
        }

        private void btnAfisare2_Click(object sender, EventArgs e)
        {
            foreach (Student s in lista2)
              tbAfisareStudent2.Text += s.ToString() + Environment.NewLine;

        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            /*saveFileDialog poate sa fie control sau obiect
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "(*.txt)|*.txt"        */

            //Salvare fisier text in alta locatie decat cea implicita
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                //saveFileDialog este un control de tip Dialog care se foloseste pentru a ajuta utilizatorul sa aleaga locatia din calculator unde urmeaza sa salveaza un fisier
            {

                //Vrem sa salvam continutul Text Box-ului AfisareStudent din lista de studenti intr-un fisier text
                //Instantiem un Stream Writter
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);  // StreamWriter sw = new StreamWriter("fisier.txt"); - IN CAZUL IN CARE NU MODIFICAM LOCATIA IMPLICITA A FISIERULUI
                sw.WriteLine(tbAfisareStudent2.Text);
                sw.Close();
                tbAfisareStudent2.Clear();
            }
        }

        private void btnRestaurare_Click(object sender, EventArgs e)
        {
            //Citire din fisier
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "(*.txt)|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(dlg.FileName);
                tbAfisareStudent2.Text = sr.ReadToEnd();
                sr.Close();
            }

        }
    }
}
