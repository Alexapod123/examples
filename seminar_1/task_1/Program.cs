// Программа для возведения в квадрат

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32( Console.ReadLine() );
int square = number * number;
Console.WriteLine("Квадрат введенного числа равен " + square);

if (number<0)
{
    Console.WriteLine("Введено отрицательное число");
}
else
{
    Console.WriteLine("Введено неотрицательное число");
}