Console.WriteLine("-------кількість градусів на вулиці------");

Console.Write("enter degrees: ");
double degrees = double.Parse(Console.ReadLine());

//Console.Write("enter your grade 2: ");
//double mark2 = double.Parse(Console.ReadLine());

//Console.Write("enter your grade 3: ");
//double mark3 = double.Parse(Console.ReadLine());

//Console.Write("enter your grade 4: ");
//double mark4 = double.Parse(Console.ReadLine());

//Console.Write("enter your grade 5: ");
//double mark5 = double.Parse(Console.ReadLine());

double result = (degrees * 1.8 + 32);

Console.Write($"Fahrenheit:{result}");

