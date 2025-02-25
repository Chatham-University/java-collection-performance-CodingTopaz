namespace CollectionChallenge;

public class ArrayDemo
{
    private int[] nums;

    public ArrayDemo(int numscount, Random rand)
    {
        nums = new int[numscount];
        for (int i = 0; i < numscount; i++)
        {
            nums[i] = rand.Next(numscount);
        }
        
    }
}