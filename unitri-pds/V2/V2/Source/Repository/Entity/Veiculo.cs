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
        private string marcaVeiculo;
        private DateTime dataModelo;
        private DateTime dataFabricacao;

        public Veiculo()
        {
        }

        public Veiculo(string placa, string marcaVeiculo, DateTime dataModelo, DateTime dataFabricacao)
        {
            this.Placa = placa;
            this.MarcaVeiculo = marcaVeiculo;
            this.DataModelo = dataModelo;
            this.DataFabricacao = dataFabricacao;
        }

        public int Id { get => id; set => id = value; }
        public string Placa { get => placa; set => placa = value; }
        public string MarcaVeiculo { get => marcaVeiculo; set => marcaVeiculo = value; }
        public DateTime DataModelo { get => dataModelo; set => dataModelo = value; }
        public DateTime DataFabricacao { get => dataFabricacao; set => dataFabricacao = value; }
    }
}
