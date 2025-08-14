public class Shape
{
    private string color = "Green";
    private bool filled = true;
    public Shape()
    {

    }

    public Shape(string color, bool filled)
    {
        this.color = color;
        this.filled = filled;
    }

    public string GetColor()
    {
        return this.color;
    }

    public void SetColor(string color)
    {
        this.color = color;
    }

    public bool IsFilled()
    {
        return this.filled;
    }

    public void SetFilled(bool filled)
    {
        this.filled = filled;
    }
    
    public override string ToString()
    {
        return $"GetColor color={color}, filled={filled}]";
    }
}