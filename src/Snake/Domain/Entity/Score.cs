namespace Snake.Domain.Entity
{
    public class Score
    {
        private readonly int _score;

        public Score()
        {
            _score = 0;
        }

        public Score(int initialScore)
        {
            _score = initialScore;
        }

        int GetValue()
        {
            return _score;
        }
    }
}