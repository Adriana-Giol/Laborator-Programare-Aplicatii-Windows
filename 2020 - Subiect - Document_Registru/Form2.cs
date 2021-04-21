using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020___Subiect___Document_Registru
{
    public partial class Form2 : Form
    {
        List<Document> listaDocumente = new List<Document>();
        public Form2()
        {
            InitializeComponent();
            listaDocumente.Add(new Document(10, "Tratat de pace", System.DateTime.Now));
        }

       
    }
}
