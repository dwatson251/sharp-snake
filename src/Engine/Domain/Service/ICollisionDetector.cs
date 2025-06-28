namespace Engine.Domain.Service;

private interface ICollisionDetector
{
    bool HasCollided(GameObject target, GameObject intersector);
}