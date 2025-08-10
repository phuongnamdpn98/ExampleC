public class Decoder
{
    protected string Input;

    public Decoder(string input)
    {
        Input = input;
    }

    public virtual string Decode()
    {
        return Input;
    }

    public virtual void DisplayDecodedInfo()
    {
        Console.WriteLine($"Decoded Output: {Input}");
    }
}