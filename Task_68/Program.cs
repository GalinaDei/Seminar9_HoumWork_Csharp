/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
/*
Ackermann(0,n) = n+1;
Ackermann(m,0) = Ackermann(m-1,1);
Ackermann(m,n) = Ackermann(m-1,Ackermann(m,n-1)),m>0,n>0
*/
int m = 3;
int n = 2;
int AckermannFunction (int m, int n)
{
    if (m==0&n>0)
    {return n+1;}
    if (m>0&n==0)
    {return AckermannFunction(m-1,1);}
    if (m>0&n>0)
    {return AckermannFunction(m-1,AckermannFunction(m,n-1));}
    return AckermannFunction(m,n);
}

Console.Write($"m = {m}, n = {n} -> {AckermannFunction(m,n)}");