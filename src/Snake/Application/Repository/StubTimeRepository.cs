namespace Snake.Application.Repository;

class StubTimeRepository : TimeRepositoryInterface
{
    Time GetGameTime()
    {
        return new Time(120);
    }
}