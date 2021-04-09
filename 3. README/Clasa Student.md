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
5️⃣**PAS 5: CONSTRUCTORUL CU PARAMETRI**</br>
