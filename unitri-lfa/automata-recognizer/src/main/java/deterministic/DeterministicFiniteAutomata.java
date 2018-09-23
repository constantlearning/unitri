package deterministic;

import java.util.HashMap;
import java.util.Map;

public class DeterministicFiniteAutomata {

    private Map<String, String> table = new HashMap<>();

    {
        table.put("initial", "q0");
        table.put("final", "q0");
        table.put("q0->0", "q0");
        table.put("q0->1", "q1");
        table.put("q1->0", "q1");
        table.put("q1->1", "q0");
    }


    public String extension(String simbol) {
        return extension("initial", simbol);
    }


    public String extension(String initial, String simbol) {

        if (simbol.isEmpty()) {
            return table.get(initial);
        }

        return getTransition(extension(initial, getX(simbol)), getA(simbol));
    }

    public String getTransition(String state, String simbol) {
        return table.get(String.format("%s->%s", state, simbol));
    }

    public boolean isValid(String state) {
        return table.get("final").contains(state);
    }

    private static String getA(String input) {

        if (input != null && input.length() > 0) {
            return String.valueOf(input.charAt(input.length() - 1));
        }

        throw new RuntimeException("");
    }

    private static String getX(String input) {

        if (input != null && input.length() > 0) {
            return input.substring(0, input.length() - 1);
        }

        throw new RuntimeException("");
    }

}