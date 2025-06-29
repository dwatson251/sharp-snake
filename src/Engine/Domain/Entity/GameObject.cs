namespace Engine.Domain.Entity
{
    public class GameObject
    {
        private int _x;
        private int _y;

        public GameObject(int x, int y)
        {
            _x = x;
            _y = y;
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