using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPoker.Controler
{
    public class DefaultSolver : ISuperPokerSolver
    {

        /// <summary>
        /// Solves the 4 cards for superpoker
        /// </summary>
        /// <param name="card1">value of first card</param>
        /// <param name="card2">value of second card</param>
        /// <param name="card3">value of third card</param>
        /// <param name="card4">value of fourth card</param>
        /// <returns>String of a correct answer to the game or stating no solotion</returns>
        public string Solve(int card1, int card2, int card3, int card4)
        {
            //for Paul
            throw new NotImplementedException();
        }
    }
}
