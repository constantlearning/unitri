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
    class SelectionSort
    {
        private List<Candidato> candidatosList;
        private TIPO tipo;
        private Stopwatch stopWatch;

        public SelectionSort(List<Candidato> candidatos, TIPO tipo)
        {
            stopWatch = new Stopwatch();
            this.candidatosList = candidatos;
            this.tipo = tipo;
        }

        public Stopwatch StopWatch { get => stopWatch; set => stopWatch = value; }

        public List<Candidato> sort()
        {
            stopWatch.Start();
            for (int i = 0; i < this.candidatosList.Count - 1; i++)
            {
                int indexOfSelectedValue = i;
                int indexOfMinValue = i;
                for (int j = i + 1; j < this.candidatosList.Count; j++)
                {
                    int indexOfIterationValue = j;

                    if (CompararCandidatos.menor(this.candidatosList[indexOfIterationValue], this.candidatosList[indexOfMinValue], this.tipo))
                    {
                        indexOfMinValue = indexOfIterationValue;
                    }
                    
                }
                swap(indexOfMinValue, indexOfSelectedValue);
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
