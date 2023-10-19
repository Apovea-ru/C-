// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Задача 10
int number;
string newstr = Console.ReadLine();
number = int.Parse(newstr);
number = number / 10;
number = number % 10;
Console.WriteLine(number);

// Задача 13
void Question(string number)
{
    if (number.Length < 3) {
        Console.WriteLine("Третей цифры нет");
    }
    else {
        Console.WriteLine(number[2]);
    }

};

int number;
string newstr = Console.ReadLine();
Question(newstr);

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void Days(int arg){
    if ((arg == 6) || (arg == 7)){
         Console.WriteLine("Выходной!!");
    }
    else {
         Console.WriteLine("Будни");
    }
}

int newstr = int.Parse(Console.ReadLine());
Days(newstr);

