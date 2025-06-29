namespace Snake.Domain.Entity
{
    class GameState
    {
        Snake _snake;
        Score _score;
        Time _time;

        public GameState(
            Snake snake,
            Score score,
            Time time
        )
        {
            _snake = snake;
            _score = score;
            _time = time;
        }
    }
}