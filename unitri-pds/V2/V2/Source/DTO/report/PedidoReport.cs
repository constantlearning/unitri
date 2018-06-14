using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2.Source.DTO.report
{
    class PedidoReport
    {
        private Int32 id;
        private String cliente;
        private String atendente;
        private String barbearia;
        private String filial;
        private double total;
        private DateTime data;

        public int Id { get => id; set => id = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string Atendente { get => atendente; set => atendente = value; }
        public string Barbearia { get => barbearia; set => barbearia = value; }
        public string Filial { get => filial; set => filial = value; }
        public double Total { get => total; set => total = value; }
        public DateTime Data { get => data; set => data = value; }
    }
}
