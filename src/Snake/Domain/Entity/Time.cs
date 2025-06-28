class Time
{
    Time()
    {
        this.timeSeconds = 0;
    }

    Time(int initialTimeInSeconds)
    {
        this.timeSeconds = initialTimeInSeconds;
    }

    int GetSeconds()
    {
        return this.timeSeconds;
    }
}