using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2.Source.DTO
{
    class PedidoAtendente
    {
        private String nomeAtendente;
        private Int32 quantidade;

        public string NomeAtendente { get => nomeAtendente; set => nomeAtendente = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
    }
}
