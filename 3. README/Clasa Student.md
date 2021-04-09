# 🎯 CLASA STUDENT </br>
### 🔮[Cod Sursa](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/1.%20Laborator/1.%20Seminar%201/%5BClean%5DCiurea_Seminar1_1046/Student.cs)🔮
### 🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠 CLASA STUDENT.CS 🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠
1️⃣**PAS 1: Click drepta pe proiect -> Add -> New Item -> Class**</br>
*Namespace-ul este acelasi pentru toate clasele - daca luam o clasa dintr-un alt proiect trebuie sa ne asiguram ca namespace-ul se potriveste cu al nostru.*</br>

2️⃣**PAS 2: DEFINIRE ATRIBUTE**</br>
*Fiecare atribut are propriul modificator de acces - default e `private`*. </br>
*Protected ramane cu aceeasi utilitate ca si in C++, adica extinde vizibilitatea atributului si in cadrul claselor derivate. In C# si Java nu exista derivare multipla.*</br>
```cpp
 class Student
    {
        private int cod;
        private string nume;
        public int varsta;
        protected float medie;
   }
```

3️⃣**PAS 3: CONSTRUCTORUL IMPLICIT**</br>
*Daca uitam sa punem public Lazy constructor inseamna ca acel constructor este privat si nu il putem folosi in afara clasei deci nu putem sa instantiem obiect. Constructorul privat este necesar doar in cazul unui Singleton.*</br>
```cpp
 public Student()
        {
            this.cod = 0;
            this.nume = "Anonim";
            this.varsta = 0;
            this.medie = 0.0f; 
```
*f vine de la float (virgula mobila simpla precizie), deoarece 0.0 este implicit un double (virgula mobila dubla precizie).*</br>
*Pointerul this este un pointer catre obiectul curent al clasei. In C# lucram cu referinte, deci this-> este inlocuit de (this.)*</br>

4️⃣**PAS 4: CONSTRUCTORUL CU PARAMETRI**</br>
```cpp
 public Student(int cod, string nume, int varsta, float medie)
        {
            this.cod = cod;
            this.nume = nume;
            this.varsta = varsta;
            this.medie = medie;
        }
```

5️⃣**PAS 5: CONSTRUCTORUL DE COPIERE**</br>
*Creaza spatiu pentru un nou obiect in HEAP si va copia in acel spatiu valorile primit ca parametru.*</br>

__DIFERENTA CONSTRUCTOR DE COPIERE - OPERATOR =__</br>
 - Operatorul = foloseste 2 obiecte deja existente si copiaza dintr-unul in altul.</br>
 - Constructorul de copiere creaza un obiect de baza unui deja existent.</br>
```cpp
 public Student(Student s)
        {
            this.cod = s.cod;
            this.nume = s.nume;
            this.varsta = s.varsta;
            this.medie = s.medie;
        }
```
6️⃣ **PAS 6: PROPRIETATI - FUNCTII ACCESORI**</br>
*Functiile accesor (get si set) in C# nu se mai implementeaza ca functii, ci se implementeaza ca proprietati. Pentru fiecare atribut PRIVAT pentru a putea accesa respectivul atribut in afara clasei este nevoie sa implementam o proprietate.*</br>

 **CONVENTII DE NUME:**</br>
     - Atribut = prima litera mica:  numeStudent</br>
     - Proprietati = nume atribut, dar cu prima litera mare: NumeStudent</br>

```cpp
public string Nume
   {
       get { return nume; }
       set
           {
             if (value != null) nume = value; //value joaca rol de parametru pe care il primeam la seter
           }
  }
```
7️⃣ **PAS 7: FUNCTIE DE AFISARE - CLASICA**</br>
*{0} {1} {2} {3} - joaca rol de indecsi ai listei de parametri care sunt specificati.*</br>

```cpp
public void afisare()
  {
     Console.WriteLine("Studentul {0}, are codul {1}, varsta {2} si media {3} ", nume, cod, varsta, medie);
  }
```
8️⃣**PAS 8: SUPRAINCARCARE FUNCTIE TO STRING**</br>
*To String o sa substituie de acum inainte functia de afisare.*</br>
```cpp

        public override string ToString()
        {
            return "Studentul " + nume + "are codul" + cod + ", varsta " + varsta + "si media" + medie;
        }
```
### 🟢🟢🟢🟢🟢🟢🟢🟢🟢 CLASA PROGRAM.CS - Functia Static Void Main🟢🟢🟢🟢🟢🟢🟢🟢🟢
9️⃣**PAS 9: Instantiere Student folosind constructorul default si constructorul cu parametri**</br>
*Daca scriu doar Student s1 inseamna ca mi-am definit o referinta goala la tipul de date student - nu are nici un spatiu  alocat in memorie.*</br>
```cpp
   Student s1 = new Student();
   Student s2 = new Student(123, "Adriana", 22, 9.5f);
```

🔟**PAS 10: Instantiere Student folosind constructorul de copiere**</br>
```cpp
 ❌//Student s3(s2);     Nu merge aceasta varianta
 ❌//Student s3 = s2;   Este Shallow Copy deoarece nu s-a alocat spatiu pentru s3  - si s3 si s2 vor referi acelasi obiect

//DEEP COPY
✔️Student s3 = new Student(s2);


```

1️⃣1️⃣**PAS 11: Apelare Proprietate NUME**</br>
```cpp
s3.Nume = "Dorel";              // Se apeleaza seter-ul
Console.WriteLine(s3.Nume);     //Se apeleaza geter-ul
```

1️⃣2️⃣**PAS 12: Apelare METODA DE AFISARE**</br>
```cpp
s1.afisare();
s2.afisare();
s3.afisare();
```

1️⃣3️⃣**PAS 13: Apelare METODA DE AFISARE**</br>
```cpp
 Student[] vs = new Student[3] { s1, s2, s3 };
 ```
 
1️⃣4️⃣**PAS 14: Traversare si afisare - clasica vector**</br>
```cpp
 for (int i = 0; i < vs.Length; i++)
      {
         vs[i].afisare();

      }
```
1️⃣5️⃣**PAS 15: Traversare si afisare - TO STRING vector**</br>
*WriteLine-ul incearca sa transforme ceea ce primeste ca parametru in sir de caractere, doar ca obiectul din clasa Student nu stie sa se transforme in sir de carctere. Ca sa pot sa il convertesc ar trebui sa fac un override la TO STRING.*</br>
            
```cpp
  for (int i = 0; i < vs.Length; i++)
            {
                Console.WriteLine(vs[i]);  // Daca vreau sa subtitui metoda de afisare cu apelul de TO STRING
            }
```
