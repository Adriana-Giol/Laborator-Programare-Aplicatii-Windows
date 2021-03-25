using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Com_Ciurea_Seminar4_1046
{
    
   public class Student : Persoana,ICloneable,IComparable,IMedia
    {
        //Declarare atribute 
        private int varsta;
        private string nume;
        private int[] note;

        //Constructorul implicit
        public Student() : base()
        {
            this.varsta = 0;
            this.nume = "Anonim";
            this.note = null;
        }

        //Constructorul cu parametri 
        public Student(int cod, char sex, int varsta, string nume, int[]note) : base( cod, sex)
        {
            this.varsta = varsta;
            this.nume = nume;
            this.note = note; // Shallow Copy 

            //Deep Copy pentru vectorul de note - alocare de spatiu - VARIANTA CLASICA
            this.note = new int[note.Length];
            for (int i = 0; i < note.Length; i++)
            {
                this.note[i] = note[i];
            }

            //DEEP COPY  - CU CLONE
            this.note = (int[])note.Clone();
        }


        //Implementare TO STRING - pentru un vector 

        public override string ToString()
        {
            string rezultat = base.ToString() + " varsta " + varsta + " numele " + nume;
            if (note != null)
            {
                rezultat += " si are urmatoarele note ";
                for (int i = 0; i < note.Length; i++)
                    rezultat += note[i] + " ";
            }
            else
                rezultat += " si nu are note";
            return rezultat;

        }
        /*Dam click pe beculet dupa ce derivam clasa si dam "Implement abstract class" care ne face un override al metodei "spuneAnNastere
                - Avem varsta la dispozitie deci putem sa facem o diferenta dintre anul curent si varsta ca sa stiu care este anul nasterii*/
        public override void spuneAnNastere()
        {
            Console.WriteLine("Anul nasterii este: {0}", System.DateTime.Now.Year - varsta);
        }

        //Implementare ICloneable
        public object Clone()
        {
            //  return this.MemberwiseClone();  - o sa afiseze vectorul dar obiectele vor partaja acelasi vector - FACE SHALLOW COPY

            Student clona = (Student)this.MemberwiseClone();
            int[] noteNoi = (int[]) note.Clone();
            clona.note = noteNoi;
            return clona;
        }

        //Implementare IComparable
        /* Daca au aceeasi medie, sortez studentii dupa medie, altfel cel care are media mai mica este ultimul (sortati descrescator dupa medie)*/
        public int CompareTo(object obj)
        {
            Student s = (Student)obj;
            if ((float)this > (float)s)
                return -1;
            
            else
                if ((float)this < (float)s)
                    return 1;
            
            else
                return string.Compare(this.nume, s.nume);
            
        }

        //Implementare interfata IMedia
        public float calculeazaMedie()
        {
            return (float)this;   // Operatorul cast de float pentru obiectul curent -- se putea lua cu Copy-paste de la operatorul de cast
        }

        /**************************************************** SUPRAINCARCARI DE OPERATOR+  ***************************************************************
         
            - Facem supraincarcare de operator+ pe student ca sa ii putem adauga o nota in vector
            - Daca eu am un student cu un vector de nota si vreau sa ii adaug o nota noua trebuie sa redimensionez acel vector */

        public static Student operator+ (Student s, int notaNoua)
        {
            int[] noteNoi = new int[s.note.Length + 1]; // Alocam spatiu pentru un nou vector cu dimensiunea vectorului vechi + 1 
            for(int i = 0; i < s.note.Length; i++)
            {
                noteNoi[i] = s.note[i];
            }
            noteNoi[noteNoi.Length - 1] = notaNoua;   // punem pe ultima pozitie din vector, nota noua
            s.note = noteNoi;   //modific referinta vectorului catre noul vector
            return s;
        }

        //******************************************************* SUPRAINCARCARE OPERATOR ++ *************************************************************
        public static Student operator++ (Student s)
        {
            return s + 1;  // Apeleaza operatorul+ 9supraincarcat anterior) unde o sa ii adauge studentului nota 1
        }

        //****************************************************** SUPRAINCARCARE OPERATOR CAST *************************************************************
        /* Facem cast la float ca sa facem o medie din vectorul de note 
         * - Operatorul cast se recomanda sa fie implementat ca varianta explicita, pentru ca exista si forma implicita a lui
            - Daca implementez forma implicita (cu "implicit") peste tot unde va gasi numele obiectului (s2, s1, s3) il va transforma intr-o medie. */ 

        public static explicit operator float(Student s)
        {
            if (s.note != null)
            {
                int suma = 0;
                for (int i = 0; i < s.note.Length; i++)
                {
                    suma += s.note[i];
                }
                return (float)suma / s.note.Length;
            }
            else
                return 0;
        }

    //*********************************************************** SUPRAINCARCARE OPERATOR INDEX **************************************************
    /* Operatorul index se poate supraincarca si in varianta de get si in varianta de set
        Operatorul index nu are nume si se implementeaza ca o prorpietate
        La acest operator index lucram cu referinta this si nu mai lucram cu parametrul Student s
        Functia de asemnenea nu mai  ezte statica
        Indexul este singurul operator care se implementeaza diferit - se implementeaza ca o proprietate (cu get si set) si fiind proprietate poate accesa
            atributele clasei*/

        public int this[int index]
        {
            get
            {
                if(note != null && index >= 0 && index < note.Length)
                {
                    return note[index];
                }
                else
                {
                    return 0;
                }
            }


            //Ma asigur ca pun in vector pe pozitia [index] o nota valida -  0 < nota >= 10
            set
            {
                if(value >0 && value <= 10 && index >= 0 && index < note.Length)
                {
                    note[index] = value;
                }
            }
        }

        //Prorpietate pentru atributul Varsta
        public int Varsta
        {
            get { return this.varsta; }
            set { if(value> 0) this.varsta = value; }
        }
    }
}
