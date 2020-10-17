using System;
using System.Collections.Generic;
using System.Windows.Markup;

namespace BlackJackAlgo
{
    public class BlackJack : IBlackJack
    {
        public const int MaxScore = 21;
        protected Deck PlayingDeck = new Deck();
        public List<Card> PlayerHand { get; set; }

        public List<Card> DealerHand { get; set; }
        //Random _random = new Random();

        private Card _card = new Card();
        public int CardRank { get; set; }
        public int CardScore => 0;

        public BlackJack()
        {
            CardRank = _card.Rank;

        }

        public void NewGame()
        {
            PlayingDeck.FillDeck();
            DealPlayer();

        }

        private void DealPlayer()
        {
            Random random = new Random();
            Type type = typeof(Card.Suites);
            Array values = type.GetEnumValues();
            int index = random.Next(values.Length);
            Card.Suites Suites = (Card.Suites) values.GetValue(index);
            PlayerHand = new List<Card>(5);
            PlayerHand.Add(new Card(random.Next(13), Suites));
            PlayerHand.Add(new Card(random.Next(13), Suites));

            foreach (Card card in PlayerHand)
            {
                Console.WriteLine(card.Name);
                if (card.Name == null)
                {
                    Console.WriteLine("Empty");
                }
            }
        }

        private void DealDealer()
        {
            Random random = new Random();
            Type type = typeof(Card.Suites);
            Array values = type.GetEnumValues();
            int index = random.Next(values.Length);
            Card.Suites Suites = (Card.Suites) values.GetValue(index);
            DealerHand = new List<Card>(5);
            DealerHand.Add(new Card(random.Next(13), Suites));
            DealerHand.Add(new Card(random.Next(13), Suites));
            DealerHand.Add(new Card(random.Next(13), Suites));
            DealerHand.Add(new Card(random.Next(13), Suites));
            DealerHand.Add(new Card(random.Next(13), Suites));
            //DealerHand.Add(new Card(random.Next(13), Suites));

            foreach (Card card in DealerHand)
            {
                Console.WriteLine(card.Name);
                if (card.Name == null)
                {
                    Console.WriteLine("Empty");
                }
            }
        }
        
        //going to use patterns to determine the scores for cards
        /// <summary>
        /// added on October 16, 2020
        /// Scoring rules: 2-10 have their Card ranks as scores, J-K are worth 10, Ace is worth 1 or 11 depending on the score already
        /// </summary>
        /// <param name="cardScores"></param>
        /// <returns></returns>
        public static int CardScores(CardScores cardScores) => cardScores switch
        {
            var (rank, score) when rank == 2 => score +=2,
            {Rank: 3} => cardScores.Score +=3,
            {Rank: 4} => cardScores.Score +=4,
            {Rank: 5} => cardScores.Score +=5,
            {Rank: 6} => cardScores.Score +=6,
            {Rank: 7} => cardScores.Score +=7,
            {Rank: 8} => cardScores.Score +=8,
            {Rank: 9} => cardScores.Score +=9,
            {Rank: 10} => cardScores.Score +=10,
            {Rank: 11} => cardScores.Score +=10,
            {Rank: 12} => cardScores.Score +=10,
            {Rank: 13} => cardScores.Score +=10,
            {Rank: 14} =>  cardScores.Score >= 10 ? cardScores.Score +=11 : cardScores.Score +=1
        };

        /*public void Deconstruct(out int rank, out int score) => (rank, score) = (CardRank, CardScore);

        public static int Scores(int rank)
        {
            rank switch
            {
                null => throw new NotImplementedException(),
                var (rank, score) when rank == 2 => 2,
                {rank: 3} => sc = 3,
                _ => throw new ArgumentOutOfRangeException(nameof(card));
            };
        }*/

        /*public void Scores()
        {
            Score Totalscore = () => 0;
            int totalscore = 0;
            foreach (Card card in PlayerHand)
            {
                int rank = card.Rank;

                switch (rank)
                {
                    case 2:
                        Totalscore = () => totalscore+2;
                        break;
                    case 3:
                        Totalscore = () => totalscore + 3;
                        break;
                    case 4:
                        Totalscore = () => totalscore + 4;
                        break;
                    case 5:
                        Totalscore = () => totalscore + 5;
                        break;
                    
                }
            }
        }*/
    }
}