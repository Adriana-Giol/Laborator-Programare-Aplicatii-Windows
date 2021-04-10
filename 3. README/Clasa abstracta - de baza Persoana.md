# 🎯 CLASA ASBTRACTADE BAZA PERSOANA </br>
### 🔮[Cod Sursa](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/1.%20Laborator/2.%20Seminar%202/%5BClean%5DCiurea_Seminar2_1046/Animal.cs)🔮
### 🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠 CLASA PERSOANA.CS 🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠
1️⃣**PAS 1: Click drepta pe proiect -> Add -> New Item -> Class**</br>

2️⃣**PAS 2: DEFINIRE ATRIBUTE**</br>
*Vom face atributele PROTECTED deoarece fiind clasa abstracta vom deriva alte clase din aceasta clasa si astfel asiguram vizibilitatea acestor atribute in clasele derivate.De aceea nu mai avem nevoie nici de PROPRIETATI deoarece avand atributele protected ele vor fi vizibile in clasele derivate.*</br>
```cpp
   abstract class Persoana
    {
        protected int cod;
        protected char sex;
    }
```

3️⃣**PAS 3: CONSTRUCTORUL IMPLICIT**</br>
```cpp
      public Persoana()
        {
            cod = 0;
            sex = 'F';
        }
```

4️⃣**PAS 4: CONSTRUCTORUL CU PARAMETRI**</br>
```cpp
     public Persoana(int c, char s)
        {
            cod = c;
            sex = s;
        }
```
❌ **PROPRIETATILE NU LE IMPLEMENTAM DEOARECE AM FACUT ATRIBUTELE PROTECTED SI ASTFEL SUNT VIZIBILE IN CLASELE DERIVATE**</br>

5️⃣ **PAS 5: SUPRAINCARCARE FUNCTIE TO STRING**</br>
*O sa folosim acest ToString si in clasele derivate.*</br>
```cpp
     public override string ToString()
        {
            return "Persoana cu codul " + cod + " are sexul " + sex;
        }
```

6️⃣ **PAS 6: METODA ABSTRACTA**</br>
*Metoda care se va implementa in clasa derivata.*<br>
```cpp
    public abstract void spuneAnNastere();
```
### 🟢🟢🟢🟢🟢🟢🟢🟢🟢 CLASA PROGRAM.CS - Functia Static Void Main🟢🟢🟢🟢🟢🟢🟢🟢🟢
