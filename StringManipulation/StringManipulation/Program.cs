using System.Diagnostics;
using System.Text;

var stringBuilder = new StringBuilder();

var stopWatch = new Stopwatch();
stopWatch.Start();
for  (int i = 0; i < 100_000; i++)
{
    stringBuilder.Append("0");
}
stopWatch.Stop();
Console.WriteLine(stopWatch.ElapsedMilliseconds);

stopWatch.Reset();
stopWatch.Start();

string a = "";
for (int i = 0; i < 100_000; i++)
{
    a += "0"; 
}
stopWatch.Stop();

Console.WriteLine(stopWatch.ElapsedMilliseconds);

Console.ReadKey();
