# 1. Definirea claselor necesare implementarii modelului aplicatiei: 
- minim 2 clase derivata din ICloneable si IComparable
- constructor si proprietati pentru atributele private 
- Supraincarcare operatori: index, + 

- Delegate/Event - se vor face tratare lor sau se vor utilia Degatii standard de la Windows Forms pentru a trata diversele evenimeste specifice controalelor.
- Partea de validare este subiect sensibil deoarece atunci cand avem o interfata vizuala si lasam utilizatorul sa introduca date exista un ECHILIBRU FOARTE SENSIBIL intre a face 
o validare puternica si a asigura o experienta de USER friendly Interface. Cu cat facem mai multe validari cu atat aplicatia va fi mai putin USER FIRNDLY, cu cat facem mai putine
validari cu atat exista riscul mai mare ca aplicatia sa crape sau ca datele pe care noi le colectam si pe care le vom salva in fisier sau in baza de date sa nu fie corecte si complete.
- Salvarea / Restaurarea datelor din fisier: fisiere text + Serializare / Deserializare
- Acces la campuri prin acceleratori; SHORT - CUTURI.
- Prezentarea grafica a datelor - Controlul CHART - contol specific pentru realizarea graficurilor (dar nu il vom folosi pentru ca ne ofera o vizualizare specifica cum ar fi un grafic de tip bare in EXCEL), dar noi o sa desenam propriul nostru grafic cu ajutorul clasei Graphics (LA EXAMEN SE CERE SA SE DESENEZE GRAFICUL)!
- Realizarea unui control de utilizator: nu il vom crea de la 0, ci vom combina mai multe controale = O FEREASTRA DE LOG IN

