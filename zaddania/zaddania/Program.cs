// moje zadania

//w21 d 4
Console.WriteLine(" ");
Console.WriteLine("_-_-_-_-_-_-_-_-_");
Console.WriteLine("Zadanie w21 day 4");

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

//w21 d5
//po zadaniu danej liczby program podaje ile jakich cyfr jest w podanej liczbie - wyświetlanie w postaci listy cyfr
Console.WriteLine(" ");
Console.WriteLine("_-_-_-_-_-_-_-_-_");
Console.WriteLine("Zadanie w21 day 5");

int number = 45667;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();
int HowLongNumber = letters.Length;
List<string> ListOfNumbers = new List<string>();
int[] SumOfNumbers = new int[10];

if (HowLongNumber == 1)
{
    Console.WriteLine("Liczba składa się z 1 cyfry");
}
else
{
    Console.WriteLine("Liczba składa się z " + HowLongNumber + " cyfr.");
}

for (int i = 0; i < HowLongNumber; i++)
{
    Console.WriteLine("Cyfra nr " + (i + 1) + " w liczbie to: " + letters[i]);

}

for (int i = 0; i < 10; i++)
{
    SumOfNumbers[i] = 0;
}

foreach (char letter in letters)
{
    if (letter == '0')
    { SumOfNumbers[0]++; }
    if (letter == '1')
    { SumOfNumbers[1]++; }
    if (letter == '2')
    { SumOfNumbers[2]++; }
    if (letter == '3')
    { SumOfNumbers[3]++; }
    if (letter == '4')
    { SumOfNumbers[4]++; }
    if (letter == '5')
    { SumOfNumbers[5]++; }
    if (letter == '6')
    { SumOfNumbers[6]++; }
    if (letter == '7')
    { SumOfNumbers[7]++; }
    if (letter == '8')
    { SumOfNumbers[8]++; }
    if (letter == '9')
    { SumOfNumbers[9]++; }
}

Console.WriteLine("");
Console.WriteLine("W liczbie " + number + " ilość poszczególnych cyfr wynosi: ");

for (int i = 0; i < 10; i++)
{
    ListOfNumbers.Add(i + " => " + SumOfNumbers[i]);
    Console.WriteLine(ListOfNumbers[i]);
}



