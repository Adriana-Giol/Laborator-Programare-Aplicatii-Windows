using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020___Subiect___Document_Registru
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

            Document d1 = new Document(10, "Tratat de pace", new DateTime(1993, 12, 6));
            Document d2 = new Document(11, "Tratat de razboi", new DateTime(1994, 01, 3));
            Document d3 = new Document(12, "Tratat de amicitie", new DateTime(1995, 02, 2));
            MessageBox.Show(d1.ToString());

            List<Document> listaDocuemnte = new List<Document>();
            listaDocuemnte.Add(d1);
            listaDocuemnte.Add(d2);
            listaDocuemnte.Add(d3);
            listaDocuemnte.Sort();

            foreach (Document d in listaDocuemnte)
            {
                Console.WriteLine(d);

            }
            Document d4 = (Document)d3.Clone();

            Registru r1 = new Registru();
            r1.ListaDocumente.Add(d1);

            r1.ListaDocumente.Add(d2);

            r1.ListaDocumente.Add(d3);
        }
    }
}
