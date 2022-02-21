# 💛 Programare Aplicatii Windows 
**Laborator de Programare Aplicatii Windows in limbajul C#**</br>
**Profesor coordonator: Cristian Ciurea**</br>
**An universitar: 2020-2021**</br>
**Grupa 1046 | Seria C**</br>
[**Resurse Auxiliare**](https://github.com/Adriana-Giol/Laborator-Programare-Aplicatii-Windows/blob/main/2.%20Documentatie/Resurse%20Auxiliare.md)

  
  ### [📗[Console App] Laborator 1 - Particularitatile Limbajului C#](https://github.com/Adriana-Giol/Laborator-Programare-Aplicatii-Windows/blob/main/1.%20Code/S01_Introducere/Program.cs)
✔️ **1. Afisare si citire pentru aplicatii tip consola** </br>
✔️ **2. Vectori** </br>
✔️ **3. Shallow Copy / Deep Copy** </br>
✔️ **4. Matrice bi-dimensionala** </br>

  ### [📕[Console App] Laborator 2 - Clasa.Ierarhia de Clase]()
 
   [✔️ **Clasa Student**](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/3.%20README/Clasa%20Student.md)</br>

  ### [📕[Console App + Windows Form App] Laborator 3 - Controale vizuale]()
[**1. List View**]()</br>
[**2. Tree View**]()</br>
[**3. Data Grid View**]()</br>

### 📕 4. Laborator 4 - Citire / Scriere din / in fisiere.
[**1. Fisier Text**]()</br>
[**2. Fisier Binar**]()</br>
[**3. Fisier XML**]()</br>

### 📕 5. Laborator 5 - Validari de Date.
[**1. Error Provider**]()</br>
[**2. Eveniment Item Check**]()</br>

### 📕 6. Laborator 6 - Grafic.
### 📕 7. Laborator 7 - Acceleratori si Clipboard.
### 📕 8. Laborator 8 - Print si Print Preview.
### 📕 9. Laborator 9 - Crystal Reports.

  


# [📗Laborator 2 - [Console App] - Ierarhie de clase[Zoo]](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/3.%20README/2.%20Laborator2%20-%20Ierarhie%20de%20clase%5BZoo%5D.md)

|   |      |       |       |
|---|:-----|:------|:------|
|[✔️**1. Clasa Animal**](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/3.%20README/Clasa%20de%20baza%20Animal.md)|[✔️**2. Clasa derivata Pantera**](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/3.%20README/Clasa%20derivata%20Pantera.md)| [✔️**3. Clasa derivata Sarpe**](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/3.%20README/Clasa%20derivata%20Sarpe.md)|[✔️**4. Clasa Zoo - Colectie de Animale**](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/3.%20README/Clasa%20Zoo.md)|
|🔴Definire atribute (int, string, float)|🔴Definire atribute (string, bool)| 🔴Definire atribute (int, bool)|🔴Definire atribute (string, List<*Animal*>)|
 🟠Constructor implicit / cu parametri / ~~de copiere~~| 🟠Constructor implicit / cu parametri|🟠Constructor implicit / cu parametri|🟠Constructor implicit|
 🟡Proprietati (functii accesor)|🟡Proprietati (functii accesor)|❌|🟡Proprietati (functii accesor)|
 🟢To String |🟢To String|🟢To String|🟢To String|
 🔵ICloneable / IComparable |🔵ICloneable / IComparable - mostenite din clasa Animal|🔵ICloneable / IComparable - mostenite din clasa Animal| 🔵ICloneable
 🟣Operator+|❌|❌|🟣Ooperator INDEX|

   
  # [📗Laborator 3 - [Console App + Windows Forms] - Ierarhie de clase[Student]](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/3.%20README/3.%20Laborator3%20-%20Ierarhie%20de%20clase%5BStudent%5D.md)
  
  |   |      |       |       |      |
  |---|:-----|:------|:------|:-----|
  |[✔️**1. Clasa abstracta- de baza Persoana**](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/3.%20README/Clasa%20abstracta%20-%20de%20baza%20Persoana.md)| [✔️**2. Clasa derivata Student**](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/3.%20README/Clasa%20derivata%20Student.md)|[✔️**3. Interfata IMedia**](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/3.%20README/Interfata%20IMedia.md)| [**✔️4. Formular**](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/3.%20README/S3.Formular.md)|[✔️**5. Clasa Program (Console.Writeline)**](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/1.%20Laborator/3.%20Seminar%203/%5BCom%5DCiurea_Seminar3_1046/Program.cs)|
|🔴Definire atribute (int, char)|🔴Definire atribute (int, string, int[])|❌|🔴TextBox|🔹Apelare constructor implicit / cu parametri|
 🟠Constructor implicit / cu parametri|🟠Constructor implicit / cu parametri|❌|🟠Label|🔹Apelare metoda clone()|
 ❌|🟡Proprietati (functii accesor)|❌|🟡Combo Box|🔹Apelare ToString|
 🟢To String|🟢To String|❌|🟢Buton (Netratat)|🔹Apelare operator+|
 ❌|🟣Ooperator: +, ++, cast, INDEX|❌|❌|🔹Apelare metodaAbstracta`spuneAnNastere`|
 🔵Metoda abstracta (spuneAnNastere)➡️|🔵ICloneable, IComparable, IMedia|⬅️🔵Metoda abstracta (calculeazaMedie)|❌|🔹Apelare INDEX|
  ❌|❌|❌|❌|🔹Creare Lista Studenti sortata + apelare CompareTo()|
 
  
# 📗Laborator 4 - [Windows Forms App.NET Framewrok] - Scriere /Citire in fisier Text/Binar
  Preluare din seminar3 clasele: Form1, Student, Peroana, IMedia - **Click dreapta Proiect -> Add ->Existing Items**</br>
  ⚠️**ATENTIE LA NAMESPACE SA FIE LA FEL CU CEL AL PROIECTULUI**</br>
  
  |   |      |       |       |     |    
  |---|:-----|:------|:------|:----|
  |[✔️**1. Clasa abstracta- de baza Persoana**](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/3.%20README/Clasa%20abstracta%20-%20de%20baza%20Persoana.md)| [✔️**2. Clasa derivata Student**](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/3.%20README/Clasa%20derivata%20Student.md)|[✔️**3. Interfata IMedia**](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/3.%20README/Interfata%20IMedia.md)|  [✔️**4. Formular1 - Update**](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/3.%20README/S4.Formular1.md)|[✔️**5. Formular2 - Citire /Scriere Fisier Text/Binar**](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/3.%20README/S4.Formular2.md)|
|🔴Definire atribute (int, char)|🔴Definire atribute (int, string, int[])|❌|🔴TextBox|🔴TextBox|
 🟠Constructor implicit / cu parametri|🟠Constructor implicit / cu parametri|❌|🟠Label|🟠Buton1[Tratat] 〰️Traversare lista & Afisare|
 ❌|🟡Proprietati (functii accesor)|❌|🟡Combo Box|🟡Buton2[Tratat]〰️Salvare in fisier TXT🌎SaveFileDialog|
 🟢To String|🟢To String|❌|🟢Buton1 [Tratat]〰️Try-Catch〰️Conversii|🟢Buton3[Tratat]〰️Citire din fisier TXT🌎OpenFileDialog|
 ❌|🟣Ooperator: +, ++, cast, INDEX|❌|🟣Buton2 [Tratat]〰️Traversare lista & Afisare|🟣Buton4[Tratat]〰️Salvare in fisier BINAR|
 🔵Metoda abstracta (spuneAnNastere)➡️|🔵ICloneable, IComparable, IMedia|⬅️🔵Metoda abstracta (calculeazaMedie)|❌|🔵Buton5[Tratat]〰️Citire din fisier BINAR|
  
  
# [📗Laborator 5 - [Windows Forms] - Fisier XML](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/3.%20README/5.%20%20Laborator%205%20-%20Fisier%20XML.md)
  [Fisier XML](https://bnro.ro/nbrfxrates.xml)</br>
  [✔️**1. Formular1 - Parsare Fisier XML**](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/3.%20README/5.%20Laborator5%20-%20Parsare%20Fisier%20XML.md)</br>
  [✔️**2. Formular1 - Generare Fisier XML**](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/3.%20README/5.%20Laborator5%20-%20Generare%20Fisier%20XML.md)</br>
      
# 📗Laborator 6 - [Windows Forms] - Error Provider
### [**⚡Acceleratori**](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/3.%20README/Acceleratori.md)
### [**🔄Transfer de date intre formulare**](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/3.%20README/C5.Transfer%20de%20date%20intre%20formulare.md)
|   |      |       |       |
|---|:-----|:------|:------|
[✔️**1. Formular2 - Update Seminar5 - Error Provider**](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/3.%20README/S6.Formular2.md)|[✔️**2. Clasa Credit**](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/3.%20README/S6.Clasa%20Credit.md)|[✔️**3. Formular3** ](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/3.%20README/S6.Formular3.md)|[✔️**4. Aplicatie de adaugare de TextBox-uri in maniera dinamica**](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/3.%20README/6.%20Laborator6%20-%20TextBox%20Dinamic.md)|
|🔴Meniu Contextual|🔴Definire atribute (int, int, float, float)|🔴Transmiterea Listei de Credite din Form2 in Form3|🔴Adaugare TextBox dinamic|
 🟠Error Provider|🟠Constructor cu parametri||🟠Eveniment KeyPress: Verificare cifre 0-9, backspace sau virgula|
 🟡Lista Credite|🟢To String |
  
# 📗Laborator 7 - [Windows Forms] - List View & Tree View
🔴List View - Structura Tabelara</br>
🟠Tree View - Date Expandate - Structura de Fisiere - Maniera Arborescenta</br>

|   |      |       | 
|---|:-----|:------|
|[✔️**1. Clasa Student**](https://github.com/cristianciurea/PAW2021/blob/main/Sem7_PAW/Sem7PAW_1046/Student.cs)|[✔️**1. Formular7 - List View**](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/3.%20README/7.%20Laborator7%20-%20ListView.md)|[✔️**1. Formular7 - Tree View**](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/3.%20README/7.%20Laborator7%20-%20ListView.md)|
|🔴Definire atribute (int, string, int)|🔴Adaugare coloane goale (cod+proprietate) + Populare ListView cu date|🔴Populare TreeView|
|🟠Constructor cu parametri|🟠Stergere Items|🟠Sterge Nod|
|🟡Proprietati (functii accesor)|🟡Adaugare date din TextBox in ListView|🟡Eveniment AFTER SELECT|
|🟢To String |🟢Preluare date din fisier|🟢Exporta XML|
|❌|🔵 TextBox Numeric - Eveniment Item Check|❌|

 
# 📕Laborator 8 - [Windows Forms] - Grafic 
#### Graic de tip bare pentru date citite din fisier
|   |      |       | 
|---|:-----|:------|
|[✔️**1. Form**](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/3.%20README/8.%20Form1.md)|
|🔴
|🟡
|🟢
|

# 📗Laborator 9 - [Windows Forms] - TEST : RECAPITULARE TEST
📝[**Subiect_PAW_2021 gr. 1046.pdf**](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/files/6371355/Subiect_PAW_gr.1046.pdf)📝
|   |      |      |       |       |
|---|:-----|:-----|:------|:------|   
|[✔️**Clasa Persoana**](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/RecapitulareTest/Persoana.cs)|[✔️**Clasa Colectiv**](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/RecapitulareTest/Colectiv.cs)|[✔️ **Clasa Program**](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/RecapitulareTest/Program.cs)|[**Form1**](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/RecapitulareTest/Form1.cs)|[**Form2**](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/RecapitulareTest/Form2.cs)|
|🔴Definire atribute (int id, List<String>, String, float[], bool, char, DateTime, decimal, double|🔴Definire atribute(String, List<Persoana>)|🔴[**Transfer de Lista (Traversare + afisare) din Form1 -> Form2**](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/3.%20README/S4.%20Transfer%20de%20Liste%20intre%20Formulare.md)|
|🟠Constructor implicit / cu parametri (Deep Copy: vectori - List<String>)|🟠Constructor implicit / cu parametri (Deep Copy: List<Persoana>)|
|🟡Proprietati (functii accesor)|🟡Proprietati (functii accesor)|
|🟢To String (List<String>, vector, atribute normale)|🟢To String (List<Persoana>)|
|🟣ICloneable (List<String>, vector), IComparable(String, int/float + string)|🟣ICloneable (List<Persoana>)|
|🔵Operator INDEX (List<String>, vector), +(Vector),++, CAST|🔵Operator INDEX|
  
## 💻[PROIECT](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/3.%20README/Proiect.md)
    
  *Doar o parte din operatori se pot supraincarca in C#  si toate functii de supraincarcare vor fi niste functii statice (global vazute la nivelul clasei) si din acest motiv nu o sa putem sa lucram in cadrul functiilor respective cu referinta this. De aceea tot timpul o sa am nevoie de 2 operatori: un obiect din clasa si apoi pot sa mai primesc un alt obiect sau o variabila de tip fundamentala. Comutativitatea si aici inu are sens si trebuie sa implementam ambele forme.
  Anumiti operatori nu se supraincarca:
   - Operator+= nu se supraincarca deoarece face Shallow Copy.
   - Operatorul index se supraincarca sub forma de proprietate (fara nume - THIS).

*O clasa abstracta poate sa aiba toate componentele unei clase normale: atribute, constructori, proprietati si pe langa toate acestea o sa aiba si metode abstracte care nu vor fi implementate si clasa respectiva, ci in clasele derivate din clasa respectiva. Motivul pentru care facem ca o clasa sa fie  abstracta este doar pentru a deriva din ea.In momentul in care am facut aceea clasa abstracta nu mai putem instantie nici un obiect din clasa respectiva cu new, dar toate componenta clasei vor fi folosite ca si elemente mostenite in clasele derivate.



  
