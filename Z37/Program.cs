// SЗадача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний
//и т.д. Результат запишите в новом массиве. 
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21
 
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


 void PrintArray2(int[]arr2)
 {
   if(arr2.Length%2 == 0)
   {
   for(int i=0; i<arr2.Length/2; i++)
    {
    arr2[i] = arr2[i]*arr2[arr2.Length - i - 1];
    Console.Write($" {arr2[i]} ");
    }
   }
   else
   {
    for(int i=0; i<arr2.Length/2; i++)
    {
    arr2[i] = arr2[i]*arr2[arr2.Length - i - 1];
    Console.Write($" {arr2[i]} ");
    }
    Console.Write($" {arr2[arr2.Length/2]}");
   }
 }



int[] array = GetArray(5,1,10);
PrintArray(array);
Console.WriteLine();
PrintArray2(array);

