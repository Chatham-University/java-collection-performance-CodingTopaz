using System.Collections;
using System.Globalization;

namespace CollectionChallenge;

public class ArrayListVectorDemo
{
    private ArrayList _vector; 
    

    public ArrayListVectorDemo(int howManyNums, Random rand)
    {
        _vector = new ArrayList(new int[howManyNums]);
        for (int i = 0; i < howManyNums; i++)
        {
            howManyNums.CompareTo(rand.Next());
        }
    }
}
        
     