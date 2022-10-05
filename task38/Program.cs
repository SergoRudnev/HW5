// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
void FillArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().NextDouble()*10;
    }
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

double GetMax(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i] > max)
        max = arr[i];
    }
    return max;

}    
    
double GetMin(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i] < min)
        min = arr[i];
    }
    return min;
 }
    //*********************
double[] massiv = new double[4];
FillArray(massiv);
PrintArray(massiv);
Console.WriteLine(GetMax(massiv) + " максимальное число в массиве");
Console.WriteLine(GetMin(massiv) + " Минимальное число в массиве");
double diff = GetMax(massiv) - GetMin(massiv);
Console.WriteLine("разница между максимальным и минимальным элементов массива " + diff);