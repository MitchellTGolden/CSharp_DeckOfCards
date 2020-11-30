using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Card
    {
        public string stringVal;
        public string suit;
        // Foods can be Spicy and/or Sweet
        public int val;
        public Card(string sv, string s, int v)
        {
            stringVal = sv;
            suit = s;
            val = v;
        }
    }
    class Deck
    {
        public static Random rand = new Random();

        public List<Card> Cards;

        public Deck()
        {
            Cards = new List<Card>()
            {
            new Card("Ace", "Spades", 1),
            new Card("2", "Spades", 2),
            new Card("3", "Spades", 3),
            new Card("4", "Spades", 4),
            new Card("5", "Spades", 5),
            new Card("6", "Spades", 6),
            new Card("7", "Spades", 7),
            new Card("8", "Spades", 8),
            new Card("9", "Spades", 9),
            new Card("10", "Spades", 10),
            new Card("Jack", "Spades", 11),
            new Card("Queen", "Spades", 12),
            new Card("King", "Spades", 13),
            new Card("Ace", "Clubs", 1),
            new Card("2", "Clubs", 2),
            new Card("3", "Clubs", 3),
            new Card("4", "Clubs", 4),
            new Card("5", "Clubs", 5),
            new Card("6", "Clubs", 6),
            new Card("7", "Clubs", 7),
            new Card("8", "Clubs", 8),
            new Card("9", "Clubs", 9),
            new Card("10", "Clubs", 10),
            new Card("Jack", "Clubs", 11),
            new Card("Queen", "Clubs", 12),
            new Card("King", "Clubs", 13),
            new Card("Ace", "Hearts", 1),
            new Card("2", "Hearts", 2),
            new Card("3", "Hearts", 3),
            new Card("4", "Hearts", 4),
            new Card("5", "Hearts", 5),
            new Card("6", "Hearts", 6),
            new Card("7", "Hearts", 7),
            new Card("8", "Hearts", 8),
            new Card("9", "Hearts", 9),
            new Card("10", "Hearts", 10),
            new Card("Jack", "Hearts", 11),
            new Card("Queen", "Hearts", 12),
            new Card("King", "Hearts", 13),
            new Card("Ace", "Diamonds", 1),
            new Card("2", "Diamonds", 2),
            new Card("3", "Diamonds", 3),
            new Card("4", "Diamonds", 4),
            new Card("5", "Diamonds", 5),
            new Card("6", "Diamonds", 6),
            new Card("7", "Diamonds", 7),
            new Card("8", "Diamonds", 8),
            new Card("9", "Diamonds", 9),
            new Card("10", "Diamonds", 10),
            new Card("Jack", "Diamonds", 11),
            new Card("Queen", "Diamonds", 12),
            new Card("King", "Diamonds", 13)
            };
        }
        public void Deal(Player guy)
        {
            // Console.Write($"\nThe top card is the {Cards[this.Cards.Count - 1].stringVal} of {Cards[this.Cards.Count - 1].suit}");
            guy.Hand.Add(this.Cards[this.Cards.Count - 1]);
            this.Cards.Remove(Cards[this.Cards.Count - 1]);
        }
        public void ListDeck()
        {
            foreach (var card in this.Cards)
            {
                Console.WriteLine($"{card.stringVal} of {card.suit}");
            }
        }
        public void Reset()
        {

            Deck newDeck = new Deck();
            this.Cards = newDeck.Cards;
        }
        public void Shuffle()
        {
            for (int i = 0; i < this.Cards.Count; i++)
            {
                var temp = this.Cards[i];
                int randomIndex = rand.Next(i, this.Cards.Count);
                this.Cards[i] = this.Cards[randomIndex];
                this.Cards[randomIndex] = temp;
            }
        }

    }
    class Player
    {
        public string Name;
        public List<Card> Hand;
        public Player(string name)
        {
            Name = name;
            Hand = new List<Card>();
        }
        public void listHand()
        {
            Console.WriteLine($"\nCurrently {this.Name} has:");
            foreach (var card in this.Hand)
            {
                Console.Write($" {card.stringVal} of {card.suit} ");

            }
        }
        public void Draw(Deck yeet)
        {
            this.Hand.Add(yeet.Cards[yeet.Cards.Count - 1]);
            yeet.Cards.Remove(yeet.Cards[yeet.Cards.Count - 1]);
        }

        public void Discard(Card disOne)
        {
            this.Hand.Remove(disOne);
        }
    }
    static class Program
    {
        static void Main(string[] args)
        {


            Deck newDeck = new Deck();
            Player mitchell = new Player("Mitchell");
            Player adrien = new Player("Adrien");
            newDeck.Shuffle();
            newDeck.ListDeck();
            newDeck.Deal(mitchell);
            newDeck.Deal(adrien);
            newDeck.Deal(mitchell);
            newDeck.Deal(adrien);
            newDeck.Deal(mitchell);
            newDeck.Deal(adrien);
            newDeck.Deal(mitchell);
            newDeck.Deal(adrien);
            newDeck.Deal(mitchell);
            newDeck.Deal(adrien);
            mitchell.listHand();
            adrien.listHand();

            newDeck.ListDeck();
            newDeck.Reset();
            newDeck.ListDeck();

            mitchell.Draw(newDeck);
            mitchell.listHand();
            mitchell.Discard(mitchell.Hand[0]);
            mitchell.listHand();




        }
    }
}

