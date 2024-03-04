// Задайте массив заполненный случайными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
int[] array = new int[10];
Random rand = new Random();
void PrintArray(int[] arr)
{
    int result = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            result++;
        }
    }


    Console.Write($" четных: {result}");

}

int[] RandomArray()
{
    for (int i = 1; i < array.Length; i++)
    {
        array[i] = rand.Next(100, 999);
        Console.Write($"[ {array[i] } ]");
    }
    return array;
}
PrintArray(RandomArray());