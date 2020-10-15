using System;
using System.Collections.Generic;
using static System.Math;

namespace BlackJackAlgo
{
    public class Deck
    {
        /// <summary>
        /// this class will fill in a deck of cards.
        /// Reference: Stack Overflow forum  question
        /// confession: Shamelessly stolen
        /// Date made was 10/13/2020
        /// </summary>
        public List<Card> Cards = new List<Card>();

        public void FillDeck()
        {
            void FillDeck()
            {
                //Using a single loop utilising the mod operator % and Math.Floor
                //Using divitation base on 13 cards in a suited
                for (int i = 0; i < 52; i++)
                {
                    Card.Suites suite = (Card.Suites) (Math.Floor((decimal) i / 13));
                    //add 2 to value as card decks start at 2
                    int val = i % 13 + 2;
                    Cards.Add(new Card(val, suite));
                }
            }
        }

        public void PrintDeck()
        {
            /*
             * method to print out a deck of cards. It'll be used to deal the cards
             */
            foreach (Card card in this.Cards)
            {
                Console.WriteLine(card.Name);
            }
        }
    }

    public interface IBlackJack
    {
        
        
    }
}