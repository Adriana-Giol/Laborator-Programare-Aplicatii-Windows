using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapitulareTest
{
    class Persoana:ICloneable, IComparable
    {
        //1. DEFINIRE ATRIBUTE
        private const String cnp = "29805060051";
        private List<String> numeComplet;
        private String localitate;
        private float[] salariileAnului;
        private bool esteFemeie;
        private char stareMatrimoniala;
        private DateTime dataNasterii;
        private decimal salariu;
        private double venitNet;        //CAT ARE VENITUL TOTAL (Conturi banci + pamanturi)


        //2. CONSTRUCTOR IMPLICIT
        public Persoana()
        {
            this.numeComplet = new List<string>(new string[] {"Giol", "Adriana"});
            this.localitate = "Bucuresti";
            this.salariileAnului = new float[] { 210.5f, 350, 4f, 450.6f };
            this.esteFemeie = false;
            this.stareMatrimoniala = 'N';
            this.dataNasterii = System.DateTime.Now;
            this.salariu = 1245.5M;
            this.venitNet = 123.4;
        }



        //3. CONSTRUCTOR CU PARAMETRI -  la vectori trebuie DEEP COPY
        public Persoana(List<string> numeComplet, string localitate, float[] salariileAnului, bool esteFemeie, char stareMatrimoniala, DateTime dataNasterii, decimal salariu, double venitNet)
        {
            this.numeComplet = new List<string>(numeComplet);
            this.localitate = localitate;

            //DEEP COPY - VARIANTA 1
              this.salariileAnului = new float[salariileAnului.Length];
              for (int i = 0; i < salariileAnului.Length; i++)
              {
                  this.salariileAnului[i] = salariileAnului[i];
              }

            //DEEP COPY - VARIANTA 2: CLONE
           // this.SalariileAnului = (float[])salariileAnului.Clone();

            this.esteFemeie = esteFemeie;
            this.stareMatrimoniala = stareMatrimoniala;
            this.dataNasterii = dataNasterii;
            this.salariu = salariu;
            this.venitNet = venitNet;
        }

        
        //4. PRORPEITATI
        public List<string> NumeComplet { get => numeComplet; set => numeComplet = value; }
        public static string Cnp => cnp;
        public string Localitate { get => localitate; set => localitate = value; }
        public float[] SalariileAnului { get => salariileAnului; set => salariileAnului = value; }
        public bool EsteFemeie { get => esteFemeie; set => esteFemeie = value; }
        public char StareMatrimoniala { get => stareMatrimoniala; set => stareMatrimoniala = value; }
        public DateTime DataNasterii { get => dataNasterii; set => dataNasterii = value; }
        public decimal Salariu { get => salariu; set => salariu = value; }
        public double VenitNet { get => venitNet; set => venitNet = value; }


        //5. TO STRING
        public override string ToString()
        {
            //Afisare pentru lista
            string afisare1 = "Persoana cu numele ";
            foreach (string s in numeComplet) {
                afisare1 += s.ToString();
            }

            //Afisare pentru vector
           if (salariileAnului != null)
           {
                afisare1 += " a avut urmatoarele salarii ";
                for (int i = 0; i < salariileAnului.Length; i++)
                    afisare1 += salariileAnului[i] + Environment.NewLine;
           }
            else
                afisare1 += " nu a fost angajat in ultimul an.";

           //Afisare pentru atribute normale
            string afisare3 = "Persoana are resedinta in localitatea " + localitate + "," 
                    + " este Femeie = " + esteFemeie
                    + " avand starea matrimoniala " + stareMatrimoniala 
                    + "fiind nascuta la data de " + dataNasterii 
                    + " si avand salariul in valoare de " + salariu +" lei"
                    +" si venitul Net Global in valaore de " + venitNet + " lei.";

                   
            return afisare1 +=afisare3;
        }

        public object Clone()
        {
            //PENTRU LIST

            //return this.MemberwiseClone(); - daca lasam doar asa nu o sa stie sa copieze lista de string-uri
            Persoana clona = (Persoana)this.MemberwiseClone();
            List<string> numeNou = new List<string>();
            foreach (string s in numeComplet)
                numeNou.Add((string)s.Clone());
            clona.numeComplet = numeNou;

            //PENTRU VECTOR
            float[] salariiAnualeNoi = (float[])salariileAnului.Clone();
            clona.salariileAnului= salariiAnualeNoi;
            return clona;

        }


        //6. COMPARE TO - STRING
        public int CompareTo(object obj)
        {
            Persoana p = (Persoana)obj;  //facem CAST

            string localitate1 = this.localitate;
            string localitate2 = p.localitate;

            if(localitate1.Equals(localitate2, StringComparison.OrdinalIgnoreCase))
            {
                return 1; //true
            }
            else
            {
                return -1;//false;
            }

        }

        //COMPARE TO - INT/FLOAT


    }
}
