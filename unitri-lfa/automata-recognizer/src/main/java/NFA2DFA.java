import java.util.*;

public class NFA2DFA {

    private List<String> alphabet;
    private String start;
    private List<String> finalStates;
    private NFA nfa;

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
        }

        return mapToDfaTable(table);
    }

    private Boolean hasUnmmapedStates(Map<String, Map<String, String>> dfa) {

        final Set<String> keys = dfa.keySet();

        for (Map<String, String> value : dfa.values()) {
            for (String transition : value.values()) {
                if (!keys.contains(transition)) {
                    return true;
                }
            }
        }

        return false;
    }

    private void mapNewStates(Map<String, Map<String, String>> dfa) {

    }

    private Map<String, String> mapToDfaTable(Map<String, Map<String, String>> table) {

        Map<String, String> dfa = new HashMap<>();

        //TODO: lógica de:para

        // VAI DAR PROBLEMA DE CONCORRENCIA AO TENTAR MODIFICAR E ACESSAR
        // PRIMEIRO MAPEA OS NOVOS ESTADOS
        // SEGUNDO PEGA AS TRANSIÇÕES PRA CADA UM DOS SIMBOLOS DO ALFABETO
        // ADICIONA NO MAPA
        // MAPEAR OS NOVOS ESTADOS...

        dfa.put("q0q1q2", "q0");

        mapStartEndFinalStates(dfa);

        return dfa;
    }

    private void mapStartEndFinalStates(Map<String, String> dfa) {

        List<String> endStates = new ArrayList<>();

        dfa.put("initial", start);

        for (String key : dfa.keySet()) {
            for (String state : this.finalStates) {
                if (key.contains(state)) {
                    endStates.add(key);
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
}