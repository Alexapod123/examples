Console.WriteLine("Введите целое число №1");
int numberA = Convert.ToInt32( Console.ReadLine() );
Console.WriteLine("Введите целое число №2");
int numberB = Convert.ToInt32( Console.ReadLine() );
if (numberA / numberB == numberB)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}
