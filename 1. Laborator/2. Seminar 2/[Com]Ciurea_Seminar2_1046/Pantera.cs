using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Com_Ciurea_Seminar2_1046
{
    class Pantera:Animal
    {
        /*Clasa Pantera este derivata din clasa Animal si va mosteni atributele clasei Animal si mai trebuie sa aiba ceva in plus*/
        private string culoare;
        private bool esteHranita;

        /*Clasa Pantera mosteneste implementarea de Clone si de Compare din clasa Animal si asta inseamna ca pot sa compar panterele 
         dupa greutate si nume
        
        ToSting o sa imi permita sa afisez doar atributelor mostenite, astfel voi implementa si ToSting pentru clasa Pantera*/

        //***********************************************CONSTRUCTORUL IMPLICIT*****************************************************************
        /* -  apeleaza constructorul clasei Animal ca sa initializeze cele 3 atribute din clasa Animal*/
        public Pantera(): base()
        {
            this.culoare = "roz";
            this.esteHranita = true;
        }
        //******************************************************CONSTRUCTOR CU PARAMETRI*******************************************************
        //Trebuie sa includem in lista de parametri si atributele din clasa Animal
        public Pantera(int varsta, string nume, float greutate, string culoare, bool esteHranita) : base(varsta, nume, greutate)
        {
            this.culoare = culoare;
            this.esteHranita = esteHranita;
        }

       

        //****************************************************** IMPLEMENTARE TO STRING***********************************************************
        public override string ToString()
        {
           // return base.ToString();  // va apela ToString din clasa Animal doar pentru acele atribute din clasa Animal
           return base.ToString() + " culoarea " + culoare + " si este hranita " + esteHranita; // Apelam ToString din clasa Animal si concatenam cu atributele noi
                                                                                                // din clasa Pantera
        }

        /*Pentru a genera automat constructorii, proprietatile, ToString pentru o clasa:
           Dam click drepata pe clasa respectiva -> Quick Actions and Refactorings
            - Generate Constructor
            - Generate Override
            Dam click drepta pe un atribut -> Quick Actions and Refactorings 
                - Encapsulate field 'culoare' (but still use field)   -- implementare cu Lambda*/
        public string Culoare { get => culoare; set => culoare = value; }
        public bool EsteHranita { get => esteHranita; set => esteHranita = value; }
    }
}
