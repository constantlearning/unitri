using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2.Source.DTO.graphic
{
    class FaturamentoBarbearia
    {
        private String nomeBarbearia;
        private double faturamento;

        public double Faturamento { get => faturamento; set => faturamento = value; }
        public string NomeBarbearia { get => nomeBarbearia; set => nomeBarbearia = value; }
    }
}
