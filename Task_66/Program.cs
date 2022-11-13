/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N. 
Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int num1 = 4;
int num2 = 10;
int SummNumners (int num1, int num2)
{
    if (num1==num2)
       return num1;
    else {return num1 + SummNumners(num1+1,num2);}
}
Console.WriteLine($"M = {num1}; N = {num2} -> {SummNumners(4,10)}");