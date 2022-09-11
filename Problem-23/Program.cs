// Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число ");
string name = Console.ReadLine();
int number = Convert.ToInt32(name);
int[] array = new int[number];
for (int i = 1; i < number + 1; i++)
{
    System.Console.Write(i * i * i + " ");
}