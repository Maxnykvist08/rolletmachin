

Console.Write("put in totel amount =");
bool vaidnumber = false;
string inputsumma;
int summa = 0;
while (!vaidnumber)
{
    inputsumma = Console.ReadLine();
    summa = Convert.ToInt32(inputsumma);
    if (summa >0)
    {
        vaidnumber = true;
    }else {
        Console.WriteLine("invalid number");
            }
}

Random random = new Random();
vaidnumber = false;
bool playagain = false;
bool betagain = false;
while(playagain == false) 
{ 

    Console.Clear();
int number = random.Next(36);
int loss = 0;


Console.Write("totel bet =");
    vaidnumber = false;

string inputbetsumma ;
    int betsumma = 0;
    while (!vaidnumber)
    {
        inputbetsumma = Console.ReadLine();
        betsumma = Convert.ToInt32(inputbetsumma);
        if (betsumma <= summa && betsumma>0)
        {
            vaidnumber = true;
        }
        else { Console.WriteLine("invalid bet"); }
    }

Console.Clear();
List<string> betplay = [ "numer", "red","black", "even"," odd", "1 to 18", "19 to 36", "1st 12", "2nd 12", "3rd 12"];

for (int i = 0; i < betplay.Count; i++)
{
    Console.WriteLine(i +1 + ":" + betplay[i]);


}

Console.WriteLine("input corosponding number to play style");
    string playinput;
    int playnumber = 0;
    vaidnumber = false;
    while (!vaidnumber)
    {
        playinput = Console.ReadLine();
        playnumber = Convert.ToInt32(playinput);
        if (playnumber >=1 && playnumber <= 10)
        {
            vaidnumber = true;
        }else { Console.WriteLine("invalid number"); }
    }

Console.Clear();
int betnumber;
string inputnumer;

List <int> contener = new List<int>();
int winnings = 0;

if (playnumber == 1)
{
    Console.WriteLine(" mellan 0 och 36");
    inputnumer = Console.ReadLine();
    betnumber = Convert.ToInt32(inputnumer);
    contener.Add(betnumber);
    winnings = betsumma * 36;
    if (betnumber == 0)
        {
            winnings = betsumma + loss *36;
        }
    

}else if (playnumber == 2)
{
    contener = [1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36];
    winnings = betsumma * 2;
}
else if (playnumber == 3)
{
    contener = [2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35];
    winnings = betsumma * 2;
}

else if (playnumber == 4)
{
    for (int i = 0;i < 36; i++)
    {
        if (i % 2 == 0)
        {
            contener.Add(i);
        }
    }
        winnings = betsumma * 2;
}
else if (playnumber == 5)
{
    for (int i = 0; i < 36; i++)
    {
        if (i % 2 == 1)
        {
            contener.Add(i);
        }
    }
    winnings = betsumma * 2;
}
else if (playnumber == 6)
{
    for (int i = 0; i < 18; i++)
    {
        contener.Add(i);
    }
    winnings = betsumma * 2;
}
else if (playnumber == 7)
{
    for (int i = 18; i < 36; i++)
    {
        contener.Add(i);
    }
    winnings = betsumma * 2;
}
else if (playnumber == 8)
{
    for (int i = 0; i < 12; i++)
    {
        contener.Add(i);
    }
    winnings = betsumma * 2;
}
else if (playnumber == 9)
{
    for (int i = 13; i < 24; i++)
    {
        contener.Add(i);
    }
    winnings = betsumma * 2;
}
else if (playnumber == 10)
{
    for (int i = 25; i < 36; i++)
    {
        contener.Add(i);
    }
    winnings = betsumma * 2;
}
    Console.WriteLine( "wining number " + number);

    if (contener.Contains(number))
{
    Console.WriteLine(betplay[playnumber -1 ] + " " + "won");
    Console.WriteLine("you get " +winnings + "$ back ");
    Console.WriteLine("totel winings ="+( summa + winnings) + "$");
    summa = summa + winnings;
    }
else
{
    Console.WriteLine("house won");
        Console.WriteLine("totel loss =" + (summa - betsumma) + "$");
        summa = summa - betsumma;
        loss = loss + betsumma;
    }
    if (summa <= 0)
    {
        Console.WriteLine("out of money, do you want to put in more? enter for yes, space for no");
        
        
        if (Console.ReadKey().Key == ConsoleKey.Enter)
        {
            Console.Write("put in totel amount =");
             inputsumma = Console.ReadLine();
             summa = Convert.ToInt32(inputsumma);
        }
        else if (Console.ReadKey().Key== ConsoleKey.Spacebar)
        {
          System.Environment.Exit(0);
        }
    }
    Console.WriteLine("do you want to play again, enter for yes, space for no");
    
   
    if (Console.ReadKey().Key == ConsoleKey.Spacebar)
    {
        playagain = true;
    }


}



