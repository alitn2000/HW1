Console.Write("Enter number 1: ");
int n1 = int.Parse(Console.ReadLine());

Console.Write("Enter number 2: ");
int n2 = int.Parse(Console.ReadLine());

Console.Write("Enter number 3: ");
int n3 = int.Parse(Console.ReadLine());

int first = 0;
int second = 0;
int third = 0 ;

if (n1 <= n2 && n1 <= n3)
{
    first = n1;
    if (n2 <= n3)
    {
        second = n2;
        third = n3;
    }
    else
    {
        second = n3;
        third = n2;
    }
}

else if (n2 <= n1 && n2 <= n3)
{
    first = n2;

    if (n1 <= n3)
    {
        second = n1;
        third = n3;
    }

    else
    {
        second = n3;
        third = n1;
    }
}
else
{
    first = n3;

    if (n1 <= n2)
    {
        second = n1;
        third = n2;
    }
    else
    {
        second = n2;
        third = n1;
    }
}


Console.WriteLine($" moratab shode : {first} < {second} < {third}");