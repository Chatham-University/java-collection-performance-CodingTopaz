
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using CollectionChallenge;
using System.Numerics;

Stopwatch stopwatch = new Stopwatch();

Random rand = new Random();

//test 1
int num =  (int)Math.Pow(10, 5);
stopwatch.Start();
var arraydemo = new ArrayDemo(num,rand);
stopwatch.Stop();
Console.WriteLine("did arraydemo in "+stopwatch.Elapsed);

stopwatch.Restart();
var regularListDemo = new ListDemo(num, rand);
stopwatch.Stop();
Console.WriteLine("did regular list in "+stopwatch.Elapsed);


stopwatch.Restart();
var ArrayListVectorDemo = new ArrayListVectorDemo(num, rand);
stopwatch.Stop();
Console.WriteLine("did ArrayList in "+stopwatch.Elapsed);

stopwatch.Restart();
var HashSetDemo = new HashSetDemo(num, rand);
stopwatch.Stop();
Console.WriteLine("did HashSetDemo in "+stopwatch.Elapsed);
Console.WriteLine("end of test 1 begin test 2");


    
int testnum2 = (int)Math.Pow(13, 5);
int testnum3 = (int)Math.Pow(16, 5);


//I added two additional data types to make the comparison to ints more broad
//I added two extra testing numbers, increasing in difficulty

// doing the same test with a different number
stopwatch.Start();
var arraydemo2 = new ArrayDemo(testnum2,rand);
stopwatch.Stop();
Console.WriteLine("did arraydemo in "+stopwatch.Elapsed);


stopwatch.Restart();
var linkedListDemo2 = new LinkedListDemo(testnum2, rand);
stopwatch.Stop();
Console.WriteLine("did linkedlistdemo in "+stopwatch.Elapsed);


stopwatch.Restart();
var regularListDemo2 = new ListDemo(testnum2, rand);
stopwatch.Stop();
Console.WriteLine("did regular list in "+stopwatch.Elapsed);


stopwatch.Restart();
var ArrayListVectorDemo2 = new ArrayListVectorDemo(testnum2, rand);
stopwatch.Stop();
Console.WriteLine("did ArrayList in "+stopwatch.Elapsed);

stopwatch.Restart();
var HashSetDemo2 = new HashSetDemo(testnum2, rand);
stopwatch.Stop();
Console.WriteLine("did HashSetDemo in "+stopwatch.Elapsed);
Console.WriteLine("end of test 2 begin test 3");

// doing the same test with a third number
var arraydemo3 = new ArrayDemo(testnum3,rand);
stopwatch.Stop();
Console.WriteLine("did arraydemo in "+stopwatch.Elapsed);

stopwatch.Restart();
var linkedListDemo3 = new LinkedListDemo(testnum3, rand);
stopwatch.Stop();
Console.WriteLine("did linkedlistdemo in "+stopwatch.Elapsed);

stopwatch.Restart();
var regularListDemo3 = new ListDemo(testnum3, rand);
stopwatch.Stop();
Console.WriteLine("did regular list in "+stopwatch.Elapsed);

stopwatch.Restart();
var ArrayListVectorDemo3 = new ArrayListVectorDemo(testnum3, rand);
stopwatch.Stop();
Console.WriteLine("did ArrayList in "+stopwatch.Elapsed);

stopwatch.Restart();
var HashSetDemo3 = new HashSetDemo(testnum3, rand);
stopwatch.Stop();
Console.WriteLine("did HashSetDemo in "+stopwatch.Elapsed);
Console.WriteLine("end of test 3 finshed testing!");
