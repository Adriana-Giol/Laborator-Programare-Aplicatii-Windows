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
  *CompareTo se foloseste pentru a stabili relatii de ordine intre obiectele clasei. Verificam daca obiectul curent al clasei (referinta this) este >, <, = decat un obiect obj primit ca parametru.Obj este tipul generic. Daca au aceeasi medie, ii sortez alfabetic, altfel sunt sortati descrescator dupa medie.* </br>
  
  ```cpp
    //Implementare metoda COMPARE TO
           public int CompareTo(object obj)
        {
            Student s = (Student)obj;  //facem CAST
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
      return (float)this;  //Apelre CAST la FLOAT
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
5️⃣ **PAS 5: PROPRIETATI:**</br>
```cpp
        public int Varsta
        {
            get { return varsta; }
            set { if (value>0) varsta = value; }
        }
```

6️⃣ **PAS 6: SUPRAINCARCARE FUNCTIE TO STRING**</br>
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

 7️⃣**PAS 7: OPERATOR+**</br>
*Operatorul+ va adauga o nota in vector. Alocam spatiu pentru un nou vector(cu lungimea egala cu vectorul vechi +1). Pe ultima pozitie din noul vector punem nota noua. Si modificam referinta sa nu mai pointeze catre vechiul vector ci catre noul vector.*<br>
```cpp
   public static Student operator+ (Student s, int notaNoua)
        {
            int[] noteNoi = new int[s.note.Length + 1];
            for (int i = 0; i < s.note.Length; i++)
                noteNoi[i] = s.note[i];
            noteNoi[noteNoi.Length - 1] = notaNoua;
            s.note = noteNoi;
            return s;
        }
```
**Varianta comutativa pentru operator+ va apela supraincarcarea de mai sus:**</br>
```cpp
 public static Student operator+ (int notaNoua, Student s) {
    return s + notaNoua; 
    }
```

8️⃣**PAS 8: OPERATOR++**</br>
*Si acest operator++ apeleaza operatorul+ de mai sus si o sa ii adauge Studentului nota 1.*<br>
```cpp
           public static Student operator++(Student s)
        {
            return s + 1;
        }
```


9️⃣**PAS 9: OPERATOR CAST**</br>
*Facem CAST LA FLOAT ca sa facem o medie din vectorul de note.*</br>
**OPERATORUL CAST SE RECOMANDA SA SE IMPLEMENTEZE EXPLICIT. ❗⚠️ Daca se implementeaza varianta implicita peste tot unde va intalni numaele obiectului (s1, s2) il va transforma intr-o medie (va face cast la float) si in loc sa imi arate datele despre student, o sa imi afiseze doar notele studentului.**⚠️❗</br>
📕 SINTAXA OPERATOR CAST: 📕 
      1. `public static explicit`.
      2. Nu are tip returnat pentru ca tipul returnat este numele functiei.
      3. `operator` tipul de date catre care fac cast.
```cpp
  public static explicit operator float(Student s)
        {
            if (s.note != null)
            {
                int suma = 0;
                for (int i = 0; i < s.note.Length; i++)
                    suma += s.note[i];
                return (float)suma / s.note.Length;
            }
            else
                return 0;
        } 
```

🔟**PAS 10: OPERATOR INDEX**</br>
**Operatorul index nu are nume si este singurul operatorul care se implementeaza ca o `proprietate`**<br>
```cpp
       public int this[int index]
        {
            get
            {
                if (note != null && index >= 0 && index < note.Length)
                    return note[index];
                else
                    return 0;
            }
            set
            {
                if (note !=null && value > 0 && value <= 10 && index >= 0 && index < note.Length)
                    note[index] = value;
            }
        }
```
### 🟢🟢🟢🟢🟢🟢🟢🟢🟢 CLASA PROGRAM.CS - Functia Static Void Main🟢🟢🟢🟢🟢🟢🟢🟢🟢
1️⃣1️⃣**PAS 11: Instantiere STUDENT folosind constructorul implicit si constructorul cu parametri**</br>
```cpp
 Student s1 = new Student();
 Student s2 = new Student(123, 'M', 21, "Gigel", new int[3] { 8, 9, 10 });
```

1️⃣2️⃣**PAS 12: Instantiere Student folosind metoda clone.**</br>
```cpp
   Student s3 = (Student)s2.Clone();
```

1️⃣3️⃣**PAS 13: Apelare TO STRING pentru toate obiectele**</br>
```cpp
       Console.WriteLine(s1);
       Console.WriteLine(s2);
       Console.WriteLine(s3);
```

1️⃣4️⃣**PAS 14: Apelare supraincarcare OPERATOR+**</br>
```cpp
 s2 = s2 + 10; //Mai adaugam nota 10 in vectorul de note
 s2 += 5;      //Adaugam nota 5 in vector
 s2++;         //Adaugam nota 1 in vector
 
Console.WriteLine(s2);
Console.WriteLine(s3);
```

1️⃣5️⃣**PAS 15: Apelare metoda abstracta `spuneVarsta`**</br>
```cpp
s3.spuneAnNastere();
```

1️⃣6️⃣**PAS 16: Apelare PROPRIETATE INDEX **</br>
🔴 GETER </br>
```cpp
Console.WriteLine("A 5-a nota a lui s2: " + s2[4]);
```
🔴SETER </br>
```cpp
   s2[5] = 5;
   Console.WriteLine(s2);
```

1️⃣7️⃣**PAS 17: Lista de Studenti - Sortare (apelare implicit CompareTo)**</br
*Ne creem o lsita de studenti in care adaugam toti studentii creati, apoi sortam lista de studenti descresctor.*</br>
```cpp
List<Student> listaStud = new List<Student>();
listaStud.Add(s1);
listaStud.Add(s2);
listaStud.Add(s3);
listaStud.Sort();
  foreach (Student s in listaStud)
           Console.WriteLine(s);
```
