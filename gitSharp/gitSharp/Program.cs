Console.WriteLine("enter birth date in format DD.MM");

string[] dates = Console.ReadLine().Split('.');

int day = int.Parse(dates[0]);
int month = int.Parse(dates[1]);

if(day > 20&& month == 3 || day < 19 && month == 4)
{
    Console.WriteLine("you are oven");

}
else if (month == 4&& day >= 20 || month == 5 && day < 21)
{
    Console.WriteLine("you are telec");

}
else if (month == 5 && day >= 21 || month == 6 && day < 22)
{
    Console.WriteLine("you are telec");

}
else if (month == 6 && day >= 23 || month == 7 && day < 22)
{
    Console.WriteLine("you are bliznizi");

}
else if (month == 7 && day >= 22 || month == 8 && day < 23)
{
    Console.WriteLine("you are rak");

}
else if (month == 8 && day >= 23 || month == 9 && day < 22)
{
    Console.WriteLine("you are lev");

}
else if (month == 9 && day >= 22 || month == 10 && day < 24)
{
    Console.WriteLine("you are deva");

}
else if (month == 10 && day >= 24 || month == 11 && day < 23)
{
    Console.WriteLine("you are scorpion");

}
else if (month == 11&& day >= 22 || month == 12 && day < 22)
{
    Console.WriteLine("you are strelec");

}
else if (month == 12 && day >= 22 || month == 1 && day < 22)
{
    Console.WriteLine("you are kozerog");

}
else if (month == 1 && day >= 22 || month == 2 && day < 22)
{
    Console.WriteLine("you are vodoley");

}
else if (month == 2 && day >= 22 || month == 3 && day < 22)
{
    Console.WriteLine("you are riba");

}