using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace OPC_17._1
{
    public abstract class Player
    {   
        public string? Name { get; set; }
        public int Balance { get; set; }
        public int SumCard { get; set; }
        public List<Card>? Hand { get; set; }

        public Player() { }
    }
    public class HumanPlayer : Player
    {
        public HumanPlayer(string name, int balance)
            : base()
        {
            Name = name;
            Balance = balance;
            SumCard = 0;
            Hand = new List<Card>();
        }
        public void DrawCard()
        {

        }
        public void Pass()
        {

        }
        public void ShowHand()
        {

        }
        public void Bet()
        {

        }
    }
    public class ComputerDealer : Player
    {
        public ComputerDealer()
            : base()
        {
            Name = "Dealer";
            Balance = 10000;    // ??
            SumCard = 0;
            Hand = new List<Card>();
        }
        public void DrawCard()
        {

        }
        public void Pass()
        {

        }
        public void ShowHand()
        {

        }
        public void Bet()
        {

        }
    }
}
