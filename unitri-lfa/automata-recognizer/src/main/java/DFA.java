import java.util.Map;

public class DFA {

    private Map<String, String> table;

    public DFA(Map<String, String> table) {
        this.table = table;
    }

    public Boolean extension(String simbol) {
        return isValid(extension("initial", simbol));
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

        if (state == null) {
            return false;
        }

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