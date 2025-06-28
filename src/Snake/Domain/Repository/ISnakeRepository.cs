namespace Snake.Domain.Repository;

interface ISnakeRepository
{
    Snake GetSnake();
    void SetDirection(Direction direction);
    void Move();
}