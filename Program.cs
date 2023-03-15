using Humanizer;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Favour!");
Console.WriteLine("The current time is " + DateTime.Now);
RunSome check = new RunSome();
check.Name = "Favour";
Console.WriteLine(check.Name);
check.Num = Convert.ToInt32(Console.ReadLine());
check.Output();
int[] vals = new int[3];
for (int i = 1; i <= 3; i++) {
    vals[i - 1] = i;
}
foreach(var k in vals) Console.WriteLine(k);

Console.WriteLine("octopus".Pluralize());
Console.WriteLine("sheep".Pluralize());
Console.WriteLine("stadium".Pluralize());



