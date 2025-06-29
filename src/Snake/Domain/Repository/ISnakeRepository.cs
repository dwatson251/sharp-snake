namespace Snake.Domain.Repository
{
    using Snake.Domain.Entity;

    interface ISnakeRepository
    {
        Snake GetSnake();
        void Move();
    }
}