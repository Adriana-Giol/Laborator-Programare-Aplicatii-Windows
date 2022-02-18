using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S01_Introducere
{
    class Program
    {
        static void Main(string[] args)
        {
            //********************* CITIRE SI SCRIERE LA CONSOLA *******************************
            Console.WriteLine("Va rog sa va introduceti numele si prenumele!");

            // Citirea de la tastatura in limbajul C# (CIN)
            string nume = Console.ReadLine();
            string prenume = Console.ReadLine();

            //Scrierea / Afisare in consola in limbajul C# (COUT)
            Console.WriteLine("Buna! Ma numesc Giol Adriana");
            Console.WriteLine("Buna! Ma numesc {0} {1}", nume, prenume);


            //****************************** VECTORI *****************************************
            //Declarare vector - Modalitatea 1 de declarare
            int[] vector1 = { 1, 2, 3, 4 };

            //Traversare cu afisare
            Console.WriteLine("Vector 1: ");
            for (int i = 0; i < vector1.Length; i++)
            {
                Console.WriteLine(vector1[i]);
            }

            //Declarare Vector 2 - - Modalitatea 2 de declarare
            int[] vector2 = new int[4] { 5, 6, 7, 8 };

            Console.WriteLine("Vector 2: ");
            for (int i = 0; i < vector2.Length; i++)
            {
                Console.WriteLine(vector2[i]);
            }


            //**************************** SHALLOW COPY *****************************

            //Declarare vector3 si initializarea lui cu valoarea vectorului vector2
            int[] vector3 = vector2;


            // Modicare vector2
            vector2[1] = 10;

            //Afisarea vectorului vector3 - observam ca e modificat cu aceeasi valoare cu care am modficiat vectorul vector2
            Console.WriteLine("Vector 3: ");
            for (int i = 0; i < vector3.Length; i++)
            {
                Console.WriteLine(vector3[i]);
            }


            //*************** DEEP COPY - VARIANTA CLASICA****************************
            //Declararea vectorului vector4 si alocarea unui nou spatiu de memorie de aceeasi dimensiune ca a vectorului vector2
            int[] vector4 = new int[vector2.Length];

            //Copiere element cu element din vectorul Vector2 in vectorul Vector4.
            Console.WriteLine("Vector 4: ");
            for (int i = 0; i < vector2.Length; i++)
            {
                vector4[i] = vector2[i];
            }


            //VERIFICARE - Daca modific valoarea lui V2 ca sa ia valoarea 500, V4 o sa ramana cu valoarea initiala adica 10
            Console.WriteLine("Numarul de pe pozitia 1 din Vectorul 2 inainte de modificare este: ");
            Console.WriteLine(vector2[1]);


            Console.WriteLine("Numarul de pe pozitia 1 din Vectorul 4 inainte de modificare este: ");
            Console.WriteLine(vector4[1]);


            Console.WriteLine("Numarul de pe pozitia 1 din Vectorul 2 dupa modificare este: ");
            vector2[1] = 500;
            Console.WriteLine(vector2[1]);

            Console.WriteLine("Numarul de pe pozitia 1 din Vectorul 4 dupa modificare este: ");
            Console.WriteLine(vector4[1]);


            //****************************** DEEP COPY - METODA CLONE ***********************************
            //Declarare vector Vector5, alocare spatiu si copiere elementelor din vector2 si in vector5
            int[] vector5 = (int[])vector2.Clone();

            //****************************** MASIVE CU N LINII SI M COLOANE ***********************************
            //Declarare matrice
            int[,] matrice1 = new int[2, 3] { { 10, 20, 30 },{ 40, 50, 60 } };

            //Traversare matrice cu afisare
            for (int i = 0; i < matrice1.GetLength(0); i++)
            {
                for (int j = 0; j < matrice1.GetLength(1); j++)
                {
                    Console.Write("{0} ", matrice1[i, j]);
                }
                Console.WriteLine();
            }

            //****************************** MASIVE IN SCARA (ZIG-ZAG) ***********************************
            //Declarare masiv in scara si alocare spatiu        
            int[][] matrice2 = new int[2][];
            matrice2[0] = new int[2] { 10, 20 };
            matrice2[1] = new int[3] { 30, 40, 50 };

            //Traversare si afisare matrice in scara
            for (int i = 0; i < matrice2.Length; i++)
            {
                for (int j = 0; j < matrice2[i].Length; j++)
                {
                    Console.Write("{0} ", matrice2[i][j]);
                }
                Console.WriteLine();
            }

        }

    }
}
