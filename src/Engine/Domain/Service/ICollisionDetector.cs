namespace Engine.Domain.Service
{
    using Engine.Domain.Entity;
    
    interface ICollisionDetector
    {
        bool HasCollided(GameObject target, GameObject intersector);
    }
}