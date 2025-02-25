
using System.Collections;
using System.Diagnostics;
using CollectionChallenge;
using System.Numerics;

Stopwatch stopwatch = new Stopwatch();

Random rand = new Random();
int num =  (int)Math.Pow(10, 5);
stopwatch.Start();
var arraydemo = new ArrayDemo(num,rand);
stopwatch.Stop();
Console.WriteLine("did arraydemo in "+stopwatch.Elapsed);

stopwatch.Restart();
var linkedListDemo = new LinkedListDemo(num, rand);
stopwatch.Stop();
Console.WriteLine("did linkedlistdemo in "+stopwatch.Elapsed);



var regularListDemo = new ListDemo(num, rand);
ListDemo(num, rand);
stopwatch.Stop();
Console.WriteLine("did regular list in "+stopwatch.Elapsed);

var ArrayListVectorDemo = new ArrayListVectorDemo(num, rand);
stopwatch.Stop();
Console.WriteLine("did ArrayList in "+stopwatch.Elapsed);

void ListDemo(int howmany, Random random)
{
    List<int> numbers = new List<int>();
    for (int i = 0; i < howmany; i++)
    {
        numbers.Add(random.Next(howmany));
    }
}

    
    
