import language.*
import org.junit.jupiter.api.Test
import kotlin.test.assertFalse
import kotlin.test.assertTrue

internal class SimplifyGrammarKtTest {


    @Test
    internal fun `deve simplificar uma gramatica`() {
        TODO("not implemented") //To change body of created functions use File | Settings | File Templates.
    }

    @Test
    internal fun `deve remover as producoes vazias da gramatica`() {

        val gramatica = Gramatica(

            variaveis = mutableListOf(
                Variavel('S'),
                Variavel('A'),
                Variavel('B')
            ),
            terminais = mutableListOf(
                Terminal("a"),
                Terminal("b")
            ),
            producoes = mutableListOf(
                Producao(
                    'S', mutableListOf(
                        RegrasDeProducao("aA"),
                        RegrasDeProducao("bB")
                    )
                ),
                Producao(
                    'A', mutableListOf(
                        RegrasDeProducao("B"),
                        RegrasDeProducao("a")
                    )
                ),
                Producao(
                    'B', mutableListOf(
                        RegrasDeProducao("b"),
                        RegrasDeProducao("&")
                    )
                )
            ),
            start = Variavel('S')
        )

        val novaGramatica = gramatica.removerProducoesVazias()

        assertFalse {
            novaGramatica.producoes.any { prod ->
                prod.regras.any { it.derivaVazio() }
            }
        }
    }

    @Test
    internal fun `deve remover as producoes vazias e adicionar ao start`() {

        val gramatica = Gramatica(

            variaveis = mutableListOf(
                Variavel('S'),
                Variavel('A'),
                Variavel('B')
            ),
            terminais = mutableListOf(
                Terminal("a"),
                Terminal("b")
            ),
            producoes = mutableListOf(
                Producao(
                    'S', mutableListOf(
                        RegrasDeProducao("aA"),
                        RegrasDeProducao("bB"),
                        RegrasDeProducao("&")

                    )
                ),
                Producao(
                    'A', mutableListOf(
                        RegrasDeProducao("B"),
                        RegrasDeProducao("a")
                    )
                ),
                Producao(
                    'B', mutableListOf(
                        RegrasDeProducao("b"),
                        RegrasDeProducao("&")
                    )
                )
            ),
            start = Variavel('S')
        )

        val novaGramatica = gramatica.removerProducoesVazias()

        assertTrue {
            novaGramatica.producoes.any { prod ->
                prod.regras.any { prod.nome == 'S' && it.derivaVazio() }
            }
        }

    }

    @Test
    internal fun `deve remover as producoes unitarias`() {
        TODO("not implemented") //To change body of created functions use File | Settings | File Templates.
    }

    @Test
    internal fun `deve remover os simbolos inuteis`() {
        TODO("not implemented") //To change body of created functions use File | Settings | File Templates.
    }


}