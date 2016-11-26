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

        public MainControler(IMainView view)
        {
            this.view = view;
            comunicator = new ServerCommunicator();
        }

        public void SolveServer()
        {
            
        }

        public void ManualSolve(int card1, int card2, int card3, int card4)
        {
            
        }


        private void printOutput(string s)
        {
            view.SetOutput(s);
        }

    }

    public interface IMainView
    {
        void SetOutput(String output);
    }
}
