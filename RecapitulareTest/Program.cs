using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapitulareTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            // CONSTRUCTORI 
            Persoana p1 = new Persoana();
            Persoana p2 = new Persoana(new List<string>{"Giol ", "Adriana"},"Braila",new float[] { 155.3f, 225.4f },true,'N', new DateTime(1998,05,05),4578.3m,1000001.45);


            //TO STRING
            MessageBox.Show("P2:" + p2.ToString());


            //CLONE 
            Persoana p3 = (Persoana)p2.Clone();
     

            //PROPRIETATI
            string nume1 = "Matei Ion";

            p3.NumeComplet = new List<string> { "Vanesa ", "James " };
            p3.NumeComplet.Add(nume1);
            p3.SalariileAnului = new float[] { 10.0f,55.7f,158.78f };
            MessageBox.Show("P3: Modificare vector salarii si nume" + p3.ToString());
            MessageBox.Show("P2" + p2.ToString());

            //OPERATOR+
            p3 += 200.5f;
            MessageBox.Show("P3 Adaugare salariu in vectorul de salarii " + p3.ToString());

            //OPERATOR INDEX - VECTOR
           // MessageBox.Show("Salariul lunii martie este in valoare de" + p3[2] + " lei.");

            //OPERATOR INDEX - LIST
            MessageBox.Show("Al doilea nume este " + p3[1]);


        }
    }
}
