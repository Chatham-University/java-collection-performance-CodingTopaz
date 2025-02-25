using System.Collections;
namespace CollectionChallenge;

public class HashSetDemo
{
    private HashSet<int> hashSetNumber;

    public HashSetDemo(int howmany, Random rand)
    {
        hashSetNumber = new HashSet<int>();
        for (int i = 0; i < howmany; i++)
        {
            hashSetNumber.Add(rand.Next(howmany));
        }
     
    }
    
}
    