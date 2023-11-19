// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

string WriteNaturalNumbers(int m, int n)
{
    if (n == m) return $"{m}";
    else if ((m > 0) & (n > 0)) return WriteNaturalNumbers(m, n - 1) + " " + n;
    else if ((m <= 0) & (n > 0)) return WriteNaturalNumbers(1, n - 1) + " " + n;
    else if ((m <=0) & (m > n)) return "Нет между отрицательным числами натуральных чисел";
    else
    {
        return "Нет между отрицательным числами натуральных чисел";
    }
}


int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
string k = WriteNaturalNumbers(m, n);
Console.WriteLine(k);

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

string Array(int[] array, int n)
{
    if (n == 0) return Convert.ToString(array[0]);
    else
    {
        return Convert.ToString(array[n]) + " " + Array(array, n - 1);
    }
}

int[] Promt(string message)
{
    Console.WriteLine(message);
    string newMessage = "";
    while (true)
    {
        newMessage = Console.ReadLine() + "";
        if (newMessage == "")
        {
            Console.WriteLine("Ничего не было введно, поробуйте ещё раз: ");
            continue;
        }
        else
        {
            string[] newMessageList = newMessage.Split(",");
            int[] newNumbers = new int[newMessageList.Length];
            for (int i = 0; i < newMessageList.Length; i++)
            {
                newNumbers[i] = Convert.ToInt32(newMessageList[i]);

            }
            return newNumbers;

        }
    }
    
}

int[] array = Promt("Введите массив из элементов, перечисленных через запятую на новой строке:");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
Console.WriteLine(Array(array, array.Length-1));

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return (n + 1);
    }
    else if ((n == 0) & (m != 0))
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

int Post(string message)
{
    Console.WriteLine(message);
    int k = Convert.ToInt32(Console.ReadLine());
    return k;
}

int m = Post("Введите число неотрицательное число m:");
int n = Post("Введите число неотрицательное число n:");
Console.WriteLine(Akkerman(m,n));