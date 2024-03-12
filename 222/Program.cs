//Задача 2: Напишите программу вычисления функции Аккермана с 
//помощью рекурсии. Даны два неотрицательных числа m и n. 

static int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
    return -1;

}

Console.Write(Akkerman(0, 3));