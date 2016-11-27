using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using SuperPoker.Model;

namespace SuperPoker.Controler
{
    public class ServerCommunicator
    {
        private const string ConnectionString = "http://seiisuperpoker.azurewebsites.net/api/SuperPoker";

        /// <summary>
        /// Talks to the server and gets the cards from it
        /// </summary>
        /// <returns>an array or list of the cards from the server should have size of 4</returns>
        public IEnumerable<int> GetCardsFromServer()
        {
            //For David
            
            using (var webClient = new HttpClient())
            {
                var task = webClient.GetStringAsync(ConnectionString);
                var deck = JsonConvert.DeserializeObject<Deck>(task.Result);
                return deck.Cards.Select(card => card.Value);
            }
        }
    }
}
