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

5️⃣**PAS 6: IMPLEMENTARE ICLONEABLE**</br>
💡**Implementam interfata ICloneable**</br>
```cpp
    class Zoo : ICloneable
```
⚠️**Lista de animale trebuie sa fie tratata separat deoarece metoda MemberwiseClone() nu stie sa trateze obiecte care incapsuleaza alte obiecte.**</br>
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
