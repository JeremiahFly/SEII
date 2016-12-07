using System.Collections.Generic;
using System.Linq;

namespace SuperPoker.Controler
{
    public class MainController
    {
        private IMainView view;
        private ServerCommunicator communicator;
        private SearchMethod solver;

        public MainController(IMainView view)
        {
            this.view = view;
            communicator = new ServerCommunicator();
            
        }

        public void SolveServer()
        {
            solver = new DFS();
            List<int> cards = communicator.GetCardsFromServer().ToList();
            string c1 = cards[0] + "";
            string c2 = cards[1] + "";
            string c3 = cards[2] + "";
            string c4 = cards[3] + "";
            solver.acceptInput(new Cards(c1,c2,c3,c4));
            solver.search();
            PrintOutput(solver.receiveOutput());
        }

        public void ManualSolve(int card1, int card2, int card3, int card4)
        {
            solver = new DFS();
            solver.acceptInput(new Cards(card1+"", card2 + "", card3 + "", card4 + ""));
            solver.search();
            PrintOutput(solver.receiveOutput());
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
