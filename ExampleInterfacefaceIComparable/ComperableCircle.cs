public class ComperableCircle : Circle, IComparable<ComperableCircle>
{
    public ComperableCircle()
    {
    }
    public ComperableCircle(double radius) : base(radius)
    {
    }

    public ComperableCircle(double radius, string color, bool isfilled) : base(radius, color, isfilled)
    {
    }

    public int CompareTo(ComperableCircle other)
    {
        if(GetRadius() > other.GetRadius())
        {
            return 1; 
        }
        else if(GetRadius() < other.GetRadius())
        {
            return -1; 
        }
        else
        {
            return 0; 
        }
    }

}