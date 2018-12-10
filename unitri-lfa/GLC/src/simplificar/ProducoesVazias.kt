package simplificar

import language.*

fun Gramatica.startPossuiProducaoVazia(): Boolean {
    return geraProducaoVaziaDiretamente()
        .map { it.nome }.any { it == 'S' }
}

fun Gramatica.geraProducaoVaziaDiretamente(): List<Producao> {
    return producoes.filter { producao -> producao.regras.any { it.derivacao.contains("&") } }
}

private fun Gramatica.variavelDerivaCadeiaVazia(simbolo: Char): Boolean {
    return this.producoes.filter { producao -> producao.nome == simbolo }
        .map { it.regras }.flatten()
        .any { it.derivacao.contains("&") }
}

fun Gramatica.obterDerivacoesDeVariavel(c: Char): List<RegrasDeProducao> {
    return producoes.first { it.nome == c }.regras
}

fun Gramatica.derivacoesDeVariavelSemCadeiaVazia(c: Char): List<RegrasDeProducao> {
    return producoes.first { it.nome == c }.regras.filter { it.naoDerivaVazio() }
}


fun Gramatica.criarProducoesDeSubstituicao(
    geramProducoesVaziasDiretamente: List<Producao>
): List<Producao> {

    val producoesSemCadeiaVazia: MutableList<Producao> = this.removerProducoesQueDerivamCadeiaVazia()

    val variaveisQueGeramVazioDiretamente: List<Char> =
        geramProducoesVaziasDiretamente.map { it.obterProducoesRemovendoDerivacaoVazia() }.map { it.nome }

    val substituirDerivacoesVaziasIndiretamente: List<Producao> =
        this.substituirProducoesVaziasIndiretas(producoesSemCadeiaVazia, variaveisQueGeramVazioDiretamente)

    return recriarRegrasDeProducao(substituirDerivacoesVaziasIndiretamente)
}

private fun Gramatica.recriarRegrasDeProducao(derivacoesVaziasIndiretamente: List<Producao>): List<Producao> {

    val producoesVaziasIndiretamente = this.geraProducaoVaziaIndiretamente()
    val producoesSubstituidas = criarNovasProducoes(producoesVaziasIndiretamente)

    val novasProducoes = derivacoesVaziasIndiretamente.toMutableList()
    novasProducoes.removeAll(producoesVaziasIndiretamente)
    novasProducoes.addAll(producoesSubstituidas)

    return novasProducoes
}

private fun Gramatica.criarNovasProducoes(
    geramProducoesVaziasIndiretamente: List<Producao>
): MutableList<Producao> {

    val novasRegrasDeProducao = mutableListOf<Producao>()
    val producoesQueDevemSerSustituidas = mutableListOf<Producao>()

    val produzemVazio = this.simbolosQueDerivamVazio()

    geramProducoesVaziasIndiretamente.forEach { producao ->
        producao.regras.forEach { regra ->
            regra.derivacao.forEach { symbol ->

                if (symbol.isUpperCase() && produzemVazio.contains(symbol)) {

                    val novaProducao = novasRegrasDeProducao.find { it.nome == producao.nome }

                    val regrasDaDerivacao = this.derivacoesDeVariavelSemCadeiaVazia(symbol)
                        .filter { it.obterDerivacaoComoSimbolo().isLowerCase() }
                        .toMutableList()

                    val regrasDaProducao = producao.regras

                    novaProducao?.regras?.addAll(regrasDaDerivacao)

                    novaProducao ?: novasRegrasDeProducao.add(
                        producao.copy(
                            regras = regrasDaDerivacao.union(
                                regrasDaProducao
                            ).toMutableList()
                        )
                    )

                    producoesQueDevemSerSustituidas.add(producao)
                }
            }
        }
    }

    return novasRegrasDeProducao.toMutableList()

}

