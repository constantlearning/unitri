using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2.Source.DTO.graphic
{
    class FaturamentoFilial
    {
        private String nomeFilial;
        private double faturamento;

        public string NomeFilial { get => nomeFilial; set => nomeFilial = value; }
        public double Faturamento { get => faturamento; set => faturamento = value; }
    }
}
