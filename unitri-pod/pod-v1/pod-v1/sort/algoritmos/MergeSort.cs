using pod_v1.sort.entidade;
using pod_v1.sort.entity;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace pod_v1
{
    class MergeSort
    {
        private TIPO tipo;
        private Stopwatch stopWatch;


        public MergeSort(TIPO tipo)
        {
            stopWatch = new Stopwatch();
            this.tipo = tipo;
        }

        public Stopwatch StopWatch { get => stopWatch; set => stopWatch = value; }

        public List<Candidato> sort(List<Candidato> desordenado)
        {
            stopWatch.Start();
            List<Candidato> ordenado = mergeSort(desordenado);
            stopWatch.Stop();
            return ordenado;
        }

        public List<Candidato> mergeSort(List<Candidato> desordenado)
        {
            if (desordenado.Count <= 1)
            {
                return desordenado;
            }

            List<Candidato> left = new List<Candidato>();
            List<Candidato> right = new List<Candidato>();

            int middle = desordenado.Count / 2;
            for (int i = 0; i < middle; i++)
            {
                left.Add(desordenado[i]);
            }
            for (int i = middle; i < desordenado.Count; i++)
            {
                right.Add(desordenado[i]);
            }

            left = sort(left);
            right = sort(right);
            return Merge(left, right);
        }


        private List<Candidato> Merge(List<Candidato> left, List<Candidato> right)
        {
            List<Candidato> result = new List<Candidato>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (CompararCandidatos.menorOuIgual(left[0], right[0], this.tipo))
                    {
                        result.Add(left[0]);
                        left.Remove(left[0]);
                    }
                    else
                    {
                        result.Add(right[0]);
                        right.Remove(right[0]);
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left[0]);
                    left.Remove(left[0]);
                }
                else if (right.Count > 0)
                {
                    result.Add(right[0]);
                    right.Remove(right[0]);
                }
            }
            return result;
        }
    }
}