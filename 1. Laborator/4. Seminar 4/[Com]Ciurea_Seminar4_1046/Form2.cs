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
using System.Runtime.Serialization.Formatters.Binary; //Conitne clasa clasa BinaryFormatter care contine metodele Serialization si Deserialization

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
        //***************************************  SERIALIZARE *********************************************************
        private void btnSerializare_Click(object sender, EventArgs e)
        {
            //In cazul serializarii/deserializarii fisierul din care scriu este tot ala din care citesc
            //Instantiem un obiect din clasa BynaryFormatter
            BinaryFormatter bf = new BinaryFormatter();

            //Ne definim fisier pe disc cu ajutorul unui FileStream
            FileStream fs = new FileStream("fisier.dat", FileMode.Create, FileAccess.Write);

            //Serializare continut TextBox
          //  bf.Serialize(fs, tbAfisareStudent2.Text);   
            bf.Serialize(fs, lista2);                   //Pentru serializare lista

            //Inchidem fisierul
            fs.Close();
            //Golim casuta
            tbAfisareStudent2.Clear();

        }

  


        //***************************************  DESERIALIZARE  *********************************************************
        private void btnDeserializare_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("fisier.dat", FileMode.Open, FileAccess.Read);
            tbAfisareStudent2.Text = (string)bf.Deserialize(fs);

            //Deserializare lista
            List<Student> lista3 = (List<Student>)bf.Deserialize(fs);

                //Ca sa re-afisez lista trebuie sa am foreach
                foreach(Student s in lista3)
            {
                tbAfisareStudent2.Text += ToString() + Environment.NewLine;
            }


            fs.Close();
        }
    }
}
