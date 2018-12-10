package language

import org.junit.jupiter.api.Test
import kotlin.test.assertEquals
import kotlin.test.assertFalse

internal class ProducaoTest {

    @Test
    internal fun `deve remover as producoes vazias e retornar um objeto limpo`() {

        val producao = Producao(
            'S', mutableListOf(
                RegrasDeProducao("Aa"), RegrasDeProducao("BAa"), RegrasDeProducao("&")
            )
        )


        val novaProducao = producao.obterProducoesRemovendoDerivacaoVazia()
        assertEquals(2, novaProducao.regras.size)
        assertFalse { novaProducao.regras.any { it.derivaVazio() } }
    }
}