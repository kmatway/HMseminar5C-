//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

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
int SumEl(int[]arr)
{
    int sum = 0;
    for(int i=0; i<arr.Length; i++)
    {
        if(i%2!=0) sum = sum + arr[i];
    }
    return sum;
}


int[] newarray = GetArray(6,1,10);
PrintArray(newarray);
Console.WriteLine($"Ответ: {SumEl(newarray)}");


