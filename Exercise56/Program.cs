/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

*/

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void Search(int[,] array, int rows)
{
    int count = 0;
    int m = 0;
    int n = 0;
    int proverka = 10000; // в данном элементе кода мы присваиваем переменной потенциально больщее число чем сумма вобще всех жлементов массива, я знаю что ему можно присвоить значение бесконечности, но без понятия как)
    while (m < rows)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            count = count + array[m, i];
            n = i;
        }
        if (count < proverka)
            proverka = count;
        count = 0;
        m++;
    }
    Console.WriteLine($"Строка {n} имеет меньшее значение равное {proverka}");
}

void Main()
{
    Console.Write("Введите количество строк: ");
    int rows = int.Parse(Console.ReadLine()!);
    Console.Write("Введите количество колонок: ");
    int columns = int.Parse(Console.ReadLine()!);
    Console.Write("Введите минимальное значение: ");
    int minValue = int.Parse(Console.ReadLine()!);
    Console.Write("Введите максимальное значение: ");
    int maxValue = int.Parse(Console.ReadLine()!);
    int[,] array = GetArray(rows, columns, minValue, maxValue);
    PrintArray(array);
    Console.WriteLine();
    Search(array, rows);

}

Main();





