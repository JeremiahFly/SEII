using System.Collections.Generic;
using Newtonsoft.Json;

namespace SuperPoker.Model
{
    public class Deck
    {
        public List<Card> Cards { get; set; }
    }

    public class Card
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }
}
