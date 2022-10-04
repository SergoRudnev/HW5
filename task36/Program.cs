// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0,999);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int GetSumOddIndex(int[] arr)
{
    int sumOddIndex = 0;
    for (int i = 0; i < arr.Length; i+=2)
    {
        sumOddIndex += arr[i];
    }
    return sumOddIndex;
}
    //*********************
int[] massiv = new int[4];
FillArray(massiv);
PrintArray(massiv);

Console.WriteLine("сумма элементов, стоящих на нечётных позициях: " + GetSumOddIndex(massiv));