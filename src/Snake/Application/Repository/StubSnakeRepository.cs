namespace Snake.Application.Repository
{
    using Snake.Domain.Repository;
    using Snake.Domain.Entity;
    using SnakeEntity = Snake.Domain.Entity.Snake;
    using System.Collections.Generic;
    
    public class StubSnakeRepository : ISnakeRepository
    {
        public SnakeEntity GetSnake()
        {
            return new SnakeEntity(new List<Cell>{
                new Cell(0, 0),
                new Cell(1, 0),
                new Cell(1, 1),
                new Cell(2, 1),
                new Cell(2, 2),
                new Cell(3, 2),
                new Cell(3, 3),
            });
        }

        public void Move()
        {
            return;
        }
    }
}