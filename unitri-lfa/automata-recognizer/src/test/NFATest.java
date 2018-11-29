import com.google.common.collect.ArrayListMultimap;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertFalse;
import static org.junit.jupiter.api.Assertions.assertTrue;

class NFATest {

    /*
     * Representation: Recognize n0 or n1 and finalStates with 01
     *
     *  q0 -> Initial state
     *  q2 -> Final State
     *
     *  q0->1 -> q0
     *  q0->0 -> q0
     *  q0->0 -> q1
     *  q1->1 -> q2
     */
    @Test
    void should_recognize_non_finite_automata() {

        ArrayListMultimap<String, String> table = ArrayListMultimap.create();

        {
            table.put("initial", "q0");
            table.put("final", "q2");
            table.put("q0->a", "q0");
            table.put("q0->b", "q0");
            table.put("q0->a", "q1");
            table.put("q1->a", "q2");
        }

        NFA automata = new NFA(table);

        boolean isValid = automata.extension("abaa");
        boolean isInvalid = automata.extension("abab");

        assertTrue(isValid);
        assertFalse(isInvalid);
    }
}