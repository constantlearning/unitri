using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2.Source.Entity
{
    class Habilitacao
    {

        private Int32 id;
        private String categoria;
        private DateTime emissao;
        private DateTime validade;
        private Motorista motorista;

        public Habilitacao(Motorista motorista, string categoria, DateTime emissao, DateTime validade)
        {
            this.motorista = motorista;
            this.categoria = categoria;
            this.emissao = emissao;
            this.validade = validade;
        }

        public int Id { get => id; set => id = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public DateTime Emissao { get => emissao; set => emissao = value; }
        public DateTime Validade { get => validade; set => validade = value; }
        internal Motorista Motorista { get => motorista; set => motorista = value; }
    }
}
