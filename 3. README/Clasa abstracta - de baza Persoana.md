# ๐ฏ CLASA ABSTRACTA - DE BAZA PERSOANA </br>
### ๐ฎ[Cod Sursa](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/1.%20Laborator/3.%20Seminar%203/%5BClean%5DCiurea_Seminar3_1046/Persoana.cs)๐ฎ
### ๐ ๐ ๐ ๐ ๐ ๐ ๐ ๐ ๐ ๐ ๐ ๐  CLASA PERSOANA.CS ๐ ๐ ๐ ๐ ๐ ๐ ๐ ๐ ๐ ๐ ๐ ๐ 
1๏ธโฃ**PAS 1: Click drepta pe proiect -> Add -> New Item -> Class**</br>

2๏ธโฃ**PAS 2: DEFINIRE ATRIBUTE**</br>
*Vom face atributele PROTECTED deoarece fiind clasa abstracta vom deriva alte clase din aceasta clasa si astfel asiguram vizibilitatea acestor atribute in clasele derivate.De aceea nu mai avem nevoie nici de PROPRIETATI deoarece avand atributele protected ele vor fi vizibile in clasele derivate.*</br>
```cpp
   public abstract class Persoana
    {
        protected int cod;
        protected char sex;
    }
```

3๏ธโฃ**PAS 3: CONSTRUCTORUL IMPLICIT**</br>
```cpp
      public Persoana()
        {
            cod = 0;
            sex = 'F';
        }
```

4๏ธโฃ**PAS 4: CONSTRUCTORUL CU PARAMETRI**</br>
```cpp
     public Persoana(int c, char s)
        {
            cod = c;
            sex = s;
        }
```
โ **PROPRIETATILE NU LE IMPLEMENTAM DEOARECE AM FACUT ATRIBUTELE PROTECTED SI ASTFEL SUNT VIZIBILE IN CLASELE DERIVATE**</br>

5๏ธโฃ **PAS 5: SUPRAINCARCARE FUNCTIE TO STRING**</br>
*O sa folosim acest ToString si in clasele derivate.*</br>
```cpp
     public override string ToString()
        {
            return "Persoana cu codul " + cod + " are sexul " + sex;
        }
```

6๏ธโฃ **PAS 6: METODA ABSTRACTA**</br>
*Metoda care se va implementa in clasa derivata.*<br>
```cpp
    public abstract void spuneAnNastere();
```
### ๐ข๐ข๐ข๐ข๐ข๐ข๐ข๐ข๐ข CLASA PROGRAM.CS - Functia Static Void Main๐ข๐ข๐ข๐ข๐ข๐ข๐ข๐ข๐ข
