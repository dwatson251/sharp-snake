namespace Game.Application.Repository
{
    using Snake.Domain.Repository;
    using Snake.Domain.Entity;
    
    class StubScoreRepository : IScoreRepository
    {
        public Score GetScore()
        {
            return new Score(123);
        }
    }
}
