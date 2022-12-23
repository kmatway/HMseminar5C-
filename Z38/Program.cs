// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

double[] GetArray(int size, double series) 
 {
    double[] res = new double[size];
    for( int i=0;i<size;i++)
    {
        res[i] = new Random().NextDouble()*100;
    }
    return res;
 }

 void PrintArray(double[]arr)
{
    for( int i=0;i<arr.Length;i++)
    {
        Console.Write($"{Math.Round(arr[i],2)}, ");
    }
}

double DifferenceMinMaxArray(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    {
        for(int i=0; i<arr.Length; i++)
        {
            if(arr[i] > max) max = arr[i];
            if(arr[i] < min) min = arr[i];
        }
        return max - min;    }

}

double[] array = GetArray(6,100);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Ответ: {Math.Round(DifferenceMinMaxArray(array),2)}");




