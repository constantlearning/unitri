using pod_v1.sort.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pod_v1.sort.entidade
{
    class CompararCandidatos
    {

        public static bool igual(Candidato atual, Candidato proximo, TIPO tipo)
        {
            switch (tipo)
            {
                case TIPO.NOME:
                    int result = String.CompareOrdinal(atual.Nome, proximo.Nome);
                    if (result == 0) { return true; }
                    break;
                case TIPO.MATRICULA:
                    if (atual.Matricula == proximo.Matricula) { return true; }
                    break;
                case TIPO.NOTA:
                    if (atual.Nota == proximo.Nota) { return true; }
                    break;
            }
            return false;
        }

        public static bool maior(Candidato atual, Candidato proximo, TIPO tipo)
        {
            switch (tipo)
            {
                case TIPO.NOME:
                    int result = String.CompareOrdinal(atual.Nome, proximo.Nome);
                    if (result > 0) { return true; }
                    break;
                case TIPO.MATRICULA:
                    if (atual.Matricula > proximo.Matricula) { return true; }
                    break;
                case TIPO.NOTA:
                    if (atual.Nota > proximo.Nota) { return true; }
                    break;
            }
            return false;
        }

        public static bool menor(Candidato atual, Candidato proximo, TIPO tipo)
        {
            switch (tipo)
            {
                case TIPO.NOME:
                    int result = String.CompareOrdinal(atual.Nome, proximo.Nome);
                    if (result < 0) { return true; }
                    break;
                case TIPO.MATRICULA:
                    if (atual.Matricula < proximo.Matricula) { return true; }
                    break;
                case TIPO.NOTA:
                    if (atual.Nota < proximo.Nota) { return true; }
                    break;
            }
            return false;
        }

        public static bool maiorOuIgual(Candidato atual, Candidato proximo, TIPO tipo)
        {
            switch (tipo)
            {
                case TIPO.NOME:
                    int result = String.CompareOrdinal(atual.Nome, proximo.Nome);
                    if (result > 0 || result == 0) { return true; }
                    break;
                case TIPO.MATRICULA:
                    if (atual.Matricula >= proximo.Matricula) { return true; }
                    break;
                case TIPO.NOTA:
                    if (atual.Nota >= proximo.Nota) { return true; }
                    break;
            }
            return false;
        }

        public static bool menorOuIgual(Candidato atual, Candidato proximo, TIPO tipo)
        {
            switch (tipo)
            {
                case TIPO.NOME:
                    int result = String.CompareOrdinal(atual.Nome, proximo.Nome);
                    if (result < 0 || result == 0) { return true; }
                    break;
                case TIPO.MATRICULA:
                    if (atual.Matricula <= proximo.Matricula) { return true; }
                    break;
                case TIPO.NOTA:
                    if (atual.Nota <= proximo.Nota) { return true; }
                    break;
            }
            return false;
        }
    }
}
