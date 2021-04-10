# 🎯 CLASA ZOO </br>
### 🔮[Cod Sursa](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/1.%20Laborator/2.%20Seminar%202/%5BClean%5DCiurea_Seminar2_1046/Pantera.cs)🔮
### 🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠 CLASA ZOO.CS 🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠
1️⃣**PAS 1: Click drepta pe proiect -> Add -> New Item -> Class**</br>

2️⃣**PAS 2: DEFINIRE ATRIBUTE**</br>
*Clasa Zoo va contine o colectie de animale, adica va avea si o lista de animale.*</br>
```cpp
 class Zoo
    {
        private string denumire;
        private List<Animal> listaAnimale;

```

3️⃣**PAS 3: CONSTRUCTORUL IMPLICIT**</br>
```cpp
  public Zoo()
        {
            denumire = "Baneasa";
            listaAnimale = new List<Animal>();
        }
```
❌ **NU IMPLEMENTAM si constructorul cu parametri deoarece vom implementa proprietati care sa ne ajute sa modificam valorile atributelor.**</br>

4️⃣**PAS 4:PROPRIETATI - FUNCTII ACCESORI**</br>
*Indiferent ca am colectie sau atribut normal geterul si seterul raman la fel.*</br>
```cpp
     public string Denumire
        {
            get { return denumire; }
            set { if (value != null) denumire = value; }
        }

        public List<Animal> ListaAnimale
        {
            get { return listaAnimale; }
            set { if (value != null) listaAnimale = value; }
        }
```

5️⃣**PAS 5: SUPRAINCARCARE FUNCTIE TO STRING**</br>
⚠️*Functia ToString ar trebui sa afiseze numele parcului Zoo si lista de animale. Trebuie sa parcurgem lista de animale cu un `foreach`.*</br>
` Environment.NewLine = \n (linie noua)`

```cpp
 public override string ToString()
        {
            string rezultat = "Zoo " + denumire + " are urmatoarele animale: " + Environment.NewLine;
            foreach (Animal a in listaAnimale)
                rezultat += a.ToString() + Environment.NewLine;
            return rezultat;
        }
```

6️⃣**PAS 6: IMPLEMENTARE ICLONEABLE**</br>
💡**Implementam interfata ICloneable**</br>
```cpp
    class Zoo : ICloneable
```
⚠️**Lista de animale trebuie sa fie tratata separat deoarece metoda MemberwiseClone() nu stie sa trateze obiecte care incapsuleaza alte obiecte.**</br>
*Alocam spatiu pentru o noua lista si luam animalele din lista initiala si le pun in noua lista si apoi atasez lista, obiectului clona creat.*</br>
**Creem o lista noua in care pun copiii ale obiectelor din lista curenta.**</br>
```cpp
  public object Clone()
        {
            //return this.MemberwiseClone(); - daca lasam doar asa nu o sa stie sa copieze lista de animale
            Zoo clona = (Zoo)this.MemberwiseClone();
            List<Animal> listaNoua = new List<Animal>();
            foreach (Animal a in listaAnimale)
                listaNoua.Add((Animal)a.Clone());
            clona.listaAnimale = listaNoua;
            return clona;
        }
```
7️⃣**PAS 7: Supraincarcare Operator Index**</br>
*Se supraincarca sub forma unei proprietati si implementam aici operatorul index pentru ca in clasa ZOO avem o colectie, dar daca nu aveam o colectie nu puteam sa il implementam deoarece nu aveam ce sa iterez.*</br>
🔴**Tipul returnat o sa fie Animal - deoarece eu returnez din lista de animale, animalul de pe o anumita pozitie.**</br>
🟠**Numele functiei va fi `this` pentru ca nu are nume**</br>
🟡**Ca parametri va primi un [int index] => nu e obligatoriu sa fie de tip Int, ci poate sa fie si de tip String si atunci pot sa reper z[2]Grivei (inseamna ca din lista de animale eu vreau sa il extrag pe Grivei.**</br>
```cpp
   public Animal this[int index]
        {
            get
            {
                if (index >= 0 && index < listaAnimale.Count && listaAnimale != null)
                    return listaAnimale[index];
                else
                    return null;
            }
        }
```

### 🟢🟢🟢🟢🟢🟢🟢🟢🟢 CLASA PROGRAM.CS - Functia Static Void Main🟢🟢🟢🟢🟢🟢🟢🟢🟢
8️⃣**PAS 8: Instantiere ZOO folosind constructorul implicit**</br>
```cpp
   Zoo z1 = new Zoo();
```
9️⃣**PAS 9: Adaugam toate animalele in lista de animale**</br>
```cpp
 z1.ListaAnimale.Add(a1);
 z1.ListaAnimale.Add(a2);
 z1.ListaAnimale.Add(a3);
 z1.ListaAnimale.Add(p1);
 z1.ListaAnimale.Add(s1);
```
🔟**PAS 10: Cream o alta gradina Zoo pe baza primei gradini Zoologice**</br>
```cpp
   Zoo z2 = (Zoo)z1.Clone();
```
1️⃣1️⃣**PAS 11: Schimbam denumirea lui Z2**</br>
```cpp
 z2.Denumire = "Berlin";
 ```
1️⃣2️⃣**PAS 12: Daca vreau sa schimb colectia de animale din z2**</br>
```cpp
  foreach (Animal a in z2.ListaAnimale)
       a.Nume += " copie";
```

1️⃣3️⃣**PAS 13: Testare sortare (CompareTo) si Afisare (ToString)**</br>
*In cazul sortarii se apeleaza CompareTo din clasa Animal. Daca nu includem IComparable in clasa de baza ne da eroare.*</br>
```cpp
 z1.ListaAnimale.Sort();
 z2.ListaAnimale.Sort();
 
Console.WriteLine(z1);
Console.WriteLine(z2);
```
1️⃣4️⃣**PAS 14: Apelare Operator INDEX**</br>
```cpp
 Console.WriteLine(z2[3]);
```

