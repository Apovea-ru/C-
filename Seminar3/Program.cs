// Задача 19: Напишите программу, которая принимает
// на вход пятизначное число и проверяет, является ли
// оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

// Задача 21: Напишите программу, которая принимает
// на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9.
// 5 -> 1, 8, 27, 64, 125

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Задача 19: Напишите программу, которая принимает
// на вход пятизначное число и проверяет, является ли
// оно палиндромом.

int Promt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void Polindrom(int number)
{
    if (number == 0)
    {
        Console.WriteLine("Палиндром");
    }
    else
    {
        int numberAbs = Math.Abs(number);
        int i = 0;
        int n = 0;
        while (numberAbs > 0)
        {
            numberAbs = numberAbs / 10;
            i++;
        }
        int[] array = new int[i];
        int numberAb = Math.Abs(number);
        int j = 0;
        while (numberAb > 0)
        {
            n = numberAb % 10;
            numberAb = numberAb / 10;
            array[j] = n;
            j++;
        }
        string result = string.Join("", array);
        int numberN = Convert.ToInt32(result);
        if (number == numberN) Console.WriteLine("Палиндром");
        else Console.WriteLine("Не палиндром");
    }
}

int number = Promt("Выберите число?");
Polindrom(number);

// Задача 21: Напишите программу, которая принимает
// на вход координаты двух точек и находит расстояние между ними в 3D пространстве.



int Promt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void ThreeD(int x, int y, int z, int i, int j, int k)
{
    double result = 0;
    result = Math.Round(Math.Sqrt((Math.Pow(i - x, 2)) + (Math.Pow(j - y, 2)) + (Math.Pow(k - z, 2))), 2);
    Console.WriteLine(result);
}

int x1 = Promt("Введите координату X 1 точки");

int y1 = Promt("Введите координату Y 1 точки");

int z1 = Promt("Введите координату Z 1 точки");

int x2 = Promt("Введите координату X 2 точки");

int y2 = Promt("Введите координату Y 2 точки");

int z2 = Promt("Введите координату Z 2 точки");

// ThreeD(x1, y1, z1, x2, y2, z2);

// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int Promt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void Coob(int n)
{
    for (int i = 0; i <= n; i++)
    {
        Console.Write(Math.Pow(i, 3) + "; ");
    }
}

int n = Promt("Введите число: ");
Coob(n);
