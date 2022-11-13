/* Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.WriteLine("Введите любое натуральное число от 1 и более.");
int number = int.Parse(Console.ReadLine()??"");
string PrintReversedNumbersList (int number)
{
    if (number==1)
       return number.ToString();
    else 
       {
        return number+", "+PrintReversedNumbersList(number-1);
       }
}
Console.WriteLine(PrintReversedNumbersList(number));
