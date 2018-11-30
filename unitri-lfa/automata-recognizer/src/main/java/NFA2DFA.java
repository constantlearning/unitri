import java.util.*;

public class NFA2DFA {

    private List<String> alphabet;
    private String start;
    private List<String> finalStates;
    private NFA nfa;

    private Stack<String> unmappedStates = new Stack<>();

    public NFA2DFA(List<String> alphabet, String start, List<String> finalStates, NFA nfa) {
        this.alphabet = alphabet;
        this.start = start;
        this.finalStates = finalStates;
        this.nfa = nfa;
    }

    public Map<String, String> convert() {

        Map<String, Map<String, String>> table = new HashMap<>();

        table.put(start, getTransitions(start, alphabet));

        while (hasUnmmapedStates(table)) {
            mapNewStates(table);
            mapNewTransitions(table);
        }

        return mapToDfaTable(table);
    }

    private Boolean hasUnmmapedStates(Map<String, Map<String, String>> dfa) {

        this.unmappedStates.clear();

        final Set<String> keys = dfa.keySet();

        for (Map<String, String> value : dfa.values()) {
            for (String transition : value.values()) {
                if (!keys.contains(transition)) {
                    this.unmappedStates.add(transition);
                    return true;
                }
            }
        }

        return false;
    }

    private void mapNewStates(Map<String, Map<String, String>> dfa) {

        Map<String, String> symbolTransitions = new HashMap<>();
        alphabet.forEach(x -> symbolTransitions.put(x, ""));

        while (!unmappedStates.isEmpty()) {
            String newKey = unmappedStates.pop();
            dfa.put(newKey, symbolTransitions);
        }
    }

    private void mapNewTransitions(Map<String, Map<String, String>> table) {

        table.forEach((state, transitions) -> {

                    Map<String, String> unmappedTransitions = new HashMap<>();

                    transitions.forEach((symbol, transition) ->
                            mapEmptyTransitions(state, unmappedTransitions, symbol, transition));

                    putNewTransitions(table, state, unmappedTransitions);
                }
        );
    }

    private void putNewTransitions(Map<String, Map<String, String>> table, String state, Map<String, String> unmappedTransitions) {
        unmappedTransitions.forEach((sym, tra) -> table.put(state, unmappedTransitions));
    }

    private void mapEmptyTransitions(String state, Map<String, String> unmappedTransitions, String symbol, String transition) {
        if (transition.isEmpty()) {

            StringBuilder newTransition = new StringBuilder();

            if (state.length() > 2) {
                List<String> states = symbolSplit(state);
                states.forEach(s -> newTransition.append(getTransition(s, symbol)));
            }

            unmappedTransitions.put(symbol, newTransition.toString());
        }
    }

    private Map<String, String> mapToDfaTable(Map<String, Map<String, String>> table) {

        final Set<String> keys = table.keySet();

        Map<String, String> dfa = new HashMap<>();

        table.forEach((state, transitions) ->
                transitions.forEach((symbol, transition) -> {
                    dfa.put(String.format("%s->%s", state, symbol), transition);
                })
        );

        mapStartEndFinalStates(keys, dfa);

        return dfa;
    }

    private void mapStartEndFinalStates(Set<String> keys, Map<String, String> dfa) {

        StringBuilder endStates = new StringBuilder();

        dfa.put("initial", start);

        for (String key : keys) {
            for (String state : this.finalStates) {
                if (key.contains(state)) {
                    endStates.append(key);
                }
            }
        }

        dfa.put("final", endStates.toString());
    }

    private String getTransition(String state, String symbol) {
        return cleanStates(nfa.getTransition(state, symbol).toString());
    }

    private Map<String, String> getTransitions(String state, List<String> alphabet) {
        Map<String, String> transitions = new HashMap<>();

        for (String symbol : alphabet) {
            transitions.put(symbol, cleanStates(nfa.getTransition(state, symbol).toString()));
        }

        return transitions;
    }

    private String cleanStates(String states) {
        return states.replace("[", "")
                .replace(",", "")
                .replace("]", "")
                .replace(" ", "");
    }

    private List<String> symbolSplit(String symbol) {
        return Arrays.asList(symbol.split("(?<=\\G.{2})"));
    }
}