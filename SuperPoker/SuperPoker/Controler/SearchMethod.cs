namespace SuperPoker.Controler {
	public interface SearchMethod {
		
		// Accepts an object with card values and sets the
		// internal state in preparation of performing a search.
		void acceptInput(Cards cards);
		
		// Returns the search results in string representation.
		string receiveOutput();
		
		// Performs the search. acceptInput() should be called before
		// searching, and receiveOutput() should be called afterward.
		void search();
	}
}
