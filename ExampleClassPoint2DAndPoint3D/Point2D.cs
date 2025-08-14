public class Point2D
{
    private float x = 0.0f;
    private float y = 0.0f;

    public Point2D(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public Point2D()
    {
    }

    public float GetX()
    {
        return x;
    }

    public void SetX(float value)
    {
        x = value;
    }

    public float GetY()
    {
        return y;
    }

    public void SetY(float value)
    {
        y = value;
    }

    public void SetXY(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public float[] GetXY()
    {
        float[] coordinates = new float[2];
        coordinates[0] = x;
        coordinates[1] = y;
        return coordinates;
    }

    public override string ToString()
    {
        return $"Point2D({x}, {y})";
    }
}