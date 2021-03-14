using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Ciurea_Seminar1
{
    /*Namespace-ul este acelasi pentru toate clasele - daca luam o clasa dintr-un alt proiect trebuie sa ne 
        asiguram ca namespace-ul se potriveste cu al nostru*/
    class Student
    {
        //*********************************************** DEFINIRE ATRIBUTE *****************************************************************
        // - fiecare atribut are propriul modificator de acces - default e private
        /*Protected ramane cu aceeasi utilitate ca si in C++, adica extinde vizibilitatea atributului si in cadrul claselor derivate*/
        //In C# si Java nu exista derivare multipla.
        private int cod;
        private string nume;
        public int varsta;
        protected float medie;


        //***************************************************** CONSTRUCTOR IMPLICIT **************************************************************
        /*- Daca uitam sa punem public Lazy constructor inseamna ca acel constructor este privat si nu il putem folosi in afara clasei
         deci nu putem sa instantiem obiect. Constructorul privat este necesar doar in cazul unui Singleton*/
        public Student()
        {
            this.cod = 0;
            this.nume = "Anonim";
            this.varsta = 0;
            this.medie = 0.0f;    // f vine de la float (virgula mobila simpla precizie), deoarece 0.0 este implicit un double (virgula mobila dubla precizie)
        }
        /*Pointerul this este un pointer catre obiectul curent al clasei
            - In C# lucram cu referinte, deci this-> este inlocuit de this.*/

    //****************************************************CONSTRUCTOR CU PARAMETRI******************************************************

        public Student(int cod, string nume, int varsta, float medie)
        {
            this.cod = cod;
            this.nume = nume;
            this.varsta = varsta;
            this.medie =medie;
        }
        //****************************************************CONSTRUCTOR DE COPIERE ******************************************************
        //- Creaza spatiu pentru un nou obiect in HEAP si va copia in acel spatiu valorile primit ca parametru

        //DIFERENTA CONSTRUCTOR DE COPIERE - OPERATOR = 
            //Operatorul = foloseste 2 obiecte deja existente si copiaza dintr-unul in altul
            //Constructorul de copiere creaza un obiect de baza unui deja existent
            
        public Student(Student s)
        {
            this.cod = s.cod;
            this.nume = s.nume;
            this.varsta = s.varsta;
            this.medie = s.medie;
        }

        //********************************************* PROPRIETATI - FUNCTII ACCESOR ***************************************************
        //Functiile accesor (get si set) in C# nu se mai implementeaza ca functii ci se implementeaza ca proprietati
        //Pentru fiecare atribut PRIVAT  pentru a putea accesa respectivul atribut in afara clasei este nevoie sa implementam o proprietate

        /*CONVENTII DE NUME:
            - Atribut = prima litera mica:  numeStudent
            - Proprietati = nume atribut, dar cu prima litera mare: NumeStudent*/
            

        public string Nume
        {
            get { return nume; }
            set {
                if (value != null) nume = value; //value joaca rol de parametru pe care il primeam la seter
            } 
        }
        //***********************************************  FUNCTIE DE AFISARE CLASICA ************************************************************
        //{0} {1} {2} {3} - joaca rol de indecsi ai listei de parametri care sunt specificati

        public void afisare()
        {
            Console.WriteLine("Studentul {0}, are codul {1}, varsta {2} si media {3} ", Nume, cod, varsta,medie);
        }

        //***********************************************  SUPRAINCARCARE FUNCTIE TO STRING************************************************************
        //To String o sa substituie de acum inainte functia de afisare
        public override string ToString()
        {
            return "Studentul " + nume + "are codul" + cod + ", varsta " + varsta + "si media" + medie;
        }
    }
}
