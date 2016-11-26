using System.Collections.Generic;
using Ringmaster.Models;
using System.Linq;
using System;

namespace Ringmaster.Service
{
    public class SuperPokerService
    {
        private static Game Game { get; set; }

        public void AddPlayer(string hostName)
        {
            var game = this.GetCurrentGame();

            game.AddPlayer(hostName);
        }

        public SuperPokerDeck GameStart()
        {
            // Return deck when all players are ready

            return this.GetCurrentGame().GetGameDeck();
        }

        private Game GetCurrentGame()
        {
            if (Game == null) Game = new Game();
            return Game;
        }

        public void SetCurrentDeck(SuperPokerDeck newDeck)
        {
            if (Game == null) Game = new Game();
            Game.SetGameDeck(newDeck);
        }

        private CardValue ConvertToCardvalue(int c1)
        {
            switch (c1)
            {
                case 1:
                    return CardValue.Ace;
                case 2:
                    return CardValue.Two;
                case 3:
                    return CardValue.Three;
                case 4:
                    return CardValue.Four;
                case 5:
                    return CardValue.Five;
                case 6:
                    return CardValue.Six;
                case 7:
                    return CardValue.Seven;
                case 8:
                    return CardValue.Eight;
                case 9:
                    return CardValue.Nine;
                case 10:
                    return CardValue.Ten;
                case 11:
                    return CardValue.Jack;
                case 12:
                    return CardValue.Queen;
                case 13:
                    return CardValue.King;
                default:
                    throw new Exception("Attempted to create card without value");
            }
        }
    }
}
