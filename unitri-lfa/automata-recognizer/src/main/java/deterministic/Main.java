package deterministic;

public class Main {

	public static void main(String[] args) {

        /**
         * Representation: Recognize a pair number of 1
         *
         *  Q0 -> Initial state
         *  Q1 -> Final State
         *
         *  Q0->0 -> Q0
         *  Q0->1 -> Q1
         *  Q1->0 -> Q0
         *  Q1->1 -> Q0
         */

	    DeterministicFiniteAutomata automata = new DeterministicFiniteAutomata();

		String q = automata.extension("0101");
		
		System.out.println(automata.isValid(q));
		
	}
		
}