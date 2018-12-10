import language.*
import simplificar.*


/** Exclusão de Produções vazias.
 *
 *  Passo 1: Obter produções que geram direta ou indiretamente cadeia vazia.
 *           A -> & ou B -> A, Não considerar: [B -> aA]
 *
 *  Passo 2: Criar produções que substituem &
 *
 *  Passo 3: Inclusão de geração da palavra vazia, se necessário
 */
fun Gramatica.removerProducoesVazias(): Gramatica {

    val geramProducoesVaziasDiretamente = this.geraProducaoVaziaDiretamente()

    if (geramProducoesVaziasDiretamente.isEmpty()) {
        return this
    }

    val producoesSubstitutas = criarProducoesDeSubstituicao(geramProducoesVaziasDiretamente)

    if (!this.startPossuiProducaoVazia()) {
        return this.copy(producoes = producoesSubstitutas)
    }

    val producoes = adicionarVazioNasRegrasDeProducaoDoStart(producoesSubstitutas)

    return this.copy(producoes = producoes)
}

/** Exclusão de produções unitárias
 *
 *  Passo 1: Encontrar variáveis que fazem produções unitárias.
 *
 *  Passo 2: Remover produções e substituir, copiando a regra das produções substituídas.
 *
 *  Se: A -> B | aA        Logo: A -> aA | bB | cC
 *      B -> C | bB              B -> C | bB
 *      C -> cC                  C -> cC
 *
 *  Se: A -> B | aA        Logo: A -> aA | cC | bB
 *      B -> cC | bB             B -> cC | bB
 *      C -> c                   C -> c
 */

fun removerProducoesUnitarias(gramatica: Gramatica): Gramatica {

    val producoesUnitarias = obterProducoesUnitarias(gramatica)

    if (producoesUnitarias.isEmpty()) {
        return gramatica
    }

    val novasRegras =
        gramatica.producoes.union(substituirProducoesUnitariasFazendoACopiaDasRegras(producoesUnitarias)).toList()

    return gramatica.copy(producoes = novasRegras)
}

/** Exclusão de símbolos inúteis.
 *
 *  Passo 1: Obter variáveis que gera terminais direta ou indiretamente. A -> a | B -> Ab
 *
 *  Passo 2: Obter variáveis e símbolos atingíveis pelo start.
 */

fun removerSimbolosInuteis(gramatica: Gramatica): Gramatica {

    val variaveisQueGeramTerminais = geraTerminalDiretamente(gramatica).union(geraTerminalIndiretamente(gramatica))

    val simbolosAtingiveis = simbolosAtingiveisPeloStart(gramatica)

    val novaGramatica = removerSimbolos(gramatica, simbolosAtingiveis)

    return gramatica.copy(
        variaveis = novaGramatica.variaveis,
        terminais = novaGramatica.terminais,
        producoes = novaGramatica.producoes
    )
}
