## 📑Fisier XML
Fisierul XML are o structura arborescenta, dar la baza este tot un fisier text, doar ca are extensia XML si are o structura de noduri.
Fisierul XML este un fel de fisier text care are niste marcatori(tag-uri) si cu o structura arborescenta ca a unui fisier HTML. Fiecare element in sine are o structura arborescenta.

`<DataSet>` este un nod parinte care are 2 copii:
1. Header are 3 copii la randul lui (nepotii lui DataSet): `<Publisher>`, `<PublishingDate>`, `<MessageType>`
2. Body are 3 copii:
`<Subject>`
`<OrigCurrency>`
`<Cube>` are multi copii care se numesc `<Rate>`. Ca sa faca distinctia intre aceste noduri copil Rate s-a introdus atributul `Currency` cu o valoare EUR, XAU,GBP (acronimul unei valute).
  Nodul respectiv are si el o valoare care reprezinta cursul de schimb al acelei valute.
  
  Pentu a citi din acest fisier doar acele valori care ma intereseaza pe mine: Data Cursului sau cat este cursul pentru valuta EUR, USD, XAU.
  
EXISTA UN MECANISM DE PASRSARE:
- Daca vrem sa parsam acel fisier XMl trebuie sa includem biblioteca using System.XML.
- Prima data citim fisierul ca pe un fisier TEXT si dupa aceea folosind clasa XML.Reader o sa putem sa exploram structura arborescenta a fisierului XML.
