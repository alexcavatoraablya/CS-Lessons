Console.WriteLine("-------середня оцінка------");

Console.Write("enter your grade 1: ");
double mark1 = double.Parse(Console.ReadLine());

Console.Write("enter your grade 2: ");
double mark2 = double.Parse(Console.ReadLine());

Console.Write("enter your grade 3: ");
double mark3 = double.Parse(Console.ReadLine());

Console.Write("enter your grade 4: ");
double mark4 = double.Parse(Console.ReadLine());

Console.Write("enter your grade 5: ");
double mark5 = double.Parse(Console.ReadLine());

double result = (mark1 + mark2 + mark3 + mark4 + mark5) / 5;

Console.Write(result);