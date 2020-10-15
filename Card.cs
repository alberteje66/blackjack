using System;

namespace BlackJackAlgo
{
    /// <summary>
    /// class designed to create cards
    /// made 10/12/2020 22:08 EDT
    /// </summary>
    public class Card
    {
        public enum Suites
        {
            Hearts = 0,
            Diamonds,
            Clubs,
            Spades
        }

        public int Rank { get; set; }

        public Suites Suite { get; set; }

        private Random _random;
        /*
         * The above sets the properties: enum for the suites, and the Rank for the card ranks
         * the next property is used to get the name value
         */
        
        //default constructor
        public Card()
        {
            
        }
        

        public string NamedValue
        {
            get
            {
                string name = String.Empty;
                switch (Rank)
                {
                    case(14):
                        name = "Ace";
                        break;
                    case(13):
                        name = "King";
                        break;
                    case(12) :
                        name = "Queen";
                        break;
                    case(11):
                        name = "Jack";
                        break;
                    default:
                        name = Rank.ToString();
                        break;
                }

                return name;
            }
            
        }

        public string Name
        {
            get
            {
                return NamedValue + " of " + Suite.ToString();
            }
        }
        
        //constructor for dealing random cards

        public Card(int Rank, Suites suite)
        {
            this.Rank = Rank;
            this.Suite = suite;

        }

    }
}