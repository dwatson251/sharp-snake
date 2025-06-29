namespace Snake.Domain.Entity
{
    public class Time
    {
        private readonly int _timeInSeconds;

        public Time()
        {
            _timeInSeconds = 0;
        }

        public Time(int initialTimeInSeconds)
        {
            _timeInSeconds = initialTimeInSeconds;
        }

        public int GetSeconds()
        {
            return _timeInSeconds;
        }
    }
}