import language.*
import org.junit.jupiter.api.Test

internal class HelloTest {

    @Test
    fun test() {

        val gramatica = Gramatica(

            variaveis = mutableListOf(
                Variavel('S'),
                Variavel('A'),
                Variavel('B'),
                Variavel('C'),
                Variavel('D')
            ),
            terminais = mutableListOf(
                Terminal("a"),
                Terminal("b"),
                Terminal("c"),
                Terminal("d")
            ),
            producoes = mutableListOf(
                Producao(
                    'S', mutableListOf(
                        RegrasDeProducao("AB"),
                        RegrasDeProducao("A"),
                        RegrasDeProducao("CAa")
                    )
                ),
                Producao(
                    'A', mutableListOf(
                        RegrasDeProducao("a"),
                        RegrasDeProducao("b")
                    )
                ),
                Producao(
                    'B', mutableListOf(
                        RegrasDeProducao("BC"),
                        RegrasDeProducao("AB"),
                        RegrasDeProducao("bb"),
                        RegrasDeProducao("&")
                    )
                ),
                Producao(
                    'C', mutableListOf(
                        RegrasDeProducao("cC"),
                        RegrasDeProducao("aC")
                    )
                ),
                Producao(
                    'D', mutableListOf(
                        RegrasDeProducao("dD"),
                        RegrasDeProducao("d"),
                        RegrasDeProducao("c")
                    )
                )
            ),
            start = Variavel('S')
        )

//        val simplificacaoGLC = SimplificacaoGLC(gramatica)
//        var novaGramatica = simplificacaoGLC.etapa1()
//        novaGramatica = simplificacaoGLC.etapa2()
//        novaGramatica = simplificacaoGLC.etapa3()
//        println(novaGramatica)
    }
}