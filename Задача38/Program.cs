// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


int[] GetArray(int size, int minValue, int maxValue)
{
    Console.Write("[");
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    Console.Write("]");
    return res;

}
Console.WriteLine("Введите длину массива");
int line = int.Parse(Console.ReadLine());

Console.WriteLine("Введите начало масссива");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите конец масссива");
int number2 = int.Parse(Console.ReadLine());

int[] array = GetArray(line, number1, number2);

int MaxNumbers(int[] maxnumber)
{
    int index = 1;
    int max = maxnumber[0];
    int n = 1;

    while (index < maxnumber.Length)
    {
        if (maxnumber[n] > max)
        {
            max = maxnumber[n];
        }
        index = index + 1;

        n = n + 1;

    }
    return max;
}

int MinNumbers(int[] minnumber)
{
    int index = 1;
    int min = minnumber[0];
    int n = 1;

    while (index < minnumber.Length)
    {
        if (minnumber[n] < min)
        {
            min = minnumber[n];
        }
        index = index + 1;

        n = n + 1;

    }
    return min;
}

Console.WriteLine();

int diff = MaxNumbers(array) - MinNumbers(array);

Console.WriteLine($"Pазница между максимальным и минимальным элементов массива = {diff}");
