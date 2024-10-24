Console.Write("please enter your first name:");
string first_name = Console.ReadLine();

Console.Write("please enter your last name :");
string  last_name=Console.ReadLine();

Console.Write("please enter your national code: ");
string national_code =Console.ReadLine();

if (national_code.Length != 10 || national_code.All(char.IsDigit) == false)
{
    Console.WriteLine("Length of national code is invalide!!!");
}

else 
{
    Console.Write("please enter your phone number: ");
    string phone = Console.ReadLine();

    if (phone.Length != 11 || phone.All(char.IsDigit) == false || phone.Substring(0, 2) != "09")
    {
        Console.WriteLine("phone number is invalide!!!");
    }

    else
    {
        Console.Write("please enter your E-mail address: ");
        string email = Console.ReadLine();

        int first_at = email.IndexOf('@');
        int last_at = email.LastIndexOf('@');

        int first_dot = email.IndexOf('.');
        int last_dot = email.LastIndexOf('.');

        if(first_at !=-1 && first_at == last_at && first_dot !=-1 && first_dot == last_dot )
        {
            Console.Write("please enter your birthdate: ");
            string date = Console.ReadLine();

            if (date.Length ==10 && date[4] == '/' && date[7] == '/')
            {
                string year = date.Substring(0, 4);
                string month = date.Substring(5, 2);
                string day = date.Substring(8, 2);
                if(year.All(char.IsDigit) && month.All(char.IsDigit) && day.All(char.IsDigit))
                {
                    Console.WriteLine($"First name : {first_name}\nLast name : {last_name}\n National ID : {national_code}\nPhone number : {phone}\nEmail-adress : {email}\nBirthdate : {date}");
                }
                else
                {
                    Console.WriteLine("Date is incorrect!!!");
                }
            }
            else
            {
                Console.WriteLine("Date format is incorrect!!!");
            }

        }
        else
        {
            Console.Write("Email address is incorrect!!!");
        }
    }

}
