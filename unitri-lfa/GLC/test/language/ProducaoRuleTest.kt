package language

import org.junit.jupiter.api.Assertions.assertFalse
import org.junit.jupiter.api.Assertions.assertTrue
import org.junit.jupiter.api.Test

internal class ProducaoRuleTest {


    @Test
    internal fun `should return if has direct production in derivation`() {

        assertTrue { RegrasDeProducao("B").possuiProducaoUnitariaNaDerivacao() }
        assertFalse { RegrasDeProducao("b").possuiProducaoUnitariaNaDerivacao() }
        assertFalse { RegrasDeProducao("bB").possuiProducaoUnitariaNaDerivacao() }
    }
}