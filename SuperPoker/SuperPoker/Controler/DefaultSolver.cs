using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPoker.Controler
{
    public class DefaultSolver : SearchMethod
    {
        private Cards cards;

        public void acceptInput(Cards cards)
        {
            cards = this.cards;
        }

        public string receiveOutput()
        {
            return "card1=" + cards.getCard(1) + ", card2=" + cards.getCard(2) + ", card3=" + cards.getCard(3) +
                   ", card4=" + cards.getCard(4);
        }

        public void search()
        {
            //do nothing we are just printing out cards
        }
    }
}
