namespace SuperPoker.Controler {
	public class Cards {
		readonly int[] _cards = new int[4];
		
		// Converts a card's string representation into it's corresponding numeric value.
		int stringToInt(string card) {
			switch (card) {
				case "A":
				case "a":
				case "J":
				case "j":
				case "Q":
				case "q":
				case "K":
				case "k":
					return symbolicToNumeric(card);
				case "1":
				case "2":
				case "3":
				case "4":
				case "5":
				case "6":
				case "7":
				case "8":
				case "9":
				case "10":
				case "11":
				case "12":
				case "13":
					return System.Int32.Parse(card);
				default:
					throw new System.ArgumentException("Illegal input value. Must be 1-13, or an upper or lower case 'A', 'J', 'Q', or 'K'.");
			}
		}
		
		// Converts a card's alphabetic value into the corresponding numeric value.
		int symbolicToNumeric(string card) {
			switch (card) {
				case "A":
				case "a":
					return 1;
				case "J":
				case "j":
					return 11;
				case "Q":
				case "q":
					return 12;
				case "K":
				case "k":
					return 13;
				default:
					throw new System.ArgumentException("Illegal symbol for facecard. Must be upper or lower case 'A', 'J', 'Q', or 'K'.");
			}
		}
		
		// Convert's a card's numeric value into the corresponding string representation.
		public static string intToString(int card) {
			switch (card) {
				case 1:
					return "A";
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
				case 9:
				case 10:
					return card.ToString();
				case 11:
					return "J";
				case 12:
					return "Q";
				case 13:
					return "K";
				default:
					throw new System.ArgumentException("Illegal input value. Must be 1-13.");
			}
		}
		
		// Returns the numeric value of the specified card number (from 1 to 4).
		public int getCard(int index) {
			if (index >= 1 || index <= 4) return _cards[index - 1];
			throw new System.ArgumentException("Illegal card number. Must be 1-4.");
		}
		
		public Cards(string card1, string card2, string card3, string card4) {
			_cards[0] = stringToInt(card1);
			_cards[1] = stringToInt(card2);
			_cards[2] = stringToInt(card3);
			_cards[3] = stringToInt(card4);
		}
	}

}
