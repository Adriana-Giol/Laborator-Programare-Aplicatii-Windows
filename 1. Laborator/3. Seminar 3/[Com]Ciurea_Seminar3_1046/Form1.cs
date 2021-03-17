using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Com_Ciurea_Seminar3_1046
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*Avem 2  metode cu aceeasi semnatura si cand vreau sa folosesc una dintre ele ma duc in Form1.Designer.cs
            si la implementarea butonului - unde am implementat evenimentul de click doar schimb referinta 
            this.metoda1 sau this.metoda2 sau pot sa dublez evenimentul de click pentru a le apela pe mandoua. 
        Pot sa mai apelez o metoda cu += apoi sa o scot cu -=  (metoda statica); Varianta dinamica e sa scriu in metoda care vreau in continuare 
        sa apara, dezabonarea metodei care nu vreau sa mai apara cu ajutorul operatorului -= */ 

        private void btnCreareStudent_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Am facut click pe buton");
        }

        private void metodaMea(object sender, EventArgs e)
        {
            btnCreareStudent.Click -= new EventHandler(btnCreareStudent_Click);
            Console.WriteLine("Am facut click prin metoda mea!");
        }
    }
}
