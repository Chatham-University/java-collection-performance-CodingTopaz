namespace CollectionChallenge;

public class ListDemo
{
    private List<int> numbers;
    
    public ListDemo(int howmany,Random random)
    {
        numbers = new List<int>();
        for (int i = 0; i < howmany; i++)
        {
            numbers.Add(random.Next(howmany));
        }
    }
}