using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect2019_2_
{
    class ClientRauPlatnic : Client, ICloneable, IComparable, IMedia
    {
        private String tipClient;
        private float sumaPlata;
        private float[] vectorPlatiLunare;

        public ClientRauPlatnic(string tipClient, float sumaPlata, float[] vectorPlatiLunare, String nume, int cod, String adresa) : base(nume, cod, adresa)
        {
            TipClient = tipClient;
            SumaPlata = sumaPlata;
            VectorPlatiLunare = (float[])vectorPlatiLunare.Clone();

        }

        public string TipClient { get => tipClient; set => tipClient = value; }
        public float SumaPlata { get => sumaPlata; set => sumaPlata = value; }
        public float[] VectorPlatiLunare { get => vectorPlatiLunare; set => vectorPlatiLunare = value; }

        public float CalculeazaValoareaMediePlatita((ClientRauPlatnic clientRau){
            if (clientRau.vectorPlatiLunare != null)
            {
                float suma = 0.0;
                for (int i = 0; i < clientRau.vectorPlatiLunare.Length; i++)
                    suma += clientRau.vectorPlatiLunare[i];
                return (float)suma / clientRau.vectorPlatiLunare.Length;
            }
            else
                return 0;
        }


        public object Clone()
        {
            ClientRauPlatnic clona = (ClientRauPlatnic)this.MemberwiseClone();
            float[] vectorPlatiLunareNoi = (float[])vectorPlatiLunare.Clone();
            clona.vectorPlatiLunare = vectorPlatiLunareNoi;
            return clona;
        }

        public float CompareTo(object obj)
        {
            ClientRauPlatnic clientRau = (ClientRauPlatnic)obj;
            if ((float)this < (float)clientRau)
                return -1;
            else
                if ((float)this > (float)clientRau)
                return 1;
            else
                return string.Compare(this.tipClient, clientRau.tipClient);
        }

        public override string ToString()
        {
            string rezultat = base.ToString() + " clientul este persoana " + tipClient + " are suma de platit in valoarea de "
                             + sumaPlata;
            if (vectorPlatiLunare != null)
            {
                rezultat += " si are urmatoarele palti lunare ";
                for (int i = 0; i < vectorPlatiLunare.Length; i++)
                    rezultat += vectorPlatiLunare[i] + " ";
            }
            else
                rezultat += " si nu are plati lunare precedente";
            return rezultat;

        }
        public static ClientRauPlatnic operator +(ClientRauPlatnic clientRau, float plataNoua)
        {
            float[] platiNoi = new float[clientRau.vectorPlatiLunare.Length + 1];
            for (int i = 0; i < clientRau.vectorPlatiLunare.Length; i++)
                platiNoi[i] = clientRau.vectorPlatiLunare[i];
            platiNoi[platiNoi.Length - 1] = plataNoua;
            clientRau.vectorPlatiLunare = platiNoi;
            return clientRau;
        }
        public static ClientRauPlatnic operator +(float plataNoua, ClientRauPlatnic clientRau)
        {
            return clientRau + plataNoua;
        }

        public static explicit operator double(ClientRauPlatnic clientRau)
        {
            if (clientRau.vectorPlatiLunare != null)
            {
                double suma = 0.0;
                for (int i = 0; i < clientRau.vectorPlatiLunare.Length; i++)
                    suma += clientRau.vectorPlatiLunare[i];
                return (double)suma / clientRau.vectorPlatiLunare.Length;
            }
            else
                return 0;
        }
    }
}

