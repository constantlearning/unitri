package language

import org.junit.jupiter.api.Test
import simplificar.geraProducaoVaziaDiretamente
import simplificar.geraProducaoVaziaIndiretamente
import simplificar.obterDerivacoesDeVariavel
import kotlin.test.assertEquals
import kotlin.test.assertTrue

internal class GramaticaTest {


    @Test
    internal fun `deve retornar quem gera producao vazia diretamente`() {

        val gramatica = Gramatica(

            variaveis = mutableListOf(
                Variavel('S'),
                Variavel('A'),
                Variavel('B')
            ),
            terminais = mutableListOf(
                Terminal("a"),
                Terminal("b"),
                Terminal("c"),
                Terminal("d")
            ),
            producoes = listOf(
                Producao(
                    'S', mutableListOf(
                        RegrasDeProducao("Aa"),
                        RegrasDeProducao("BAa")
                    )
                ),
                Producao('A', mutableListOf(RegrasDeProducao("B"))),
                Producao('B', mutableListOf(RegrasDeProducao("&")))
            ),
            start = Variavel('S')
        )

        val geraVazioDiretamente = gramatica.geraProducaoVaziaDiretamente()

        assertTrue { geraVazioDiretamente.isNotEmpty() }
        assertEquals(1, geraVazioDiretamente.size)
        assertTrue { geraVazioDiretamente.any { it.nome == 'B' } }
    }


    @Test
    internal fun `deve retornar quem gera producao vazia indiretamente`() {

        val gramatica = Gramatica(

            variaveis = mutableListOf(
                Variavel('S'),
                Variavel('A'),
                Variavel('B')
            ),
            terminais = mutableListOf(
                Terminal("a"),
                Terminal("b"),
                Terminal("c"),
                Terminal("d")
            ),
            producoes = listOf(
                Producao(
                    'S', mutableListOf(
                        RegrasDeProducao("Aa"),
                        RegrasDeProducao("BAa")
                    )
                ),
                Producao('A', mutableListOf(RegrasDeProducao("B"))),
                Producao('B', mutableListOf(RegrasDeProducao("&")))
            ),
            start = Variavel('S')
        )

        val geraVazioIndiretamente = gramatica.geraProducaoVaziaIndiretamente()

        assertTrue { geraVazioIndiretamente.isNotEmpty() }
        assertEquals(1, geraVazioIndiretamente.size)
    }


    @Test
    internal fun `deve retornar a lista de derivacoes a partir de um simbolo`() {

        val gramatica = Gramatica(

            variaveis = mutableListOf(
                Variavel('S'),
                Variavel('A'),
                Variavel('B')
            ),
            terminais = mutableListOf(
                Terminal("a"),
                Terminal("b"),
                Terminal("c"),
                Terminal("d")
            ),
            producoes = listOf(
                Producao(
                    'S', mutableListOf(
                        RegrasDeProducao("Aa"),
                        RegrasDeProducao("BAa")
                    )
                ),
                Producao('A', mutableListOf(RegrasDeProducao("B"))),
                Producao('B', mutableListOf(RegrasDeProducao("&")))
            ),
            start = Variavel('S')
        )

        val derivacoes = gramatica.obterDerivacoesDeVariavel('S')

        assertTrue { derivacoes.isNotEmpty() }
        assertEquals(2, derivacoes.size)
    }
}

