namespace CollectionChallenge;

public class LinkedListDemo
{
    private LinkedList<int> nums; //original empty linked list
    public LinkedListDemo(int howManyNums/*how many loops*/, Random rand)
    {
        nums = new LinkedList<int>(); // new linked list
        for (int i = 0; i < howManyNums; i++) // for i in range(4)
        {
            nums.AddLast(rand.Next(howManyNums)); //add a random element into the new test
        }
    }
}