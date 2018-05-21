using pod_v1.sort.entidade;
using pod_v1.sort.entity;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace pod_v1
{
    class QuickSort
    {
        private TIPO tipo;
        private Stopwatch stopWatch;

        public QuickSort(TIPO tipo)
        {
            stopWatch = new Stopwatch();
            this.tipo = tipo;
            stopWatch.Start();
        }

        public Stopwatch StopWatch { get => stopWatch; }

        public List<Candidato> sort(List<Candidato> candidatos)
        {
            if (candidatos.Count <= 1)
            {
                return candidatos;
            }

            int posicaoPivo = candidatos.Count / 2;
            Candidato valorPivo = candidatos[posicaoPivo];

            candidatos.RemoveAt(posicaoPivo);
            List<Candidato> menor = new List<Candidato>();
            List<Candidato> maior = new List<Candidato>();

            foreach (Candidato candidato in candidatos)
            {
                if (CompararCandidatos.menor(candidato, valorPivo, this.tipo))
                {
                    menor.Add(candidato);
                }
                else
                {
                    maior.Add(candidato);
                }
            }

            List<Candidato> ordenado = sort(menor);
            ordenado.Add(valorPivo);
            ordenado.AddRange(sort(maior));

            stopWatch.Stop();
            return ordenado;
        }
    }
}