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

        public BlackJack()
        {
            
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
        
        public static void CardValues{
          //int score =1;
          int totalscore =0;
          foreach(Card card in PlayingDeck){
            switch(card.Rank){
              case 2:
                Func<int> () => totalscore+2;
                break;
              
              case 3:
                Func<int> () => totalscore+13;
                break;
               
               case 4:
                Func<int> () => totalscore+4;
              
              case 14:
                if(totalscore >= 10){
                  Func<int> () => totalscore+1;
                } else {
                  Func<int> () => totalscore+11;
                }
                break;
              
              default: 
              score = 0;
              break;
            }
            totalscore += score;
          }
        }

    }
}