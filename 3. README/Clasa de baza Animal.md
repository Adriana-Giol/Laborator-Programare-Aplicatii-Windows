# 🎯 CLASA ANIMAL </br>
### 🔮[Cod Sursa](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/1.%20Laborator/2.%20Seminar%202/%5BClean%5DCiurea_Seminar2_1046/Animal.cs)🔮
### 🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠 CLASA ANIMAL.CS 🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠
1️⃣**PAS 1: Click drepta pe proiect -> Add -> New Item -> Class**</br>

2️⃣**PAS 2: DEFINIRE ATRIBUTE**</br>
*Vom face atributele private ca sa putem implementa si proprietatile.*</br>
```cpp
 class Animal
    {
       private int varsta;
       private string nume;
       private float greutate;
   }
```

3️⃣**PAS 3: CONSTRUCTORUL IMPLICIT**</br>
*Initializam atributele cu valori elementare.*</br>
```cpp
  public Animal()
        {
            varsta = 0;
            nume = "Anonim";
            greutate = 0.0f;
        }

```

4️⃣**PAS 4: CONSTRUCTORUL CU PARAMETRI**</br>
```cpp
  public Animal(int v, string n, float g)
        {
            varsta = v;
            nume = n;
            greutate = g;
        }

```
❌ **CONSTRUCTORUL DE COPIERE NU IL IMPLEMENTAM DEOARECE O SA IMPLEMENTAM METODA CLONE.**</br>
5️⃣ **PAS 5: PROPRIETATI - FUNCTII ACCESORI**</br>
*Seteri trebuie sa includa validari*</br>
*Value este cuvant cheie si este echivalentul acelei parametru pe care il primeste functia seter.*</br>
```cpp
        public int Varsta
        {
            get { return varsta; }
            set { if (value > 0) varsta = value; }
        }

        public string Nume
        {
            get { return nume; }
            set { if (value != null) nume = value; }
        }

        public float Greutate
        {
            get { return greutate; }
            set { if (value > 0) greutate = value; }
        }
```
6️⃣**PAS 6: SUPRAINCARCARE FUNCTIE TO STRING**</br>
*Toate clasele mostenesc din clasa de baza "Object" metoda ToString care permite o supradefinire pentru a putea transforma fiecare obiect in sir de caratere.*</br>
*Base se refera la clasa "Object" - clasa de baza/parinte - in cazul de fata base nu ne ajuta la nimic deoarece nu avem clasa Animal derivata din nimic.*</br>
```cpp
  public override string ToString()
        {
            return "Animalul " + nume + " are varsta " + varsta + " si greutatea " + greutate;
        }
```

7️⃣ **PAS 7: ICLONEABLE**</br>
*ICloneable inlocuieste constructorul de copiere.*</br>
💡 **Ne ajutam de beculetul galben: Implement interface**</br>
```cpp
 class Animal : ICloneable
```
**MemberwiseClone() - face o clona intre shallow si deep, de aceea nu stie sa faca o clona completa pentru cazul in care as avea vector sau colectii.**</br>
```cpp
  public object Clone()
        {
            return this.MemberwiseClone();
        }
```

8️⃣ **PAS 8: ICOMPARABLE**</br>
*IComparable inlocuieste operatorii de comparatie - defineste o metoda de comparare generalizata pentru obiectele din clasa.*</br>
```cpp
  class Animal : ICloneable, IComparable
```
💡 **Ne ajutam de beculetul galben: Implement interface**</br>
*In cadrul metodei compareTo spunem cum vom realiza relatia de ordine intre obiectele de tip Animal (dupa ce criteriu).*</br>
**Le comparam mai intai dupa greutate si daca sunt egale le comparam apoi dupa nume.**
Scopul implementarii compareTo este de a permite sortarea de obiecte pentru a putea pune Animalele respective intr-o lista sau vector, avandu-le sortate.</br>
⚠️**Intotdeauna metoda compareTo o sa returneze 3 valori:**</br>
- -1 (obiectul curent va fi mai mic decat cel primit ca parametru adica obj), 
-  0 (cand sunt egale), 
-  1 (obiectul curent este mai mare).

❗**Avand in vedere ca vreau sa compar obiectul curent dat de referinta this cu obiectul obj dat de parametru trebuie sa ma asigur ca ele sunt de acelasi tip (printr-un CAST catre Animal).**</br>
```cpp
    public int CompareTo(object obj)
        {
            Animal a = (Animal)obj;
             if (this.greutate < a.greutate)
                 return -1;
             else
                 if (this.greutate > a.greutate)
                 return 1;
             else
                 return 0; // daca fac compararea dupa un singur criteriu
                 return string.Compare(this.nume, a.nume); // daca vreau sa fac compararea dupa 2 criterii
       }
```
 **Metoda `Compare` implementeaza `strcmp` (de la C) intre 2 siruri de caractere si la fel ca si CompareTo va returna si ea -1, 0 , 1.**</br>
 
**Sau se mai poate implementa asa:**
```cpp
 public int CompareTo(object obj)
        {
            Animal a = (Animal)obj;
            if (this.greutate.CompareTo(a.greutate) == 0)
                return string.Compare(this.nume, a.nume);
            else
                return this.greutate.CompareTo(a.greutate);
        }
```
### 🟢🟢🟢🟢🟢🟢🟢🟢🟢 CLASA PROGRAM.CS - Functia Static Void Main🟢🟢🟢🟢🟢🟢🟢🟢🟢
9️⃣**PAS 9: Instantiere Animal folosind constructorul default si constructorul cu parametri**</br>
```cpp
 Animal a1 = new Animal();
 Animal a2 = new Animal(10, "Zoro", 150);
```

🔟**PAS 10: Instantiere Animal folosind constructorul de copiere**</br>
```cpp
  Animal a3 = (Animal)a2.Clone();
```

1️⃣1️⃣**PAS 11: Apelare Proprietate NUME si GREUTATE**</br>
```cpp
 a3.Nume = "Grivei";
 a3.Greutate = 150;
```

1️⃣2️⃣**PAS 12: Apelare TO STRING pentru toate obiectele**</br>
```cpp
   Console.WriteLine(a1);
   Console.WriteLine(a2);
   Console.WriteLine(a3);
```
