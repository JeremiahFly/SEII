using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPoker.Controler
{
    public class ServerCommunicator
    {
        private string connectionString = "http://seiisuperpoker.azurewebsites.net/api/SuperPoker";

        public ServerCommunicator() { }


        /// <summary>
        /// Talks to the server and gets the cards from it
        /// </summary>
        /// <returns>an array or list of the cards from the server should have size of 4</returns>
        public IEnumerable<int> GetCardsFromServer()
        {
            //For David
            //temp methoid feel free to comment or delete for real implimentation
            var temp =  new List<int>();
            temp.Add(12);
            temp.Add(2);
            temp.Add(13);
            temp.Add(13);
            return temp;
        }
    }
}
