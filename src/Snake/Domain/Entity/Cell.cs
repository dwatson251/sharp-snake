namespace Snake.Domain.Entity
{
    public class Cell : ObjectVector
    {
        private bool _isDigesting = false;
        private bool _willDigestSoon = false;

        public Cell() : base() { }

        public Cell(int x, int y) : base(x, y) { }

        public static Cell CreateDigestingCell()
        {
            Cell cell = new Cell();
            cell._isDigesting = true;
            return cell;
        }

        public static Cell CreateDigestingCell(int x, int y)
        {
            Cell cell = new Cell(x, y);
            cell._isDigesting = true;
            return cell;
        }

        public bool IsDigesting()
        {
            return _isDigesting;
        }

        public Cell FinishDigesting()
        {
            _isDigesting = false;
            _willDigestSoon = false;
            return this;
        }

        public Cell MoveUp()
        {
            _y = _y + 1;
            return this;
        }

        public Cell MoveDown()
        {
            _y = _y - 1;
            return this;
        }

        public Cell MoveLeft()
        {
            _x = _x - 1;
            return this;
        }

        public Cell MoveRight()
        {
            _x = _x + 1;
            return this;
        }

        public Cell SetWillDigestSoon()
        {
            _willDigestSoon = true;
            return this;
        }

        public bool WillDigestSoon()
        {
            return _willDigestSoon;
        }

        public Cell Clone()
        {
            return new Cell(_x, _y);
        }
    }
}