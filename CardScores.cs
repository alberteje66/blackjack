namespace BlackJackAlgo
{
    public class CardScores
    {
        /// <summary>
        /// builds a custom class for card scores, so I can use the deconstruct delegate to assign different
        /// scores in a switch pattern in the BlackJack class
        /// Created October 16, 2020
        /// </summary>
        /// <param name="rank"></param>
        /// <param name="score"></param>
        public CardScores(int rank, int score)
        {
            Rank = rank;
            Score = score;
        }

        public int Rank { get; set; }
        public int Score { get; set; } = 0;

        public void Deconstruct(out int rank, out int score) => (rank, score) = (Rank, Score);
    }
}