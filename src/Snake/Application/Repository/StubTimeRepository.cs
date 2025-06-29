namespace Snake.Application.Repository
{
    using Snake.Domain.Repository;
    using Snake.Domain.Entity;

    class StubTimeRepository : ITimeRepository
    {
        public Time GetGameTime()
        {
            return new Time(120);
        }
    }
}