using System.Collections.Generic;
using System.Linq;
using SuperPoker.SearchMethods.Operations;

namespace SuperPoker.Controler {
	public class DFS : SearchMethod {
		readonly List<int> _cards;
		
		readonly Operation[] _operations = {new Addition(), new Subtraction(), new Multiplication(), new Division(), new Division2()};
		
		const int _objective = 24;
		const double EPSILON = 0.00000001;
		
		string _solution = "Search not yet performed.";
		
		public void acceptInput(Cards cards) {
			_cards.Add(cards.getCard(1));
			_cards.Add(cards.getCard(2));
			_cards.Add(cards.getCard(3));
			_cards.Add(cards.getCard(4));
		}
		
		public string receiveOutput() {
			return _solution;
		}
		
		public void search() {
			// Cancel search if no input has been provided.
			if (!_cards.Any()) {
				_solution = "Input for search has not been provided.";
				return;
			}
			
			// Populate the list of cards at level 1.
			var l1 = new List<double>();
			foreach (double e in _cards) l1.Add(e);
			
			// For each set of cards at level 1 (4 choose 2)...
			for (int card_1_1 = 0; card_1_1 < 3; card_1_1++) {
				for (int card_1_2 = card_1_1 + 1; card_1_2 < 4; card_1_2++) {
					
					double c_1_2 = l1[card_1_2]; // Card 2 for level 1 operation.
					l1.RemoveAt(card_1_2);
					double c_1_1 = l1[card_1_1]; // Card 1 for level 1 operation.
					l1.RemoveAt(card_1_1);
					double r_1_2 = l1[l1.Count() - 1]; // Card 2 remaining for level 2.
					l1.RemoveAt(l1.Count() - 1);
					double r_1_1 = l1[l1.Count() - 1]; // Card 1 remaining for level 2.
					l1.RemoveAt(l1.Count() - 1);
					
					// For each arithmetic operation at level 1...
					for (int op_1 = 0; op_1 < _operations.Length; op_1++) {
						
						double s1 = _operations[op_1].execute(c_1_1, c_1_2);
						
						// Populate the list at level 2 with the resultant value and remaining cards.
						var l2 = new List<double>();
						l2.Add(s1);
						l2.Add(r_1_1);
						l2.Add(r_1_2);
						
						// For each set of cards/resultant at level 2 (3 choose 2)...
						for (int card_2_1 = 0; card_2_1 < 2; card_2_1++) {
							for (int card_2_2 = card_2_1 + 1; card_2_2 < 3; card_2_2++) {
								
								double c_2_2 = l2[card_2_2]; // Card 2 for level 2 operation.
								l2.RemoveAt(card_2_2);
								double c_2_1 = l2[card_2_1]; // Card 1 for level 2 operation.
								l2.RemoveAt(card_2_1);
								double r_2   = l2[l2.Count() - 1]; // Card remaining for level 3.
								l2.RemoveAt(l2.Count() - 1);
								
								// Only use addition if the resultant from level 1 was 0.
								int ops_to_use_1 = (card_2_1 == 0) ? 1 : 5;
								
								// For each arithmetic operation at level 2...
								for (int op_2 = 0; op_2 < ops_to_use_1; op_2++) {
									
									double s2 = _operations[op_2].execute(c_2_1, c_2_2);
									
									// Only use addition if either resultant from level 2 was 0.
									int ops_to_use_2 = (System.Math.Abs(s2) < EPSILON || System.Math.Abs(r_2) < EPSILON) ? 1 : 5;
									
									// For each arithmetic operation at level 3.
									for (int op_3 = 0; op_3 < ops_to_use_2; op_3++) {
										if (System.Math.Abs(_operations[op_3].execute(s2, r_2) - _objective) < EPSILON) { // Solution found.
											prepareSolution(card_1_1, card_1_2, card_2_1, card_2_2, op_1, op_2, op_3);
											return;
										}
									}
								}
								// Reset list of cards at level 2 for next iteration.
								l2.Add(s1);
								l2.Add(r_1_1);
								l2.Add(r_1_2);
							}
						}
					}
					// Reset list of cards at level 1 for next iteration.
					foreach (double e in _cards) l1.Add(e);
				}
			}
			
			// No solution exists.
			prepareNoSolution();
		}
		
