import org.junit.Assert
import org.junit.jupiter.api.Test

import java.text.DecimalFormat

class Exercises {


    @Test
    fun exercicio01a() {

    }

    @Test
    fun exercicio01b() {

    }

    @Test
    fun exercicio01c() {

    }

    //    @Test
    //    public void exercicio02a() {
    //
    //        QueueOperations queue = new MM1Queue(300, 400, 60);
    //        Double result = queue.(0);
    //
    //        System.out.println("(2):" +  result);
    //    }
    //
    //    @Test
    //    public void exercicio02b() {
    //
    //        QueueOperations queue = new MM1Queue(300, 400, 60);
    //        Double result = queue.(0);
    //
    //        System.out.println("(2):" +  result);
    //    }
    //
    //    @Test
    //    public void exercicio02c() {
    //
    //        QueueOperations queue = new MM1Queue(300, 400, 60);
    //        Double result = queue.(0);
    //
    //        System.out.println("(2):" +  result);
    //    }

    @Test
    fun exercicio03() {

        val queue = MM1Queue(300, 400, 60)
        val result = queue.probabilityOfNIsGreatterThenK(0)

        println("(3):" + result!!)
    }

    @Test
    fun exercicio04() {

        val queue = MM1Queue(300, 400, 60)
        val result = queue.averageOfWaitingInTheQueue()

        println("(4):" + result!!)
    }

    @Test
    fun exercicio05a() {

        val queue = MM1Queue(150, 250, 60)
        val result = queue.averageOfClientsInTheSystem()

        println("(5a):" + result!!)
    }

    @Test
    fun exercicio05b() {

        val queue = MM1Queue(150, 250, 60)
        val result = queue.averageOfWaitingInTheQueue()

        println("(5b):" + result!!)
    }

    @Test
    fun exercicio05c() {

        val queue = MM1Queue(150, 250, 60)
        val result = queue.probabilityOfNIsGreatterThenK(10)

        println("(5c):" + result!!)
    }

}
