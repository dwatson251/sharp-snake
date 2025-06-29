namespace Snake.Domain.Entity
{
    public class ObjectVector
    {
        protected int _x;
        protected int _y;

        public ObjectVector()
        {
            _x = 0;
            _y = 0;
        }

        public ObjectVector(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public ObjectVector SetVector(int x, int y)
        {
            _x = x;
            _y = y;
            return this;
        }

        public int GetX()
        {
            return _x;
        }

        public int GetY()
        {
            return _y;
        }
    }
}