
class StubSnakeRepository : SnakeRepositoryInterface
{
    Snake GetSnake()
    {
        return new Snake([
            new Cell(0, 0),
            new Cell(1, 0),
            new Cell(1, 1),
            new Cell(2, 1),
            new Cell(2, 2),
            new Cell(3, 2),
            new Cell(3, 3),
        ]);
    }

    void SetDirection(Direction direction)
    {
        return;
    }

    void Move()
    {
        return;
    }
}