// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены 
// на строчные.

// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова 
// расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.

//Задача 5. Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел пользователь.

//Задача 6. Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнением y = k1*x + b1
// y = k2*x + b2; значения b1,k1,b2 и k2 задаются пользователем.


char[,] NewCharMassive(string message)
{
    Random rnd = new Random();
    int n = rnd.Next(3, 3);
    int k = rnd.Next(3, 3);
    char[,] newChar = new char[n, k];
    Console.WriteLine(message);
    char newKey;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < k; j++)
        {
            newKey = Console.ReadKey().KeyChar;
            newChar[i, j] = newKey;
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < k; j++)
        {
            Console.Write(newChar[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    return newChar;
}

string NewString(char[,] message)
{
    string newString = "";
    for (int i = 0; i < message.GetLength(0); i++)
    {
        for (int j = 0; j < message.GetLength(1); j++)
        {
            newString += message[i, j];
        }
    }
    return newString;
}

char[,] newChar = NewCharMassive("Введите двухмерный массив из букв, но прописывай сразу, без Enter: ");
string message = NewString(newChar);
Console.WriteLine();
Console.WriteLine(message);

// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены 
// на строчные.

string Message()
{
    string message = ("Введите строку с латинскими буквами в обоих регистрах: ");
    Console.WriteLine(message);
    string readline = "";
    readline = readline + Convert.ToString(Console.ReadLine());
    // while (true)
    // {
    //     if (readline == null)
    //     {
    //         readline ="!Repeat Again!";
    //         Console.WriteLine(readline);
    //         continue;
    //     }
    //     else
    //     {
    //         break;
    //     }
    // }
    return readline;    
}

void LowerCase( string message)
{
    Console.WriteLine(message.ToLower());
}

string message = Message();
LowerCase(message);

// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

string NewString(string message)
{
    string newString = "";
    Console.WriteLine(message);
    newString = Console.ReadLine();
    return newString;
}

void Palindrom(string message)
{
    int j = 0;
    for (int i = 0; i < message.Length / 2; i++)
    {
        if (message[i] == message[message.Length - 1 - i])
        {
            j++;
        }
    }
    if (j == message.Length / 2)
    {
        Console.WriteLine("Палиндромом!");
    }
    else Console.WriteLine("Не Палиндромом!");
}

string newString = NewString("Введите строку:");
Palindrom(newString);

//Задача 5. Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел пользователь.

int[] NewInt(string message)
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

string FindAfterZero( int[] numbers)
{
    int i = 0;
    foreach (int el in numbers)
    {
        if (el > 0)
        {
            i++;
        }
    }
    string message = $"Количество чисел больше нуля = {i}";
    return message;
}

int[] numbers = NewInt("Введите числа через запятую: ");
for (int i = 0; i < numbers.Length; i++)
{
   Console.WriteLine(numbers[i]); 
}
string message = FindAfterZero(numbers);
Console.WriteLine(message);

//Задача 6. Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнением y = k1*x + b1
// y = k2*x + b2; значения b1,k1,b2 и k2 задаются пользователем.

int[] Solve(int b1, int k1, int b2, int k2)
{
    int x;
    int y1, y2;
    int[] y = new int[2];
    x = (b2 - b1)/(k1 - k2);
    y1 = k1*x + b1;
    y2 = k2*x + b2;
    Console.WriteLine($"{x}, {y1}, {y2}");
    y[0] = y1;
    y[1] = y2;
    return y;     
}

Console.WriteLine("Введите b1,k1,b2 и k2:");
int b1 = Convert.ToInt32(Console.ReadLine());
int k1 = Convert.ToInt32(Console.ReadLine());
int b2 = Convert.ToInt32(Console.ReadLine());
int k2 = Convert.ToInt32(Console.ReadLine());
int[] y = Solve(b1, k1, b2, k2);