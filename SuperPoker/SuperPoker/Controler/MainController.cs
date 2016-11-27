using System.Collections.Generic;
using System.Linq;

namespace SuperPoker.Controler
{
    public class MainController
    {
        private IMainView view;
        private ServerCommunicator communicator;
        private ISuperPokerSolver solver;

        public MainController(IMainView view)
        {
            this.view = view;
            communicator = new ServerCommunicator();
            solver = new DefaultSolver();
        }

        public void SolveServer()
        {
            List<int> cards = communicator.GetCardsFromServer().ToList();
            PrintOutput(solver.Solve(cards[0], cards[1], cards[2], cards[3]));
        }

        public void ManualSolve(int card1, int card2, int card3, int card4)
        {
            PrintOutput(solver.Solve(card1,card2,card3,card3));
        }


        private void PrintOutput(string s)
        {
            view.SetOutput(s);
        }

    }

    public interface IMainView
    {
        void SetOutput(string output);
    }
}
