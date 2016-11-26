using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPoker.Controler
{
    public interface ISuperPokerSolver
    {
        string Solve(int card1, int card2, int card3, int card4);
    }
}
