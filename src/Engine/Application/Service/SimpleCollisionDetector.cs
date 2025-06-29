namespace Engine.Application.Service
{
    using Engine.Domain.Service;
    using Engine.Domain.Entity;

    class SimpleCollisionDetector : ICollisionDetector
    {
        public bool HasCollided(GameObject target, GameObject intersector)
        {
            return target.GetX() == intersector.GetX()
                && target.GetY() == intersector.GetY();
        }
    }
}