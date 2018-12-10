package language

data class RegrasDeProducao(
    val derivacao: String
)


fun RegrasDeProducao.possuiProducaoUnitariaNaDerivacao(): Boolean =
    this.derivacao.length == 1 && this.derivacao.toCharArray()[0].isUpperCase()

fun RegrasDeProducao.derivaVazio(): Boolean = this.derivacao.contains("&")

fun RegrasDeProducao.naoDerivaVazio(): Boolean = !this.derivacao.contains("&")

fun RegrasDeProducao.derivaAlgumDosSimbolos(variaveisQueGeramVazioDiretamente: List<Char>): Pair<Char, Boolean> {
    val derivaAlgumSimbolo: Boolean = variaveisQueGeramVazioDiretamente.contains(derivacao.toCharArray().first())
    val symbol = variaveisQueGeramVazioDiretamente.map { this.derivacao.toCharArray().first() }.first()
    return Pair(symbol, derivaAlgumSimbolo)
}

fun RegrasDeProducao.producaoUnitaria(): Boolean = this.derivacao.length == 1

fun RegrasDeProducao.obterDerivacaoComoSimbolo(): Char = this.derivacao.first()
