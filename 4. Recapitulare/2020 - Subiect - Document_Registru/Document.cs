using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020___Subiect___Document_Registru
{
    class Document:IComparable, ICloneable
    {
        private int cod;
        private String titlu;
        private DateTime data;

        public Document(int cod, string titlu, DateTime data)
        {
            this.cod = cod;
            this.titlu = titlu;
            this.data = data;
        }

        public int Cod { get => cod; }
        public string Titlu { get => titlu; set => titlu = value; }
        public DateTime Data { get => data; set => data = value; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            Document d1 = (Document)obj;
                return string.Compare(this.titlu, d1.titlu);


            return string.Compare(this.titlu, d1.titlu);

        }

        public override string ToString()
        {
            return "Documentul " + titlu + "are codul " + cod + "si este scris la data de " + data; 
        }
    }
}
