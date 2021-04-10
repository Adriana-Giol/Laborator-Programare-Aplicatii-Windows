# 🎯 CLASA DERIVATA SARPE </br>
### 🔮[Cod Sursa](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/1.%20Laborator/2.%20Seminar%202/%5BClean%5DCiurea_Seminar2_1046/Sarpe.cs)🔮
### 🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠 CLASA SARPE.CS 🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠
1️⃣**PAS 1: Click drepta pe proiect -> Add -> New Item -> Class**</br>

2️⃣**PAS 2: DEFINIRE ATRIBUTE**</br>
*Clasa Sarpe fiind derivata din clasa Animal va mosteni atributele clasei Animal (varsta, nume, greutate) si trebuie sa mai aiba atribute in plus.*</br>
```cpp
 class Sarpe : Animal
    {
        private int lungime;
        private bool esteVeninos;
    }
```

3️⃣**PAS 3: CONSTRUCTORUL IMPLICIT**</br>
*Constructorul implicit din clasa Sarpe trebuie sa apele constructorul implicit din clasa Animal ca sa initializeze cele 3 atribute mostenite din clasa Animal.*</br>
```cpp
     public Sarpe() : base()
        {
            lungime = 0;
            esteVeninos = false;
        }
```

4️⃣**PAS 4: CONSTRUCTORUL CU PARAMETRI**</br>
*Ca sa putem apela constructorul cu parametri din clasa Animal trebuie sa avem in lista de parametri ai constructorului implicit din clasa Sarpe si atributele din clasa Animal.*</br>
**INTOTDEAUNA constructorul cu parametri din clasa derivata va avea parametri si pentru atributele mostenite din clasa de baza.**<br>
```cpp
  public Sarpe(int v, string n, float g, int l, bool este) : base(v, n, g)
        {
            lungime = l;
            esteVeninos = este;
        }
```
⚠️ Clasa Sarpe va mosteni implementarile ICloneable si IComparable de la clasa Animal si asta inseamna ca pot compara si sarpii dupa greutate si apoi dupa nume.

5️⃣ **PAS 5: SUPRAINCARCARE FUNCTIE TO STRING**</br>
⚠️*Daca nu supraincarcam functia to String in clasa mostenita, putem sa afisam doar atributele mostenite din clasa Animal, fara sa putem afisa si atributele clasei Sarpe.*</br>
*Pastram base.ToString() care va apela ToString din clasa Animal*</br>
```cpp
      public override string ToString()
        {
            return base.ToString() + " lungimea " + lungime + " si este veninos " + esteVeninos;
        }
```
### 🟢🟢🟢🟢🟢🟢🟢🟢🟢 CLASA PROGRAM.CS - Functia Static Void Main🟢🟢🟢🟢🟢🟢🟢🟢🟢
6️⃣**PAS 6: Instantiere Sarpe folosind constructorul cu parametri**</br>
```cpp
   Sarpe s1 = new Sarpe(20, "Python", 40, 5, false);
```
