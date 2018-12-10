package language

data class Producao(
    val nome: Char,
    val regras: MutableList<RegrasDeProducao>
)

fun Producao.obterProducoesRemovendoDerivacaoVazia(): Producao {
    val novasRegras = this.regras.filter { it.derivacao != "&" }.toMutableList()
    return this.copy(regras = novasRegras)
}

fun Producao.removerDerivacoesVazias(): Producao {
    val derivacoesNaoVazias = this.regras.filter { !it.derivacao.contains("&") }.toMutableList()
    return this.copy(regras = derivacoesNaoVazias)
}

fun Producao.substituirProducoesVaziasIndiretamente(
    semVazioDiretamente: List<Producao>,
    geramProducoesVaziasIndiretamente: List<Producao>
): List<Producao> {

    val novasProducoes = listOf<Producao>().toMutableList()

    geramProducoesVaziasIndiretamente.forEach { producao ->
        producao.regras.forEach { regra ->

            if (regra.possuiProducaoUnitariaNaDerivacao()) {

                val novasRegras = semVazioDiretamente
                    .filter { it.nome == regra.derivacao.toCharArray().first() }
                    .map { it.regras }.flatten()

                this.regras.union(novasRegras)
            }
        }

        novasProducoes.add(producao)
    }

    return novasProducoes
}

