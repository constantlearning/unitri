using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pod_v1.sort.entity
{
    class Candidato
    {

        private String nome;
        private long matricula;
        private double nota;

        public Candidato(string nome, long matricula, double nota)
        {
            this.Nome = nome;
            this.Matricula = matricula;
            this.Nota = nota;
        }

        public string Nome { get => nome; set => nome = value; }
        public long Matricula { get => matricula; set => matricula = value; }
        public double Nota { get => nota; set => nota = value; }
    }
}
