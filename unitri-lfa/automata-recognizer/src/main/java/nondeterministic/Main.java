package nondeterministic;

import java.util.List;

public class Main {

    public static void main(String[] args) {

        /**
         * Representation: Recognize n0 or n1 and end with 01
         *
         *  q0 -> Initial state
         *  q2 -> Final State
         *
         *  q0->1 -> q0
         *  q0->0 -> q0
         *  q0->0 -> q1
         *  q1->1 -> q2
         */

        NonDeterministicFiniteAutomata automata = new NonDeterministicFiniteAutomata();
        System.out.println(automata.extension("abaa"));
    }
}
