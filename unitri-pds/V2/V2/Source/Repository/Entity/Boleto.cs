using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2.Source.Entity
{
    class Boleto
    {
        private Int32 id;
        private Double valor;
        private Conveniada conveniada;

        public int Id { get => id; set => id = value; }
        public double Valor { get => valor; set => valor = value; }
        internal Conveniada Conveniada { get => conveniada; set => conveniada = value; }
    }
}
