namespace Snake.Application.Repository;
class StubScoreRepository : ScoreRepositoryInterface
{
    Score GetScore()
    {
        return new Score(123);
    }
}