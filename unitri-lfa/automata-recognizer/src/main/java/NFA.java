import com.google.common.collect.ArrayListMultimap;

import java.util.ArrayList;
import java.util.List;

public class NFA {

    private ArrayListMultimap<String, String> table;

    public NFA(ArrayListMultimap<String, String> table) {
        this.table = table;
    }

    public boolean extension(String word) {
        List<String> initialState = table.get("initial");
        return extension(word, initialState);
    }

    private boolean extension(String word, List<String> states) {

        if (word.isEmpty()) {
            return isValid(states);
        }

        states = getStatesTrantition(states, word);

        word = getX(word);

        return extension(word, states);
    }

    private List<String> getStatesTrantition(List<String> states, String word) {

        List<List<String>> transitionStates = new ArrayList<>();
        for (String state : states) {
            transitionStates.add(getTransition(state, getA(word)));
        }
        return groupTransitionStates(transitionStates);
    }

    private List<String> groupTransitionStates(List<List<String>> transitionStates) {

        List<String> states = new ArrayList<>();

        for (List<String> transition : transitionStates) {
            states.addAll(transition);
        }

        return states;
    }

    public List<String> getTransition(String state, String simbol) {
        return table.get(String.format("%s->%s", state, simbol));
    }

    private String getA(String input) {

        if (input != null && input.length() > 0) {
            return String.valueOf(input.charAt(0));
        }
        throw new RuntimeException("GetA is not possible.");
    }

    private String getX(String input) {

        if (input != null && input.length() > 0) {
            return input.substring(1);
        }
        throw new RuntimeException("GetX is not possible.");
    }

    private boolean isValid(List<String> state) {
        return state.stream().anyMatch(s -> s.equals(table.get("final").get(0)));
    }
}