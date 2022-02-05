using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020___Subiect_2___Grupa_1048___Rezervari_Online_Hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTrimite_Click(object sender, EventArgs e)
        {
            if (tbNume.Text == "")
                errorProvider1.SetError(tbNume, "Introduceti numele!");
        else
       if (tbCod.Text == "")
                errorProvider1.SetError(tbCod, "Introduceticodul rezervarii!");
        else
            {
                try
                {
                    String nume = tbNume.Text;
                    int cod = Convert.ToInt32(tbCod.Text);



                    //Creare credit
                    RezervareHotel c = new RezervareHotel(nume, cod);
                }

                //Adaugarea creditului intr-o lista de credite

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    errorProvider1.Clear();
                    tbNume.Clear();
                    tbCod.Clear();

                }

            }

        }
    }
}
