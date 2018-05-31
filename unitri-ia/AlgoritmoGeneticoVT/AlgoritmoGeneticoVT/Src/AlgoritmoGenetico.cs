using AlgoritmoGeneticoVT.Src.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoGeneticoVT.Src
{
    class AlgoritmoGenetico
    {
        private int quantidadePopulacao;
        private int[] populacao;
        private string[] binario;
        private string[] filho;
        private string[] novaPopulacao;
        private double taxaDeMutacao;
        private int maximoDeGeracoes;
        private int quantidadeDeGeracoes;

        public int QuantidadeDeGeracoes { get => quantidadeDeGeracoes; set => quantidadeDeGeracoes = value; }
        public int[] Populacao { get => populacao; set => populacao = value; }

        public AlgoritmoGenetico(int qtdPopulação, double taxaDeMutacao, int maximoDeGeracoes)
        {
            this.quantidadePopulacao = qtdPopulação;
            this.taxaDeMutacao = taxaDeMutacao;
            this.maximoDeGeracoes = maximoDeGeracoes;

            this.populacao = new int[quantidadePopulacao];
            this.binario = new string[quantidadePopulacao];
            this.filho = new string[quantidadePopulacao / 2];
            this.novaPopulacao = new string[quantidadePopulacao + filho.Length];
        }


        /*
         * Realiza a evolução enquanto não alcançar a quantidade máxima de gerações
         * ou quando toda a população atingir o máximo da função de aptidão.
         */
        public void Evolucao()
        {
            quantidadeDeGeracoes = 0;

            GerarPopulacao();

            while (true)
            {
                Array.Clear(binario, 0, binario.Length);
                Array.Clear(filho, 0, filho.Length);

                if (AtingiuCriterioDeParada()) {
                    break;
                }

                Roleta(); // Revisar
                Cruzamento();
                Mutacao(); // Revisar
                Selecao();

                quantidadeDeGeracoes++;
            }

        }

       /*
        * A população é inicializada com valores aleatórios entre 0 e 1023.
        */
        private void GerarPopulacao()
        {
            Random aleatorio = new Random();

            for (int i = 0; i < populacao.Length; i++)
            {
                populacao[i] = aleatorio.Next(0, 1023);
            }
        }

        /*
         * O critério de parada se dá quando a quantidade de gerações atingiu o limite
         * ou quando toda a população convergir para o máximo global.
         */
        private bool AtingiuCriterioDeParada()
        {
            return quantidadeDeGeracoes == maximoDeGeracoes || PopulacaoAtingiuMaximoDaFuncaoDeAptidao();
        }

       /*
        * Verifica se a população atingiu o máximo da função de aptidão, ou seja
        * se todos os elementos tem o valor de 1023.
        * 
        * Passo 1: Conta todos os elementos que possuem o valor de 1023.
        * Passo 2: Verifica se a quantidade de indivíduos que retornaram 1023 é do tamanho da população.
        */
        private bool PopulacaoAtingiuMaximoDaFuncaoDeAptidao()
        {
            int count = 0;

            foreach (int valor in populacao)
            {
                if (valor == 1023)
                {
                    count++;
                }
            }

            return count == populacao.Length;
        }

        //Método probabilístico que utiliza a aptidão relativa
        private void Roleta()
        {
            int[] aptidaoRelativa = new int[populacao.Length];
            double soma = 0.0;

            //Somatório da população
            for (int i = 0; i < populacao.Length; i++)
            {
                soma += populacao[i] * populacao[i];
            }

            int IndiceMaximoRoleta = 0;
            //Faz o cálculo da aptidão relativa de cada indivíduo
            for (int i = 0; i < aptidaoRelativa.Length; i++)
            {
                aptidaoRelativa[i] = AptidaoRelativaDoIndividuo(i, soma);
                IndiceMaximoRoleta += aptidaoRelativa[i];
            }

            int[] roleta = new int[IndiceMaximoRoleta];
            int cont = 0;
            for (int i = 0; i < aptidaoRelativa.Length; i++)
            {
                for (int j = 0; j < aptidaoRelativa[i]; j++)
                {
                    roleta[cont] = populacao[i]; //Atribui ao vetor roleta os indivíduos aptos
                    cont++;
                }
            }

            SelecionarPais(roleta);
        }

        /*
         * Cálculo da Aptidão relativa de UM indivíduo.
         * Multiplica o valor da aptidão absoluda por ela mesma e divide pelo somatório das aptidões absolutas
         */
        private int AptidaoRelativaDoIndividuo(int i, double soma)
        {
            return (int) Math.Floor((populacao[i] * (double)populacao[i]) / (soma * 100));
        }

       /*
        * Seleciona os pais aleatoriamente.
        * 
        * Passo 1: Gera um vetor que contem os pais. (São gerados aleatóriamente)
        * Passo 2: Converte os pais gerados para binário. (Para fazer o corte posteriormente e gerar novos indivíduos)
        */
        private void SelecionarPais(int[] roleta)
        {
            Random aleatorio = new Random();
            int[] pais = new int[50];

            for (int i = 0; i < pais.Length; i++)
            {
                pais[i] = roleta[aleatorio.Next(0, roleta.Length)];
            }

            BasesNumericas.DecimalParaBinario(pais, binario); // Converte TODOS os pais de decimal para binário.
        }

      /*
       * Gera um "filho" a partir de dois vetores. (O filho possui 10 bits)
       * 
       * Passo 1: Realiza o corte no bit 5 do pai e mãe.
       * Passo 2: Junta as duas metades e gera um novo indivíduo. (Pai + Mãe)
       */
        private void Cruzamento()
        {
            int pontoCorte = 5;

            for (int i = 0; i < filho.Length; i++)
            {
                String pai = "";
                String mae = "";
                pai = binario[i].Substring(0, pontoCorte);
                mae = binario[filho.Length + i].Substring(0, pontoCorte);
                filho[i] = string.Concat(pai, mae);
            }
        }

        /*
         * Para cada cromossomo, é realizada uma mutação em sua carga genética onde
         * é alterado o seu valor caso fique abaixo da taxa de mutação.
         */
        private void Mutacao()
        {
            Random aleatorio = new Random();

            //Atribui ao novo vetor os valores do vetor binário até a posição 49
            for (int i = 0; i < binario.Length; i++)
            {
                novaPopulacao[i] = binario[i];
            }

            //Atribui ao novo vetor o vetor de filhos apartir da posicao 49
            for (int i = binario.Length; i < novaPopulacao.Length; i++)
            {
                novaPopulacao[i] = filho[i - binario.Length];
            }

            for (int i = 0; i < novaPopulacao.Length; i++)
            {
                StringBuilder sb = new StringBuilder(novaPopulacao[i]);

                for (int j = 0; j < novaPopulacao[i].Length; j++)
                {
                    double valorGerado = aleatorio.NextDouble(); //Gera um valor aleatório entre 0 e 1

                    if (taxaDeMutacao > valorGerado) //Verifica se o valor gerado é menor que a taxa de mutação
                    {
                        // Lembrar de explicar: Essa matriz não é mágica, é porque cada string é um vetor de caracteres.
                        if (novaPopulacao[i][j] == '1') //Se o caracter for 1 substitui por 0
                        {
                            sb.Remove(j, 1);
                            sb.Insert(j, "0");
                            novaPopulacao[i] = sb.ToString();
                        }
                        else
                        {
                            sb.Remove(j, 1);
                            sb.Insert(j, "1");
                            novaPopulacao[i] = sb.ToString();
                        }
                    }
                }
            }

            // Pega cada elemento da nova população e os converte para decimal.
            for (int i = 0; i < novaPopulacao.Length; i++)
            {
                novaPopulacao[i] = BasesNumericas.BinarioParaDecimal(novaPopulacao[i]).ToString();
            }
        }

       /*
        * Ordena a nova população em ordem decrescente e seleciona os melhores. (maior aptidão absoluta)
        * A quantidade de elementos selecionados é do tamanho da população. (no caso 50)
        */
        private void Selecao()
        {
            int[] individuosTemporarios = new int[novaPopulacao.Length];

            for (int i = 0; i < individuosTemporarios.Length; i++)
            {
                individuosTemporarios[i] = int.Parse(novaPopulacao[i]);
            }

            Array.Sort(individuosTemporarios);
            Array.Reverse(individuosTemporarios);
            Array.Copy(individuosTemporarios, 0, populacao, 0, populacao.Length);
        }

    }
}
