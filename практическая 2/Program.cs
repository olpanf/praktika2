Console.WriteLine("Выберите операцию");
Console.WriteLine("1-Игра'Угадай число'");
Console.WriteLine("2-Таблица умножения");
Console.WriteLine("3-Вывод делителей числа");
Console.WriteLine("4-Закрыть программу");
int Op = Convert.ToInt32(Console.ReadLine());
while (Op != 4)

{
       if (Op == 1)
    {


        Random chislo = new Random();
        int i = chislo.Next(100);
        Console.WriteLine("Загадано число от 1 до 100, попробуйте его угадать");
        Console.WriteLine("Введите число");
        int k = Convert.ToInt32(Console.ReadLine());
        
        while (i != k)
        {
            if (i<k)
            {
                Console.WriteLine("Нужно меньше");
            }
            if (i>k)
            {
                Console.WriteLine("Нужно больше");
            }
            k = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Поздравляем, Вы угадали число");

    }
    if (Op == 2)
    {
        int[,] tabl = new int[9, 9];
        for (int i = 0; i <= 8; i++)
        {
            for (int j = 0; j <= 8; j++)
            {
                tabl[i, j] = (i + 1) * (j + 1);
            }
        }

        for (int i = 0; i <= 8; i++)
        {
            for (int j = 0; j <= 8; j++)
            {
                Console.Write($"{tabl[i, j]}\t");
            }
            Console.WriteLine();
        }
    }
        Console.WriteLine("Выберите операцию");
    Console.WriteLine("1-Игра'Угадай число'");
    Console.WriteLine("2-Таблица умножения");
    Console.WriteLine("3-Вывод делителей числа");
    Console.WriteLine("4-Закрыть программу");
    Op = Convert.ToInt32(Console.ReadLine());
}

