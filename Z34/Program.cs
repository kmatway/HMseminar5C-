// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GetArray(int size, int minValue, int maxValue) 
 {
    int[] res = new int[size];
    for( int i=0;i<size;i++)
    {
        res[i] = new Random().Next(minValue,maxValue+1);
    }
    return res;
 }

 void PrintArray(int[]arr)
{
    for( int i=0;i<arr.Length;i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int EvenNum(int[]arr)
{
    int result = 0;
    foreach(int el in arr)
    {
       if (el%2 == 0) result++;
    }
    return result;
}


int[] newarr = GetArray(6,100,1000);
PrintArray(newarr);
Console.WriteLine();
Console.WriteLine($"Ответ: {EvenNum(newarr)}");


