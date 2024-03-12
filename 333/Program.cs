//Задача 3: Задайте произвольный массив. Выведете его элементы, 
//начиная с конца. Использовать рекурсию, не использовать циклы.

using System;

class MainClass {
public static void Main (string[] args) {
int[] arr = {1, 2, 3, 4, 5};
    PrintArrayFromEnd(arr, arr.Length-1);
}

static void PrintArrayFromEnd(int[] arr, int index) {
    if (index < 0) {
        return;
    } else {
        Console.WriteLine(arr[index]);
        PrintArrayFromEnd(arr, index - 1);
    }
}
}