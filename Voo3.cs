using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializaçãoTP
{
    [Serializable]
    internal class Voo3
    {

        private string origem;
        private string destino;
        private DateTime DateTime;
        private string compania;
        private bool operando;

        public string Origem
        {
            set { origem = value; }
            get { return origem; }
        }
        public string Destino
        { set { destino = value; } get { return destino; } }

        public DateTime dateTime1
        {
            set { DateTime = value; }
            get { return DateTime; }
        }

        public string Compania
        {
            set { compania = value; }
            get { return compania; }
        }

        public bool Operando
        {
            set => operando = value; get { return operando; }
        }

        public Voo3() { }
        public Voo3(string origem, DateTime dateTime, string compania, bool operando)
        {
            this.origem = origem;
            DateTime = dateTime;
            this.compania = compania;
            this.operando = operando;
        }

    }
}
