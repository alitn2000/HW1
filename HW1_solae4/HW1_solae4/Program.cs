Console.Write("Enter number 1: ");
double num1 = int.Parse(Console.ReadLine());

Console.Write("Enter number 2: ");
double num2 = int.Parse(Console.ReadLine());

Console.Write("Enter number 3: ");
double num3 = int.Parse(Console.ReadLine());

Console.Write("Enter number 4: ");
double num4 = int.Parse(Console.ReadLine());

Console.Write("Enter number 5: ");
double num5 = int.Parse(Console.ReadLine());

double sum = num1 + num2+ num3 + num4 + num5;

double avg =  Math.Floor(sum /5);
avg = Math.Floor(avg);

if (avg % 2 == 0)
{
    Console.WriteLine(true);
}
else
{
    Console.WriteLine(false);
}