using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2.Source.Entity
{
    class Veiculo
    {
        private Int32 id;
        private String placa;
        private String marca;
        private DateTime anoModelo;
        private DateTime anoFabricacao;

        public int Id { get => id; set => id = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public DateTime AnoModelo { get => anoModelo; set => anoModelo = value; }
        public DateTime AnoFabricacao { get => anoFabricacao; set => anoFabricacao = value; }
    }
}
