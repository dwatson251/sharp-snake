namespace Snake.Domain.Repository
{
    using Snake.Domain.Entity;
    
    interface ITimeRepository
    {
        Time GetGameTime();
    }
}