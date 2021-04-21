using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapitulareTest
{
    class Persoana : ICloneable, IComparable
    {
        //**********1. DEFINIRE ATRIBUTE*****************************************************************************************************************
        private int id;
        private List<String> numeComplet;
        private String localitate;
        private float[] salariileAnului;
        private bool esteFemeie;
        private char stareMatrimoniala;
        private DateTime dataNasterii;
        private decimal salariu;
        private double venitNet;        //CAT ARE VENITUL TOTAL (Conturi banci + pamanturi)

        private static int contorId;

        //************2. CONSTRUCTOR IMPLICIT***********************************************************************************************
        public Persoana()
        {
            this.id = contorId;
            this.numeComplet = new List<string>(new string[] { "Giol", "Adriana" });
            this.localitate = "Bucuresti";
            this.salariileAnului = new float[] { 210.5f, 350, 4f, 450.6f };
            this.esteFemeie = false;
            this.stareMatrimoniala = 'N';
            this.dataNasterii = System.DateTime.Now;
            this.salariu = 1245.5M;
            this.venitNet = 123.4;

            contorId++;
        }



        //*************3. CONSTRUCTOR CU PARAMETRI -  la vectori trebuie DEEP COPY********************************************************************************************************
        public Persoana(List<string> numeComplet, string localitate, float[] salariileAnului, bool esteFemeie, char stareMatrimoniala, DateTime dataNasterii, decimal salariu, double venitNet)
        {
            this.id = contorId;
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

            contorId++;
        }


        //*******************4. PRORPEITATI***************************************************************************************************
        public int Id { get => id; }
        public List<string> NumeComplet { get => numeComplet; set => numeComplet = value; }
        public string Localitate { get => localitate; set => localitate = value; }
        public float[] SalariileAnului { get => salariileAnului; set => salariileAnului = value; }
        public bool EsteFemeie { get => esteFemeie; set => esteFemeie = value; }
        public char StareMatrimoniala { get => stareMatrimoniala; set => stareMatrimoniala = value; }
        public DateTime DataNasterii { get => dataNasterii; set => dataNasterii = value; }
        public decimal Salariu { get => salariu; set => salariu = value; }
        public double VenitNet { get => venitNet; set => venitNet = value; }
     


        //**********5. TO STRING***************************************************************************************************************
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
                    + " si avand salariul in valoare de " + salariu + " lei"
                    + " si venitul Net Global in valaore de " + venitNet + " lei.";


            return afisare1 += afisare3;
        }
        //******************6. ICLONEABLE - CLONE*************************************************************************************************
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
            clona.salariileAnului = salariiAnualeNoi;
            return clona;

        }


        //**********7. ICOMPARABLE - COMPARE TO *********************************************************************************************
        // STRING
        /*
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

        }*/

        //COMPARE TO - INT/FLOAT

   /*     public int CompareTo(object obj)
        {
            Persoana p = (Persoana)obj;
            if (this.salariu < p.salariu)
                return -1;
            else
                if (this.salariu > p.salariu)
                return 1;
            else
                return 0; // daca fac compararea dupa un singur criteriu
            return string.Compare(this.localitate, p.localitate); // daca vreau sa fac compararea dupa 2 criterii
        }
   */

  

        //*******************************8.OPERATORI****************************************************************************************

        //                           OPERATOR + - VECTOR
        public static Persoana operator +(Persoana p, float salariuNou)
        {
            float[] salariiNoi = new float[p.salariileAnului.Length + 1];
            for (int i = 0; i < p.salariileAnului.Length; i++)
                salariiNoi[i] = p.salariileAnului[i];
            salariiNoi[salariiNoi.Length - 1] = salariuNou;
            p.salariileAnului = salariiNoi;
            return p;
        }
        //Operator + comutativ
        public static Persoana operator +(float salariuNou, Persoana p)
        {
            return p + salariuNou;
        }

        //OPERATOR ++ - APELEAZA OPERATORUL + DE MAI SUS SI ADAUGA SALRIUL 250.9
        public static Persoana operator ++(Persoana p)
        {
            return p + 250.9f;
        }

       //CAST
        public static explicit operator float(Persoana p)
        {
            if (p.salariileAnului!= null)
            {
                float suma = 0.0f;
                for (int i = 0; i < p.salariileAnului.Length; i++)
                    suma += p.salariileAnului[i];
                return (float)suma / p.salariileAnului.Length;
            }
            else
                return 0;
        }

        


        //OPERATOR INDEX  - VECTOR
       /* public float this[int index]
        {
            get
            {
                if (salariileAnului != null && index >= 0 && index < salariileAnului.Length)
                    return salariileAnului[index];
                else
                    return 0;
            }
            set
            {
                if (value > 0 && index >= 0 && index < salariileAnului.Length)
                    salariileAnului[index] = value;
            }
        }
       */

        //OPERATOR INDEX - LISTA DE STRING
       public String this[int index]
        {
            get
            {
                if (index >= 0 && index < numeComplet.Count && numeComplet != null)
                    return numeComplet[index];
                else
                    return null;
            }
        }



    }
}
