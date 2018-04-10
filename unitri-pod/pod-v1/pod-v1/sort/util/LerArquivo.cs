
using pod_v1.sort.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pod_v1.sort.util
{
    class LerArquivo
    {
        private static String filePath = @"file\BaseDeDados.txt";

        public List<Candidato> obterCandidatos()
        {
            List<Candidato> candidatos = new List<Candidato>();

            string[] lines = System.IO.File.ReadAllLines(filePath);

            foreach (String line in lines){
                String[] data = line.Split(';');
                String nome = data[0];
                long matricula = long.Parse(data[1]);
                double nota = double.Parse(data[2]);
                candidatos.Add(
                    new Candidato(nome, matricula, nota));
            }

            return candidatos;
        }


    }
}
