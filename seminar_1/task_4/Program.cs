// принимает одно целое число N, на выходе показывает все числа в промежутке от -N до N.

Console.WriteLine("Введите целое число");
        int number = Convert.ToInt32(Console.ReadLine());
        int count = -(number);
        while (count <= number)
        {
            Console.Write(count);
            count = count + 1;
        }