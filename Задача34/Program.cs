//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Beep();
Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}


int[] array = GetArray(5, 100, 999);

int NumSum(int[] array1)
{
int Summ= 0;
int n = 0;
int index = 0;

while (index < array1.Length)
{
    if (array1[n]%2 == 0)
    {
        Summ+=1;
    }
    n++;
    index++;
}
return Summ;
}

Console.WriteLine();

if (NumSum(array) == 0)
{
   Console.WriteLine("В данном массиве нет четных чисел");
}
else
{
  Console.WriteLine($"Kоличество четных чисел в данном массиве = {NumSum(array)}");
}