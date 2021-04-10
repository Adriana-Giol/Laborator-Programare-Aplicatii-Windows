# Programare Aplicatii Windows 
## I. Laborator 1:
 ✔️[1. Particularitatile limbajului C#](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/3.%20README/Particularitatile%20limbajului%20C%23.md)</br>
 
   - Afisare si citire pentru aplicatii tip consola 
   - Vector
   - Shallow Copy / Deep Copy 
   - Matrice bi-dimensionala  
   
 ✔️[2. Clasa Student](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/3.%20README/Clasa%20Student.md)</br>
   - Definire atribute
   - Constructor implicit / cu parametri / de copiere
   - Proprietati (functii accesor) 
   - Functie de afisare clasica / To String
 
 ## II. Laborator 2 - Ierarhie de clase:
  ✔️[1. Clasa Animal](https://github.com/Adriana-Giol/Programare-Aplicatii-Windows/blob/main/3.%20README/Clasa%20Animal.md)
   - Definire atribute
   - Constructor implicit / cu parametri / ~~de copiere~~
   - Proprietati (functii accesor) 
   - To String
   - ICloneable / IComparable
  
  ✔️[2. Clasa Zoo]()
  ✔️[3. Clasa derivata Pantera]()
  ✔️[4. Clasa derivata Sarpe]()
 
    
  *Doar o parte din operatori se pot supraincarca in C#  si toate functii de supraincarcare vor fi niste functii statice (global vazute la nivelul clasei) si din acest motiv nu o sa putem sa lucram in cadrul functiilor respective cu referinta this. De aceea tot timpul o sa am nevoie de 2 operatori: un obiect din clasa si apoi pot sa mai primesc un alt obiect sau o variabila de tip fundamentala. Comutativitatea si aici inu are sens si trebuie sa implementam ambele forme.
  Anumiti operatori nu se supraincarca:
   - Operator+= nu se supraincarca deoarece face Shallow Copy.
   - Operatorul index se supraincarca sub forma de proprietate (fara nume - THIS).

*O clasa abstracta poate sa aiba toate componentele unei clase normale: atribute, constructori, proprietati si pe langa toate acestea o sa aiba si metode abstracte care nu vor fi implementate si clasa respectiva, ci in clasele derivate din clasa respectiva. Motivul pentru care facem ca o clasa sa fie  abstracta este doar pentru a deriva din ea.In momentul in care am facut aceea clasa abstracta nu mai putem instantie nici un obiect din clasa respectiva cu new, dar toate componenta clasei vor fi folosite ca si elemente mostenite in clasele derivate.
  
