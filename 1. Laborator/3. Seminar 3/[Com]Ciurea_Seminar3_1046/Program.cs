using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Com_Ciurea_Seminar3_1046
{
    class Program
    {
        static void Main(string[] args)
        {

            //Instantiere obiecte
            Student s1 = new Student();
            Student s2 = new Student(123, 'M', 21, "Gigel", new int[3] { 8, 9, 10 });
            Student s3 = (Student)s2.Clone();

            Console.WriteLine(s1);
           

            //Prelucrare student s2 sa vedem daca se modifica si s3
            s2 = s2 + 10;
            s2 += 5;
            s2++;
            Console.WriteLine(s2);

            Console.WriteLine(s3);

            s2.spuneAnNastere();
            Console.WriteLine("A 5-a nota a lui s2: " + s2[4]);

            //Apelare seter pentru nota - Ii schimb ultima nota sa fie din 1 -> 5
            s2[5] = 5;
            Console.WriteLine(s2);

            //Sortare dupa medie a unei liste
            Console.WriteLine("-----------------");

            List<Student> listaStud = new List<Student>();
            listaStud.Add(s1);
            listaStud.Add(s2);
            listaStud.Add(s3);
            listaStud.Sort();
            foreach(Student s in listaStud)
            {
                Console.WriteLine(s);
            }

            //Pentru a face formularul vizibil trebuie sa instantiem un obiect din clasa Form1
            Form1 form = new Form1();
            form.ShowDialog();  // Putem sa interactionam cu ambele ferestre 
           // form.Show() //  Nu putem interactionam cu alte ferestre

        }
    }
}
