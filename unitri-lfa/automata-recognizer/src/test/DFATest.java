import org.junit.jupiter.api.Test;

import java.util.HashMap;
import java.util.Map;

import static org.junit.jupiter.api.Assertions.assertFalse;
import static org.junit.jupiter.api.Assertions.assertTrue;

class DFATest {

    @Test
    void should_recognize_finite_deterministic_automata() {

        Map<String, String> table = new HashMap<>();
        {
            table.put("initial", "q0");
            table.put("final", "q0");
            table.put("q0->0", "q0");
            table.put("q0->1", "q1");
            table.put("q1->0", "q1");
            table.put("q1->1", "q0");
        }

        DFA automata = new DFA(table);

        Boolean isValid = automata.extension("0101");
        Boolean isInvalid = automata.extension("01210");

        assertTrue(isValid);
        assertFalse(isInvalid);
    }
}