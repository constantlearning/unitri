import com.google.common.collect.ArrayListMultimap;
import org.junit.Assert;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

class NFA2DFATest {

    private ArrayListMultimap<String, String> table;
    private Map<String, String> expectedOut;

    @BeforeEach
    void setUp() {

        table = ArrayListMultimap.create();
        table.put("initial", "q0");
        table.put("final", "q2");
        table.put("q0->a", "q0");
        table.put("q0->b", "q0");
        table.put("q0->a", "q1");
        table.put("q1->a", "q2");

        expectedOut = new HashMap<>();
        expectedOut.put("initial", "q0");
        expectedOut.put("final", "q0q1q2");
        expectedOut.put("q0q1->a", "q0q1q2");
        expectedOut.put("q0q1->b", "q0");
        expectedOut.put("q0q1q2->a", "q0q1q2");
        expectedOut.put("q0q1q2->b", "q0");
        expectedOut.put("q0->b", "q0");
        expectedOut.put("q0->a", "q0q1");
    }

    @Test
    void should_convert_nfa_to_dfa() {

        List<String> alphabet = new ArrayList<>();
        alphabet.add("a");
        alphabet.add("b");

        List<String> finalStates = new ArrayList<>();
        finalStates.add("q2");

        NFA nfa = new NFA(this.table);

        NFA2DFA nfa2DFA = new NFA2DFA(alphabet, "q0", finalStates, nfa);
        Map<String, String> out = nfa2DFA.convert();

        DFA dfa = new DFA(out);

        Assert.assertNotNull(out);
        Assert.assertEquals(expectedOut, out);
        Assert.assertTrue(dfa.extension("baa"));
    }
}