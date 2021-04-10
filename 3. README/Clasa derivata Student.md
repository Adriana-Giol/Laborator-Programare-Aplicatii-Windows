# 🎯 CLASA DERIVATA STUDENT </br>
### 🔮[Cod Sursa](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/1.%20Laborator/3.%20Seminar%203/%5BClean%5DCiurea_Seminar3_1046/Student.cs)🔮
### 🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠 CLASA STUDENT.CS 🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠
1️⃣**PAS 1: Click drepta pe proiect -> Add -> New Item -> Class**</br>

2️⃣**PAS 2: DEFINIRE ATRIBUTE**</br>
<details open>
  <p>
  <summary>🔴Clasa Student este derivata din clasa Persoana, deci apasam pe 💡si implementam metoda abstracta spuneAnNastere() din clasa de baza Persoana.</br></summary>
  
  ```cpp
   class Student : Persoana, ICloneable, IComparable, IMedia
    {
        private int varsta;
        private string nume;
        private int[] note;
        
         //Implementare metoda abstracta
          public override void spuneAnNastere()
        {
            Console.WriteLine("Anul nasterii este: {0}", System.DateTime.Now.Year - varsta);
        }
  ```
  
  </p>
  </details>
  
  <details open>
  <p>
  <summary>🟠Clasa Student implementeaza ICloneable 💡 Implement Interface </br></summary>
  ⚠️**Daca clasa include printre atribute vector sau colectii atunci trebuie sa facem DEEP COPY TOTAL - creeam o noua clona caruia ii alocam spatiu conform vectorului original, transfer referinta vectorului original -> vectorul clona si returnez clona. Astfel cele 2 obiecte nu mai partajeaza acelesi vector.**</br>
  
  ```cpp
   //Implementare metoda CLONE
        public object Clone()
        {
            Student clona =(Student) this.MemberwiseClone();
            int[] noteNoi = (int[])note.Clone();
            clona.note = noteNoi;
            return clona;
        }
  ```
  
  </p>
  </details>
  
   <details open>
  <p>
  <summary>🟡Clasa Student implementeaza IComparable 💡 Implement Interface </br></summary>
  
  ```cpp
    //Implementare metoda COMPARE TO
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
  ```
  
  </p>
  </details>


<details open>
<p>
<summary>🟢Clasa Student implementeaza IMedia 💡 Implement Interface </br></summary>

```cpp     
// Implementare metoda CalculeazaMedia
public float calculeazaMedie()
   {
      return (float)this;
   }
```

</p>
</details>

3️⃣**PAS 3: CONSTRUCTORUL IMPLICIT**</br>
*Constructorul default apeleaza constructorul din clasa de baza Persoana. Daca apeleaza constructorul implicit din clasa de baza inseamna ca initializeaza codul cu 0 si sexul cu F, pentru ca un Student va avea, pe langa varsta, nume si vectorul de note (din clasa derivata) si cod si sex (din clasa de baza) pentru ca le mosteneste din clasa de baza Persoana.*</br>
```cpp
  public Student():base()
        {
            varsta = 0;
            nume = "Anonim";
            note = null;
        }
```

4️⃣**PAS 4: CONSTRUCTORUL CU PARAMETRI**</br>
*Pentru vectorul de note vrem sa facem un DEEP COPY - de aceea trebuie sa alocam spatiu pentru el
```cpp
      public Student(int c, char s, int v, string n, int[] nt): base(c, s)
        {
            varsta = v;
            nume = n;
             note = (int[])nt.Clone();
             
            //Varianta 2 de DEEP COPY:
            /*note = new int[nt.Length];
            for (int i = 0; i < nt.Length; i++)
                note[i] = nt[i];*/
           
        }
```
❌ **PROPRIETATILE NU LE IMPLEMENTAM DEOARECE AM FACUT ATRIBUTELE PROTECTED SI ASTFEL SUNT VIZIBILE IN CLASELE DERIVATE**</br>

5️⃣ **PAS 5: SUPRAINCARCARE FUNCTIE TO STRING**</br>
*ToString-ul din clasa Student va trebui sa apeleze si base.toString din clasa Persoana ca sa ne afiseze si codul si sexul.*</br>
*Pentru vectorul de note lu-am un string pe care il concatenam.*<br>
⚠️**La vectorul de note daca vreau sa afisez datele unui Student pe baza constructorului default o sa crape programul deoarece vectorul de note este NULL si nu are alocata zona de memorie. Atunci trebuie sa testez daca vectorul de note este neNULL si daca este neNULL trebuie sa parcurg vectorul si sa le afisez, pe else (daca e NULL) inseamna ca nu avem note in acel vector de note.**</br>
```cpp
     public override string ToString()
        {
            string rezultat = base.ToString() +" varsta "+ varsta +" numele "+ nume;
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

```

6️⃣ **PAS 6: METODA ABSTRACTA**</br>
*Metoda care se va implementa in clasa derivata.*<br>
```cpp
    public abstract void spuneAnNastere();
```
### 🟢🟢🟢🟢🟢🟢🟢🟢🟢 CLASA PROGRAM.CS - Functia Static Void Main🟢🟢🟢🟢🟢🟢🟢🟢🟢

