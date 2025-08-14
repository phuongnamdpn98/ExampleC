public class Square : Rectangle
{
    public Square()
    {
    }

    public Square(double slide) : base(slide, slide)
    {
    }

    public Square(double slide, string color, bool filled) : base(slide, slide, color, filled)
    {
    }

    public double GetSlide()
    {
        return GetWidth(); // Since width and height are the same in a square
    }

    public void SetSize(double slide)
    {
        SetWidth(slide);
        SetHeight(slide);
    }
    public override void SetHeight(double height)
    {
        SetSize(height);
    }
    public override void SetWidth(double width)
    {
        SetSize(width);
    }

    
}
