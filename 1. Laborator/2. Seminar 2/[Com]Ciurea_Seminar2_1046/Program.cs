using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Com_Ciurea_Seminar2_1046
{
    class Program
    {
        static void Main(string[] args)
        {
        }

       /* Se supraincarca doar cativa operatori si de regula functii de supraincarcare vor fi statice (functii globale vazute la nivelul clasei) 
        si din aceasta cauza nu o sa putem lucra in interiorul claselor cu referinta this. Astfel vom avea nevoie intotdeauna de 2 parametri: 
                - un obiect din clasa mea
                - un al doilea parametri de tip int sau float
        Comutativitatea nu mai are sens si trebuie sa implementam ambele forme
       
        Operatori care NU se supraincarca:
                -   Operator+=
                -   Operator= , deoarece face Shallow Copy (face copie de referinta)
                -   Operator index - se supraincarca sub forma unei proprietati care nu are nume si o sa porte numele this 
       
        O clasa abstracta poate sa includa: 
                -  toate componentele pe care o clasa normala
                -  o sa contina functii abstracte (virtuale) care se vor implementa in clasele derivate
       Noi realizaam o clasa abstracta doar ca sa derivam din ea deoarece odata ce am declarat o clasa abstracta nu mai putem instantia nici un 
       obiect cu new din clasa respectiva.*/
    }
}
