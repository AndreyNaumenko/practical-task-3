Console.WriteLine("Введите пятизначное число "); // Напишите программу, которая принимает на вход
// пятизначное число и проверяет, является ли оно палиндромом.
string name = Console.ReadLine();
int number = Convert.ToInt32(name);
int numberA = number / 1000;

int numberB = number % 10;
int numberC = numberB * 10000;
int numberD = number / 10;
int numberE = numberD % 10;
int numberF = numberE * 1000;
int numberG = numberC + numberF;
int numberRevers = numberG / 1000;
if(number > 99999)
{
    Console.WriteLine("Число не является пятизначным");
}
else
{
    if(number < 10000)
    {
        Console.WriteLine("Число не является пятизначным");
    }
    else
        if(numberA == numberRevers)
        {
            Console.WriteLine("Это число палиндром");
        }
        else
        {
            Console.WriteLine("Это число не палиндром");
        }
}