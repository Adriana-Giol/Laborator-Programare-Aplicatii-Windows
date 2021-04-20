# Transfer de date intre formulare
ArrayList - no problem</br>
List<> - clasa publica</br>

## Form1:
```cpp
ArrayList listProd = new ArrayList();
Form2 frm = new Form2(listProd);
frm.Show();
```

## Form2:
```cpp
ArrayList lista2;
public Form2(ArrayList lista1)
{
    InitializeComponent();
     lista2 = lista1;
}
```
![image](https://user-images.githubusercontent.com/60271540/115414607-d909df00-a1fe-11eb-95f4-679eabe82006.png)
