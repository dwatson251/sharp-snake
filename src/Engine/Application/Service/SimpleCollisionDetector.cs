namespace Engine.Application.Service;

class SimpleCollisionDetector : CollisionDetectorInterface
{
    bool HasCollided(GameObject target, GameObject intersector)
    {
        return target.GetX() == intersector.GetX()
            && target.GetY() == intersector.GetY();
    }
}