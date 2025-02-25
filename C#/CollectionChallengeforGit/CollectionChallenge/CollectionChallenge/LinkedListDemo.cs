namespace CollectionChallenge;

public class LinkedListDemo
{
    private LinkedList<int> nums;
    public LinkedListDemo(int howManyNums, Random rand)
    {
        nums = new LinkedList<int>();
        for (int i = 0; i < howManyNums; i++)
        {
            nums.AddLast(rand.Next(howManyNums));
        }
    }
}