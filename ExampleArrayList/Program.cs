public class Program
{
    public static void Main(string[] args)
    {
        List<String> myList = new List<String>();
        myList.Add("Orange");
        myList.Add("Banana");
        myList.Add("Mango");

        foreach (String s in myList)
        {
            Console.WriteLine(s);
        }

        for (int i = 0; i < myList.Count; i++)
        {
            Console.WriteLine(myList[i]);
        }
    }   
}