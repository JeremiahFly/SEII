using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPoker.Controler
{
    public class MainControler
    {
        private IMainView view;
        private ServerCommunicator comunicator;
        private ISuperPokerSolver solver;

        public MainControler(IMainView view)
        {
            this.view = view;
            comunicator = new ServerCommunicator();
            solver = new DefaultSolver();
        }

        public void SolveServer()
        {
            List<int> cards = comunicator.GetCardsFromServer().ToList();
            printOutput(solver.Solve(cards[0], cards[1], cards[2], cards[3]));
        }

        public void ManualSolve(int card1, int card2, int card3, int card4)
        {
            printOutput(solver.Solve(card1,card2,card3,card3));
        }


        private void printOutput(string s)
        {
            view.SetOutput(s);
        }

    }

    public interface IMainView
    {
        void SetOutput(string output);
    }
}
