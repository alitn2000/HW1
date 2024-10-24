Console.Write("number 1: ");
int n1 = int.Parse(Console.ReadLine());

Console.Write("number 2: ");
int n2 = int.Parse(Console.ReadLine());

Console.Write("number 3: ");
int n3 = int.Parse(Console.ReadLine());

Console.Write("number 4: ");
int n4 = int.Parse(Console.ReadLine());

Console.Write("number 5: ");
int n5 = int.Parse(Console.ReadLine());

int temp;

if (n1 > n2)
{
    temp = n1;
}

else
{
    temp = n2;
}

if (n3 > temp)
{
    temp = n3;
}

if(n4 > temp)
{
    temp = n4;
}

if (n5 > temp)
{
    temp = n5;
}

Console.WriteLine($" Max number is: {temp}");