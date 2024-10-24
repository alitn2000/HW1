Console.Write("Enter 3 digits number: ");
string number = Console.ReadLine();
if (number.Length == 3 && number.All(Char.IsDigit))
{
    int num1 = int.Parse(number[0].ToString());
    int num2 = int.Parse(number[1].ToString());
    int num3 = int.Parse(number[2].ToString());

    int sum = num1 + num3;
    
    if (sum == num2)
    {
        Console.WriteLine(true);
    }
    else
    {
        Console.WriteLine(false);
    }
}
else
{
    Console.WriteLine("number is invalide !!!");
}
