package language

/**
 * Gramática livre de contexto é definida pela seguinte tupla: G = (V, T, P, S)
  *
  * V - Conjunto de variáveis.
  * T - Conjunto de terminais.
  * p - Regras de produção.
  * S - Variável Start
 */
data class Gramatica(
    val variaveis: List<Variavel>,
    val terminais: List<Terminal>,
    val producoes: List<Producao>,
    val start: Variavel
)

