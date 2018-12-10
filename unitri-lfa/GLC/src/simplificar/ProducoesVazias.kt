package simplificar

import language.*

fun startPossuiProducaoVazia(gramatica: Gramatica): Boolean {
    return geraProducaoVaziaDiretamente(gramatica)
        .map { it.nome }.any { it == 'S' }
}

fun geraProducaoVaziaDiretamente(gramatica: Gramatica): List<Producao> {
    return gramatica.producoes.filter { producao -> producao.regras.any { it.derivacao.contains("&") } }
}

private fun variavelDerivaCadeiaVazia(gramatica: Gramatica, simbolo: Char): Boolean {
    return gramatica.producoes.filter { producao -> producao.nome == simbolo }
        .map { it.regras }.flatten()
        .any { it.derivacao.contains("&") }
}

private fun obterDerivacoesDeVariavel(gramatica: Gramatica, c: Char): List<RegrasDeProducao> {
    return gramatica.producoes.first { it.nome == c }.regras
}

private fun derivacoesDeVariavelSemCadeiaVazia(gramatica: Gramatica, c: Char): List<RegrasDeProducao> {
    return gramatica.producoes.first { it.nome == c }.regras.filter { it.naoDerivaVazio() }
}


fun criarProducoesDeSubstituicao(
    gramatica: Gramatica,
    geramProducoesVaziasDiretamente: List<Producao>
): List<Producao> {

    val producoesSemCadeiaVazia: MutableList<Producao> = removerProducoesQueDerivamCadeiaVazia(gramatica)

    val variaveisQueGeramVazioDiretamente: List<Char> =
        geramProducoesVaziasDiretamente.map { it.obterProducoesRemovendoDerivacaoVazia() }.map { it.nome }

    val substituirDerivacoesVaziasIndiretamente: List<Producao> =
        substituirProducoesVaziasIndiretas(gramatica, producoesSemCadeiaVazia, variaveisQueGeramVazioDiretamente)

    return recriarRegrasDeProducao(gramatica, substituirDerivacoesVaziasIndiretamente)
}

private fun recriarRegrasDeProducao(
    gramatica: Gramatica,
    derivacoesVaziasIndiretamente: List<Producao>
): List<Producao> {

    val producoesVaziasIndiretamente = geraProducaoVaziaIndiretamente(gramatica)
    val producoesSubstituidas = criarNovasProducoes(gramatica, producoesVaziasIndiretamente)

    val novasProducoes = derivacoesVaziasIndiretamente.toMutableList()
    novasProducoes.removeAll(producoesVaziasIndiretamente)
    novasProducoes.addAll(producoesSubstituidas)

    return novasProducoes
}

private fun criarNovasProducoes(
    gramatica: Gramatica,
    geramProducoesVaziasIndiretamente: List<Producao>
): MutableList<Producao> {

    val novasRegrasDeProducao = mutableListOf<Producao>()
    val producoesQueDevemSerSustituidas = mutableListOf<Producao>()

    val produzemVazio = simbolosQueDerivamVazio(gramatica)

    geramProducoesVaziasIndiretamente.forEach { producao ->
        producao.regras.forEach { regra ->
            regra.derivacao.forEach { symbol ->

                if (symbol.isUpperCase() && produzemVazio.contains(symbol)) {

                    val novaProducao = novasRegrasDeProducao.find { it.nome == producao.nome }

                    val regrasDaDerivacao = derivacoesDeVariavelSemCadeiaVazia(gramatica, symbol)
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

private fun simbolosQueDerivamVazio(gramatica: Gramatica): List<Char> {

    val simbolos = mutableListOf<Char>()

    val diretamente =
        geraProducaoVaziaDiretamente(gramatica).map { it.obterProducoesRemovendoDerivacaoVazia() }.map { it.nome }

    for (producao in gramatica.producoes) {
        for (regra in producao.regras) {

            if (regra.producaoUnitaria() && !diretamente.contains(regra.obterDerivacaoComoSimbolo())) {
                simbolos.add(producao.nome)
            }
        }
    }

    return simbolos.distinct()
}

private fun geraProducaoVaziaIndiretamente(gramatica: Gramatica): List<Producao> {

    val derivacoes: List<Producao> =
        gramatica.producoes.filter { producao ->
            producao.regras.any {
                it.derivacao.length > 1
            }
        }

    val lista = listOf<Producao>().toMutableList()

    derivacoes.forEach { producao ->
        producao.regras
            .forEach { regra ->
                if (derivaVazioIndiretamente(gramatica, regra)) {
                    lista.add(producao)
                }
            }
    }

    return lista
}

private fun derivaVazioIndiretamente(gramatica: Gramatica, regra: RegrasDeProducao): Boolean {
    for (it in regra.derivacao) {
        if (variavelDerivaCadeiaVazia(gramatica, it)) return true
    }
    return false
}

private fun substituirProducoesVaziasIndiretas(
    gramatica: Gramatica,
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
                val regrasCopiadas = derivacoesDeVariavelSemCadeiaVazia(gramatica, derivaVazio.first)

                novasRegrasDeProducao.add(producao.copy(regras = regrasDaProducao.union(regrasCopiadas).toMutableList()))

                producoesQueGeramVazio.add(producao)
            }
        }
    }

    producoesSemCadeiaVazia.removeAll(producoesQueGeramVazio)
    producoesSemCadeiaVazia.addAll(novasRegrasDeProducao)

    return producoesSemCadeiaVazia
}

private fun removerProducoesQueDerivamCadeiaVazia(gramatica: Gramatica): MutableList<Producao> {

    return gramatica.producoes.map { it.obterProducoesRemovendoDerivacaoVazia() }.toMutableList()
        .let { gramatica.producoesQueNaoDerivamVazio() }
}

private fun Gramatica.producoesQueNaoDerivamVazio(): MutableList<Producao> {
    return this.producoes.map { it.obterProducoesRemovendoDerivacaoVazia() }.toMutableList()
}

fun adicionarVazioNasRegrasDeProducaoDoStart(
    gramatica: Gramatica,
    producoesSubstitutas: List<Producao>
): List<Producao> {

    if (!startHasEmptySymbol(gramatica)) {
        return gramatica.producoes
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

private fun startHasEmptySymbol(gramatica: Gramatica): Boolean {
    return gramatica.producoes.filter { producao -> producao.nome == 'S' }
        .map { it.regras }.flatten()
        .any { it.derivacao.contains("&") }
}

private fun obterRegrasPorVariavel(gramatica: Gramatica, variavel: Char): List<RegrasDeProducao> {
    return gramatica.producoes.first { it.nome == variavel }.regras
}