private fun Gramatica.simbolosQueDerivamVazio(): List<Char> {

    val simbolos = mutableListOf<Char>()

    val diretamente =
        this.geraProducaoVaziaDiretamente().map { it.obterProducoesRemovendoDerivacaoVazia() }.map { it.nome }

    for (producao in producoes) {
        for (regra in producao.regras) {

            if (regra.producaoUnitaria() && !diretamente.contains(regra.obterDerivacaoComoSimbolo())) {
                simbolos.add(producao.nome)
            }
        }
    }

    return simbolos.distinct()
}

fun Gramatica.geraProducaoVaziaIndiretamente(): List<Producao> {

    val derivacoes: List<Producao> =
        this.producoes.filter { producao ->
            producao.regras.any {
                it.derivacao.length > 1
            }
        }

    val lista = listOf<Producao>().toMutableList()

    derivacoes.forEach { producao ->
        producao.regras
            .forEach { regra ->
                if (this.derivaVazioIndiretamente(regra)) {
                    lista.add(producao)
                }
            }
    }

    return lista
}

private fun Gramatica.derivaVazioIndiretamente(regra: RegrasDeProducao): Boolean {
    for (it in regra.derivacao) {
        if (this.variavelDerivaCadeiaVazia(it)) return true
    }
    return false
}

private fun Gramatica.substituirProducoesVaziasIndiretas(
    producoesSemCadeiaVazia: MutableList<Producao>,
    variaveisQueGeramVazioDiretamente: List<Char>
): List<Producao> {

    val novasRegrasDeProducao = mutableListOf<Producao>()
    val producoesQueGeramVazio = mutableListOf<Producao>()

    producoesSemCadeiaVazia.forEach { producao ->
        producao.regras.forEach { regra ->

            val derivaVazio = regra.derivaAlgumDosSimbolos(variaveisQueGeramVazioDiretamente)

            if (regra.possuiProducaoUnitariaNaDerivacao() && derivaVazio.second) {

                val regrasDaProducao = producao.regras
                val regrasCopiadas = this.derivacoesDeVariavelSemCadeiaVazia(derivaVazio.first)

                novasRegrasDeProducao.add(producao.copy(regras = regrasDaProducao.union(regrasCopiadas).toMutableList()))

                producoesQueGeramVazio.add(producao)
            }
        }
    }

    producoesSemCadeiaVazia.removeAll(producoesQueGeramVazio)
    producoesSemCadeiaVazia.addAll(novasRegrasDeProducao)

    return producoesSemCadeiaVazia
}

private fun Gramatica.removerProducoesQueDerivamCadeiaVazia(): MutableList<Producao> {

    return this.producoes.map { it.obterProducoesRemovendoDerivacaoVazia() }.toMutableList()
        .let { this.producoesQueNaoDerivamVazio() }
}

private fun Gramatica.producoesQueNaoDerivamVazio(): MutableList<Producao> {
    return this.producoes.map { it.obterProducoesRemovendoDerivacaoVazia() }.toMutableList()
}

fun Gramatica.adicionarVazioNasRegrasDeProducaoDoStart(producoesSubstitutas: List<Producao>): List<Producao> {

    if (!startHasEmptySymbol()) {
        return this.producoes
    }

    val producoes = mutableListOf<Producao>()

    producoesSubstitutas.forEach { producao ->

        if (producao.regras.any { producao.nome == 'S' && it.derivaVazio() }) {
            producoes.add(producao)
        }

        if (producao.regras.any { producao.nome != 'S' }) {
            producoes.add(producao)
        }

    }

    return producoes
}

private fun Gramatica.startHasEmptySymbol(): Boolean {
    return producoes.filter { producao -> producao.nome == 'S' }
        .map { it.regras }.flatten()
        .any { it.derivacao.contains("&") }
}

fun Gramatica.obterRegrasPorVariavel(variavel: Char): List<RegrasDeProducao> {
    return producoes.first { it.nome == variavel }.regras
}