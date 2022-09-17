Console.WriteLine("Если хотите сложить 2 числа, то введите 1 ");
Console.WriteLine("Если хотите вычесть первое число из второго, то введите 2 ");
Console.WriteLine("Если хотите перемножить 2 числа, то введите 3 ");
Console.WriteLine("Если хотите разделить первое число на второе, то введите 4 ");
Console.WriteLine("Если хотите возвести число в степень, то введите 5 ");
Console.WriteLine("Если хотите найти квадратный корень числа, то введите 6 ");
Console.WriteLine("Если хотите найти 1 процент от числа, то введите 7 ");
Console.WriteLine("Если хотите найти факториал числа, то введите 8 ");
Console.WriteLine("Если хотите закончить программу то введите 9 ");

int camanda = Convert.ToInt32(Console.ReadLine());

while (camanda <= 8)
{

    if (camanda == 1)
    {
        Console.WriteLine("Введите первое слогаемое");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите второе слогаемое");
        int y = Convert.ToInt32(Console.ReadLine());

        int rezultat = x + y;
        Console.WriteLine("Результат: " + rezultat);
    }

    if (camanda == 2)
    {
        Console.WriteLine("Введите число из которого будете вычетать ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите число которе будете вычитать из первого ");
        int y = Convert.ToInt32(Console.ReadLine());

        int rezultat = x - y;
        Console.WriteLine("Результат: " + rezultat);

    }

    if (camanda == 3)
    {
        Console.WriteLine("Введите первый множитель");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите второй множитель");
        int y = Convert.ToInt32(Console.ReadLine());

        int rezultat = x * y;
        Console.WriteLine("Результат: " + rezultat);
    }

    if (camanda == 4)
    {
        Console.WriteLine("Введите делимое");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите делитель");
        int y = Convert.ToInt32(Console.ReadLine());

        int rezultat = x / y;
        Console.WriteLine("Результат: " + rezultat);
    }

    if (camanda == 5)
    {
        Console.WriteLine("Введите число которе будет возведенно в степень");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите степень в которую будете возводить");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Результат: " + Math.Pow(x, y));
    }

    if (camanda == 6)
    {
        Console.WriteLine("Введите число из которого надо извлечь корень");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Результат: " + Math.Sqrt(x));
    }

    if (camanda == 7)
    {
        Console.WriteLine("Введите число 1 процент которого хотите узнать");
        double x = Convert.ToDouble(Console.ReadLine());

        double rezultat = x / 100;

        Console.WriteLine("Результат: " + rezultat);
    }

    if (camanda == 8)
    {
        Console.WriteLine("Введите число факториал которого хотите узнать");
        int x = Convert.ToInt32(Console.ReadLine());
        int z = 1;
        for (int i = 1; i <= x; i++)
        {
            z = z * i ;
        }
        Console.WriteLine("Результат: " + z);
    }
    Console.WriteLine("");
    Console.WriteLine("Если хотите почитать еще что-нибудь или закончить введите номер команды");
    int pcamanda = Convert.ToInt32(Console.ReadLine());
    camanda = pcamanda;
}

if (camanda == 9)
{

}