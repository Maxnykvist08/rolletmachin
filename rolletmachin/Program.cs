
Console.WriteLine("summa");
string inputsumma = Console.ReadLine();
int betsumma = Convert.ToInt32(inputsumma);
List<string> betplay = ["numer" , "red or black", "even or odd", "1 to 18", "19 to 36", "1st 12"]

Console.WriteLine(" mellan 0 och 36");
string inputnumer = Console.ReadLine();
int betnumber = Convert.ToInt32(inputnumer);


Random random = new Random();


int number = random.Next(36);

Console.WriteLine(number);

if (betnumber == number)
{
    Console.WriteLine("du van");
}



