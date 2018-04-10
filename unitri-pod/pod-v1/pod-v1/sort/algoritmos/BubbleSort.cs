using pod_v1.sort.entidade;
using pod_v1.sort.entity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pod_v1.sort.algoritmos
{
    class BubbleSort
    {
        private List<Candidato> candidatosList;
        private TIPO tipo;
        private Stopwatch stopWatch;


        public BubbleSort(List<Candidato> candidatoList, TIPO tipo)
        {
            stopWatch = new Stopwatch();
            this.candidatosList = candidatoList;
            this.tipo = tipo;
        }

        public Stopwatch StopWatch { get => stopWatch; set => stopWatch = value; }

        public List<Candidato> sort()
        {
            stopWatch.Start();

            bool swapped = true;
            while (swapped)
            {
                swapped = false;
                for (int i = 0; i < candidatosList.Count - 1; i++)
                {
                    Candidato atual = candidatosList[i];
                    Candidato proximo = candidatosList[i + 1];

                    if (CompararCandidatos.maior(atual, proximo, this.tipo))
                    {
                        swap(candidatosList.IndexOf(atual), candidatosList.IndexOf(proximo));
                        swapped = true;
                    }
                }
            }

            stopWatch.Stop();
            return new List<Candidato>(candidatosList);
        }

        private void swap(int firstIndex, int secIndex)
        {
            String nome = candidatosList[firstIndex].Nome;
            long matricula = candidatosList[firstIndex].Matricula;
            double nota = candidatosList[firstIndex].Nota;

            Candidato temporario = new Candidato(nome, matricula, nota);

            candidatosList[firstIndex] = candidatosList[secIndex];
            candidatosList[secIndex] = temporario;
        }


    }
}
