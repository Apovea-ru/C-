// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double Degree(int a, int b)
{
    double result = Math.Pow(a, b);
    return result;

}

int Promt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int a = Promt("Введите первое число");
int b = Promt("Введите его степень");
Console.WriteLine(Degree(a,b));


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.



int Promt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] NewArray(int number)
{
    int i = 0;
    int numb = number;
    while (numb > 0)
    {
        numb /= 10;
        i++;
    }
    int[] arr = new int[i];
    for (int j = 0; j < i; j++)
    {
        arr[j] = number % 10;
        number /= 10;
    }
    Array.Reverse(arr);
    return arr;
}

int Summ(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        result += arr[i];
    }
    return result;
}

int a = Promt("Введите число");
int[] arr = NewArray(a);
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i]+" ");
}
Console.WriteLine();
Console.WriteLine(Summ(arr));

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] Promt(string message)
{
    Console.Write(message);
    string message2 = Console.ReadLine();
    if (message2.Split(",").Length < 8)
    {
        while(true == true)
        {
            Console.WriteLine("Вы ввели меньше 8 цифр, введите заново: ");
            message2 = Console.ReadLine();
            if (message2.Split(",").Length >= 8)
            {
                break;
            } 

        }          
    }
    Console.WriteLine(message2.Split(",").Length);
    int j = message2.Split(",").Length;
    int[] array = new int[j];
     // int number = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < j; i++)
    {
        array[i] = Convert.ToInt32(message2.Split(",")[i]);
    }
    return array;
}

void Paste(int[] numbers)
{
    Console.Write("[");
    for (int j = 0; j < numbers.Length; j++)
    {
        if (j != numbers.Length - 1)
        {
            Console.Write(numbers[j]+", ");
        } 
        else 
        {
            Console.Write(numbers[j]);
        }
    }
    Console.Write("]");

}

int[] numb = Promt("Наберите числа через запятую: ");
Paste(numb);




