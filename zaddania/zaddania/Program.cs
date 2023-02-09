// moje zadania


string name;
int age;
bool sexMale;

name = "Magda";
age = 37;
sexMale = false;

//poniżej punkt (1), przykład: Kobieta poniżej 30 lat.
if (sexMale == true)
{
    if (age < 30)
    {
        Console.WriteLine("(1) Mężczyzna poniżej 30 lat");
    }
    else
    {
        Console.WriteLine("(1) Mężczyzna powyżej 30 lat");
    }
}
else
{
    if (age < 30)
    {
        Console.WriteLine("(1) Kobieta poniżej 30 lat");
    }
    else
    {
        Console.WriteLine("(1) Kobieta powyżej 30 lat");
    }
}

//poniżej punkt (2), przykład: Ewa, lat 33.
Console.WriteLine("(2) " + name + ", lat " + age + ".");

//poniżej punkt (3), przykład: Niepełnoletni mężczyzna. 
if (age < 18 && sexMale == true)
{ Console.WriteLine("(3) Niepełnoletni mężczyzna."); }
else if (age < 18 && sexMale == false)
{ Console.WriteLine("(3) Niepełnoletnia kobieta."); }
else if (age >= 18 && sexMale == true)
{ Console.WriteLine("(3) Pełnoletni mężczyzna."); }
else { Console.WriteLine("(3) Pełnoletnia kobieta."); }


