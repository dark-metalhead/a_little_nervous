// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)
int []array = new int[10];
Random rand = new Random();

int [] RandomArray()
{
for (int i=0; i< array.Length; i++)
{
array[i]=rand.Next(1,10);
Console.Write ($"[{array[i]}] ");
}
return array;
}

void PrintArrayReverse(int[]array)
    {
        for (int a = array.Length-1; a>=0; a--)
    {
        Console.Write($"({array[a]}) ");
    }
    }
PrintArrayReverse(RandomArray());