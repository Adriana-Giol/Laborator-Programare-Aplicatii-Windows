# Acceleratori (Curs 5)
- KeyDown
- KeyUp
- KeyPress

Form -> Buton -> Prorpeitatea `TEXT = Afisare`:</br>
- `&Afisare`: se trateaza acceleratorul ALT + A; </br>
- `Afi&sare`: se trateaza accceleratorul ALT + S</br>
Tratam evenimentul de click pe buton (poate fi doar un mesaj), iar cand apasam tasta CTRL+A se realizeaza evenimntul de click pe buton.</br>

### Iesire din aplicatie se poate face si prin combinatia `Alt + E`, prin interceptarea tastaturii.
**PAS 1: Selectezi Form1 -> Proprietati TAB -> KeyPreview = TRUE**</br>
**PAS 2: Selectezi Form1 -> Evenimente TAB-> dublu-click pe KeyDown**</br>

`Keys.E` -> referinta pt tasta `E`*Keys* = enum care contine toate tastele de la tastatura.</br>
`e.Alt` -> tasta ALT, `e.Control` -> CTRL, `e.Shift` -> Shift</br>

```csharp
 private void Form1_KeyDown(object sender, KeyEventArgs e)
{
   if(e.KeyCode == Keys.E && e.Alt)
   {
   	this.Close(); //asa se inchide app
   }
}
```
# Varianta 1 - 3 tratari de acceleratori - KeyDown, KeyPress, KeyUp
## 1. KeyDown - Verificam daca tastele apesate sunt tastele numerica din partea de sus sau din partea drepata
```cpp
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)      //tastele de la 0-9 din partea de sus
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9) ////tastele de la 0-9 din partea din dreapta
                    if(e.KeyCode!=Keys.Back)      //excludem tasta BackSpace ca sa putem sterge
                    {
                        notNumber = true;
                        textBox2.Text += e.KeyCode.ToString(); //afiseaza codul de pe cele 2 tastaturi
                    }
        }
```
## 2. KeyPress - Verificam daca evenimentul este tratat
```cpp
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notNumber == true)
                e.Handled = true;
        }
 ```
## 3. KeyUp - Excludem tastatele functionale - F1
 ```cpp

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            notNumber = false;
            if (e.KeyCode == Keys.F1)
                MessageBox.Show("Am apasat F1");
        }
```
# Doar tratarea evenimentului de KeyPress
```cpp
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
             //Varianta lunga
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
                
                //Varianta scruta
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
 ```
