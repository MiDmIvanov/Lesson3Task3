// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число N");
int N = 0;
int.TryParse(Console.ReadLine(), out N);
for (int i = 1; i <= N; i++)
{
    int Z = i*i*i;
    Console.Write($"{Z} ");
}