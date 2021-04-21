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
            Persoana p2 = new Persoana(new List<string>{"Giol", "Adriana"},"Braila",new float[] { 155.3f, 225.4f },true,'N', new DateTime(1998,05,05),4578.3m,1000001.45);


            //TO STRING
            MessageBox.Show(p2.ToString());


            //CLONE 
            
            //PROPRIETATI
            

        }
    }
}
