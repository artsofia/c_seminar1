void Task2()
{
    //Задача 2: Напишите программу, которая на вход принимает 
    //два числа и выдаёт, какое число большее, а какое меньшее.

    Console.WriteLine("Введите первое число");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите второе число");
    int num2 = Convert.ToInt32(Console.ReadLine());

    if (num1 > num2)
    {
        Console.Write("max = ");
        Console.WriteLine(num1);

        Console.Write("min = ");
        Console.WriteLine(num2);
    }
    else if (num1 < num2)
    {
        Console.Write("max = ");
        Console.WriteLine(num2);

        Console.Write("min = ");
        Console.WriteLine(num1);
    }
    else
    {
        Console.WriteLine("Числа равны");
    }
}

//Task2();


void Task4()
{
    //Задача 4: Напишите программу, которая принимает на вход
    //три числа и выдаёт максимальное из этих чисел.

    Console.WriteLine("Введите первое число");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите второе число");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите третье число");
    int num3 = Convert.ToInt32(Console.ReadLine());

    if (num1 >= num2 & num1 >= num3)
    {
        Console.WriteLine(num1);
    }
    else if (num2 >= num1 & num2 >= num3)
    {
        Console.WriteLine(num2);
    }
    else if (num3 >= num1 & num3 >= num2)
    {
        Console.WriteLine(num3);
    }
}

//Task4();


void Task6()
{
    //Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
    //является ли число чётным (делится ли оно на два без остатка).

    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num % 2 == 0)
    {
        Console.WriteLine("Да, число четное");
    }
    else 
    {
        Console.WriteLine("Нет, число НЕчетное");
    }
}

//Task6();


void Task8()
{
    //Задача 8: Напишите программу, которая на вход принимает
    //число (N), а на выходе показывает все чётные числа от 1 до N.

    Console.WriteLine("Введите число");
    int n = Convert.ToInt32(Console.ReadLine());

    //Создаем переменную счетчик 
    int count = 1;

    while (count <= n)
    {
        if (count % 2 == 0)
        {
            Console.Write(count + " ");
        }

        count++;
    }
}

//Task8();