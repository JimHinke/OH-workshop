using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OPC_17._1
{
    public class Card
    {
        private int value;
        private string suit;
        public Card(int value, string suit)
        {
            this.value = value;
            this.suit = suit;
        }
    }
    public class Deck
    {
        private List<Card>? cards;
        private Random rnd;


        public Deck()
        {
            string[] suits = { "Hearts", "Spades", "Diamonds", "Clubs" };
            foreach (string suit in suits)
            {
                for (int i = 1; i <= 13; i++)
                {
                    cards.Add(new Card(i, suit));
                }
            }
        }
        public Card DrawCard()
        {
            int i = rnd.Next(cards.Count());
            Card card = cards[i];
            cards.RemoveAt(i);
            return card;
        }
    }
}
