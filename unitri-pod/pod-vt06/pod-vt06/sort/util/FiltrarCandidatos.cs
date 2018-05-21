using pod_v1.sort.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pod_v1.sort.util
{
    class FiltrarCandidatos
    {
        private LerArquivo file;

        public FiltrarCandidatos()
        {
            file = new LerArquivo();
        }

        public List<Candidato> candidatosAcimaDaNota(double nota)
        {
            List<Candidato> candidatos = new List<Candidato>();
            List<Candidato> todosCandidatos = file.ObterCandidatos();

            todosCandidatos.ForEach(cand =>
            {
                if (cand.Nota > nota && !candidatos.Contains(cand))
                {
                    candidatos.Add(cand);
                }
            });

            return candidatos;
        }

        public List<Candidato> candidatosAbaixoDaNota(double nota)
        {
            List<Candidato> candidatos = new List<Candidato>();

            List<Candidato> todosCandidatos = file.ObterCandidatos();
            todosCandidatos.ForEach(cand =>
            {
                if (cand.Nota < nota && !candidatos.Contains(cand))
                {
                    candidatos.Add(cand);
                }
            });

            return candidatos;
        }

        public List<Candidato> candidatosNoIntervaloDeInscricao(long inicio, long final)
        {
            List<Candidato> candidatos = new List<Candidato>();

            List<Candidato> todosCandidatos = file.ObterCandidatos();
            todosCandidatos.ForEach(cand =>
            {
                if (cand.Matricula >= inicio && cand.Matricula <= final)
                {
                    candidatos.Add(cand);
                }
            });

            return candidatos;
        }

    }
}
