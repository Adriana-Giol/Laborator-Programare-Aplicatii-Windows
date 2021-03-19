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
    public partial class Form1 : Form
    {
        List<Student> listaStud = new List<Student>();
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
            //Console.WriteLine("Am facut click pe buton");   - Nu mai apelam console.Writeline pentru ca nu mai suntem in Console, ci in Forms
            //Ca sa afisam mesaje ne folosim de un MessageBox
            //MessageBox.Show("Bun venit!");

            /*Conversie pentru int - poate genera exceptii daca utilizatorul introduce litere sau nu introduce nimic - 
                    //CRAPA APLICATIA - facem try- catch*/
            try
            {
                int cod = Convert.ToInt32(tbCod.Text);
                char sex = Convert.ToChar(cbSex.Text);
                int varsta = Convert.ToInt32(tbVarsta.Text);
                string nume = tbNume.Text; //pentru nume nu mai trebuie sa facem conversia pentru ca este deja STRING

                /*Vectorul de note il preluam ca si un vector de string-uri, adica el acum e un sir de caractere separat prin virgula
                    Folosim metoda Trim() pentru eliminarea spatiilor dintre elemente*/
                string[] noteS = tbNote.Text.Trim().Split(',');

                //Daca vreau sa transform acele string-uri in int - adica vector de int-uri - ne alocam un vector
                int[] note = new int[noteS.Length];

                //Transformam fiecare nota din string in int 
                for (int i = 0; i < noteS.Length; i++)
                {
                    note[i] = Convert.ToInt32(noteS[i]);
                }

                //Acum putem crea un student
                Student s = new Student(cod, sex, varsta, nume, note);
                MessageBox.Show(s.ToString());

                //Adaugare student in lista
                listaStud.Add(s);

            }
            catch (Exception exceptie)
            {
                MessageBox.Show(exceptie.Message);
            }

            //Ca sa facem sa dispara valorile introduce dupa ce am dat creare Student - avem metoda Clear sau cu String gol
            //Blocul de finally se apeleaza mereu
            finally {
                tbCod.Clear();
                cbSex.Text = "";
                tbVarsta.Text = "";
                tbNume.Clear();
                tbNote.Clear();
            }

            /*Dupa ce am creat un student vrem sa il punem intr-o lista pentru ca vrem sa avem o lista de studenti
            sa o afisam intr-un formular secundar
                -Declaram o lista de studenti
                -Dupa ce il afisam il si adaugam in lista in for*/

            
          
        }

        private void metodaMea(object sender, EventArgs e)
        {
            btnCreareStudent.Click -= new EventHandler(btnCreareStudent_Click);
            MessageBox.Show("Am facut click prin metoda mea!");
        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
            //Parcurgerea studentului si afisarea lui in lista la apasarea butonului
            //    foreach (Student s in listaStud)
            //        tbAfisareStudent.Text += s.ToString() + Environment.NewLine;


            //Pentru afisarea in formularul 2 - dam lista de studenti ca parametru si in constructorul din form2
            Form2 frm = new Form2(listaStud);
            frm.ShowDialog();
        }

       
    }
}
