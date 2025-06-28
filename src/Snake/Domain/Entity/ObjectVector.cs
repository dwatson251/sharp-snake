class ObjectVector
{
    void ObjectVector()
    {
        this.x = 0;
        this.y = 0;
    }

    void ObjectVector(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    ObjectVector SetVector(int x, int y)
    {
        this.setX = x;
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