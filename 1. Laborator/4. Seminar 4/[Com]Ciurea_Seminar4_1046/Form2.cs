using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Com_Ciurea_Seminar4_1046
{
    public partial class Form2 : Form
    {
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
    }
}
