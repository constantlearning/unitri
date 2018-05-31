using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2.Source.Entity
{
    class Chamado
    {
        private Int32 id;
        private String origem;
        private String destino;
        private String telefone;
        private DateTime data;
        private Funcionario funcionario;

        public int Id { get => id; set => id = value; }
        public string Origem { get => origem; set => origem = value; }
        public string Destino { get => destino; set => destino = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public DateTime Data { get => data; set => data = value; }
        internal Funcionario Funcionario { get => funcionario; set => funcionario = value; }
    }
}
