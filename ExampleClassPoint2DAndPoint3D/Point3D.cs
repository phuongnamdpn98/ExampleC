public class Point3D : Point2D
{
    private float z = 0.0f;

    public Point3D(float x, float y, float z) : base(x, y)
    {
        this.z = z;
    }

    public Point3D() : base()
    {
    }

    public float GetZ()
    {
        return z;
    }

    public void SetZ(float value)
    {
        z = value;
    }

    public void SetXYZ(float x, float y, float z)
    {
        SetXY(x, y);
        this.z = z;
    }

    public float[] GetXYZ()
    {
        float[] coordinates = new float[3];
        coordinates[0] = GetX();
        coordinates[1] = GetY();
        coordinates[2] = z;
        return coordinates;
    }

    public override string ToString()
    {
        return $"Point3D({GetX()}, {GetY()}, {z})";
    }
}