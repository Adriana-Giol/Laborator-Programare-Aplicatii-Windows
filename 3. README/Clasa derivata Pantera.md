# 🎯 CLASA DERIVATA PANTERA </br>
### 🔮[Cod Sursa](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/1.%20Laborator/2.%20Seminar%202/%5BClean%5DCiurea_Seminar2_1046/Pantera.cs)🔮
### 🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠 CLASA PANTERA.CS 🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠
1️⃣**PAS 1: Click drepta pe proiect -> Add -> New Item -> Class**</br>

2️⃣**PAS 2: DEFINIRE ATRIBUTE**</br>
*Clasa Pantera fiind derivata din clasa Animal va mosteni atributele clasei Animal (varsta, nume, greutate) si trebuie sa mai aiba atribute in plus.*</br>
```cpp
 class Pantera : Animal
    {
        private string culoare;
        private bool esteHranita;
    }
```
⚠️⚠️ **GENERARE CONSTRUCTORI / PROPRIETATI: Click drepta pe CLASA /atributele din clasa -> Quick Actions and Refactorings -> Generate Constructor/ Generate Overrides /Encapsulate field:...(but still use field) - Generare cu Lambda** ⚠️⚠️</br>

3️⃣**PAS 3: CONSTRUCTORUL IMPLICIT**</br>
*Constructorul implicit din clasa Pantera trebuie sa apele constructorul implicit din clasa Animal ca sa initializeze cele 3 atribute mostenite din clasa Animal.*</br>
```cpp
   public Pantera() : base()
        {
            culoare = "roz";
            esteHranita = true;
        }
```

4️⃣**PAS 4: CONSTRUCTORUL CU PARAMETRI**</br>
*Ca sa putem apela constructorul cu parametri din clasa Animal trebuie sa avem in lista de parametri ai constructorului implicit din clasa Pantera si atributele din clasa Animal.*</br>
**INTOTDEAUNA constructorul cu parametri din clasa derivata va avea parametri si pentru atributele mostenite din clasa de baza.**<br>
```cpp
 public Pantera(int v, string n, float g, string c, bool este) : base(v, n, g)
        {
            culoare = c;
            esteHranita = este;
        }
```
⚠️ **Clasa Pantera va mosteni implementarile ICloneable si IComparable de la clasa Animal si asta inseamna ca pot compara si panterele dupa greutate si apoi dupa nume.**</br>

5️⃣ **PAS 5: PROPRIETATI - FUNCTII ACCESORI**</br>
*Seteri trebuie sa includa validari*</br>
*Value este cuvant cheie si este echivalentul acelei parametru pe care il primeste functia seter.*</br>
```cpp
        public string Culoare { get => culoare; set => culoare = value; }
        public bool EsteHranita { get => esteHranita; set => esteHranita = value; }
```


6️⃣**PAS 6: SUPRAINCARCARE FUNCTIE TO STRING**</br>
⚠️*Daca nu supraincarcam functia to String in clasa mostenita, putem sa afisam doar atributele mostenite din clasa Animal, fara sa putem afisa si atributele clasei Pantera.*</br>
*Pastram base.ToString() care va apela ToString din clasa Animal.*</br>
```cpp
  public override string ToString()
        {
            return base.ToString() + " culoarea " + culoare + " si este hranita " + esteHranita;
        }
```
### 🟢🟢🟢🟢🟢🟢🟢🟢🟢 CLASA PROGRAM.CS - Functia Static Void Main🟢🟢🟢🟢🟢🟢🟢🟢🟢
7️⃣**PAS 7: Instantiere Pantera folosind constructorul cu parametri**</br>
```cpp
 Pantera p1 = new Pantera(15, "Pantera Roz", 50, "roz", true);
```

