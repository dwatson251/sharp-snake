namespace Engine.Domain.Entity;

private class GameObject
{
    GameObject(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    int GetX()
    {
        return this.x;
    }

    int GetY()
    {
        return this.y;
    }
}