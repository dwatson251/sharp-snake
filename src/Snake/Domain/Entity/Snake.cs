namespace Snake.Domain.Entity
{
    using System.Collections.Generic;
    using System.Linq;

    public class Snake
    {
        private List<Cell> _cells;
        private Direction _direction;

        public Snake()
        {
            _direction = Direction.Right;
            _cells = new List<Cell>{
                new Cell(),
                Cell.CreateDigestingCell(),
                Cell.CreateDigestingCell(),
                Cell.CreateDigestingCell(),
                Cell.CreateDigestingCell(),
            };
        }

        public Snake(List<Cell> cells)
        {
            _direction = Direction.Right;
            _cells = cells;
        }

        public Snake SetDirection(Direction direction)
        {
            _direction = direction;
            return this;
        }

        public List<Cell> GetCells()
        {
            return _cells;
        }

        public Snake AddCell()
        {
            Cell firstCell = _cells[0];
            _cells.Add(
                Cell.CreateDigestingCell(
                    firstCell.GetX(),
                    firstCell.GetY()
                )
            );
            return this;
        }

        public Snake Move()
        {
            List<Cell> nonDigestingCells = GetNonDigestingCells();
            Cell tailCell = nonDigestingCells[nonDigestingCells.Count - 1];
            List<Cell> digestingCells = GetDigestingCells();
            Cell targetDigestingCell = null;
            foreach (Cell digestingCell in digestingCells)
            {
                if (digestingCell.GetX() == tailCell.GetX() && digestingCell.GetY() == tailCell.GetY())
                {
                    targetDigestingCell = digestingCell;
                    // Only one cell can digest at a time.
                    break;
                }
            }

            targetDigestingCell?.SetWillDigestSoon();

            Cell previousCellState = nonDigestingCells[0].Clone();
            for (int i = 0; i < nonDigestingCells.Count; i++)
            {
                bool isFirstCell = i == 0;
                Cell cell = nonDigestingCells[i];

                if (isFirstCell)
                {
                    if (_direction == Direction.Up)
                        cell.MoveUp();

                    if (_direction == Direction.Down)
                        cell.MoveDown();

                    if (_direction == Direction.Left)
                        cell.MoveLeft();

                    if (_direction == Direction.Right)
                        cell.MoveRight();

                    continue;
                }



                cell.SetVector(
                    previousCellState.GetX(),
                    previousCellState.GetY()
                );
                
                previousCellState = cell.Clone();
            }

            if (targetDigestingCell?.WillDigestSoon() ?? false)
            {
                targetDigestingCell.FinishDigesting();
            }

            return this;
        }

        private List<Cell> GetNonDigestingCells()
        {
            return _cells.Where(cell => !cell.IsDigesting()).ToList();
        }

        private List<Cell> GetDigestingCells()
        {
            return _cells.Where(cell => cell.IsDigesting()).ToList();
        }
    }
}