		// Creates the string representation of the solution from the search results.
		private void prepareSolution(int card_1_1, int card_1_2, int card_2_1, int card_2_2, int op_1, int op_2, int op_3) {
			string[] ops = {"+", "-", "*", "/", "/"};
			var cards_num = new List<double>();
			var cards_str = new List<string>();
			
			// Populate lists of cards.
			foreach (double e in _cards) cards_num.Add(e);
			foreach (int e in _cards) cards_str.Add(Cards.intToString(e));
			
			// Get card numeric values for level 1.
			double x_1_2 = cards_num[card_1_2];
			cards_num.RemoveAt(card_1_2);
			double x_1_1 = cards_num[card_1_1];
			cards_num.RemoveAt(card_1_1);
			
			// Get card string values for level 1.
			string c_1_2 = cards_str[card_1_2];
			cards_str.RemoveAt(card_1_2);
			string c_1_1 = cards_str[card_1_1];
			cards_str.RemoveAt(card_1_1);
			
			// Add resultant value for level 1 to list.
			cards_num.Insert(0, _operations[op_1].execute(x_1_1, x_1_2));
			
			// Fix order for division with card 1 in the denominator or subtraction resulting in negative.
			if (op_1 == 4 || (op_1 == 1 && x_1_1 < x_1_2)) { 
				string temp = c_1_1; c_1_1 = c_1_2; c_1_2 = temp; // Swap.
			}
			
			// Create string representation for level 1.
			string s1 = "(" + c_1_1 + ops[op_1] + c_1_2 + ")";
			
			// Add string representation for level 1 to list.
			cards_str.Insert(0, s1);
			
			// Get card numeric value for level 2.
			double x_2_2 = cards_num[card_2_2];
			cards_num.RemoveAt(card_2_2);
			double x_2_1 = cards_num[card_2_1];
			cards_num.RemoveAt(card_2_1);
			
			// Get card string value for level 2.
			string c_2_2 = cards_str[card_2_2];
			cards_str.RemoveAt(card_2_2);
			string c_2_1 = cards_str[card_2_1];
			cards_str.RemoveAt(card_2_1);
			
			// Add resultant value for level 2 to list.
			cards_num.Insert(0, _operations[op_2].execute(x_2_1, x_2_2));
			
			// Fix order for division with card 1 in the denominator or subtraction resulting in negative.
			if (op_2 == 4 || (op_2 == 1 && x_2_1 < x_2_2)) { 
				string temp = c_2_1; c_2_1 = c_2_2; c_2_2 = temp; // Swap.
			}
			
			// Create string representation for level 2.
			string s2 = "(" + c_2_1 + ops[op_2] + c_2_2 + ")";
			
			// Add string representation for level 2 to list.
			cards_str.Insert(0, s2);
			
			// Get card numeric value for level 3.
			double x_3_2 = cards_num[cards_num.Count() - 1];
			cards_num.RemoveAt(cards_num.Count() - 1);
			double x_3_1 = cards_num[cards_num.Count() - 1];
			cards_num.RemoveAt(cards_num.Count() - 1);
			
			// Get card string value for level 3.
			string c_3_2 = cards_str[cards_str.Count() - 1];
			cards_str.RemoveAt(cards_str.Count() - 1);
			string c_3_1 = cards_str[cards_str.Count() - 1];
			cards_str.RemoveAt(cards_str.Count() - 1);
			
			// Fix order for division with card 1 in the denominator or subtraction resulting in negative.
			if (op_3 == 4 || (op_3 == 1 && x_3_1 < x_3_2)) { 
				string temp = c_3_1; c_3_1 = c_3_2; c_3_2 = temp; // Swap.
			}
			
			// Create final string representation.
			_solution = "(" + c_3_1 + ops[op_3] + c_3_2 + ")";
		}
		
		// Sets the solution value when no solution is found.
		void prepareNoSolution() {
			_solution = "No solution exists.";
		}
		
		public DFS() {
			_cards = new List<int>();
		}
	}
}
