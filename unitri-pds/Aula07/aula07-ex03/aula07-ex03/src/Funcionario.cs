using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula07_ex03.src
{
    class Funcionario
    {
        private Int32 id;
        private Int32 cpf;
        private String nome;
        private Int32 matricula;
        private Double salario;
        private Int32 idCargo;

        public int Id { get => id; set => id = value; }
        public int Cpf { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Matricula { get => matricula; set => matricula = value; }
        public double Salario { get => salario; set => salario = value; }
        public int IdCargo { get => idCargo; set => idCargo = value; }
    }
}
