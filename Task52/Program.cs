/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int getDataFromUser(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int[,] get2DDubleArray(int rowLength, int colLength, int start, int finish)
{
    int[,] array = new int[rowLength, colLength];
    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colLength; j++)
        {
            array[i, j] = new Random().Next(start, finish + 1);
        }
    }
    return array;
}
void printInColour(string data, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(data);
    Console.ResetColor();
}
void printHaedOfArray(int length)
{
    Console.Write(" \t");
    for (int i = 0; i < length; i++)
    {
        printInColour(i + "\t", ConsoleColor.DarkGreen);
    }
    Console.WriteLine();
}
void printEndOfArray(double[] result)
{
    Console.Write(" \t");
    for (int i = 0; i < result.Length; i++)
    {
        printInColour(result[i] + "\t", ConsoleColor.DarkYellow);
    }
    Console.WriteLine();
}
void printArray(int[,] array, double[] result)
{
    printHaedOfArray(array.GetLength(1));
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColour(i + "|\t", ConsoleColor.Cyan);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    printEndOfArray(result);
}
double[] averageCol(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
   for (int i = 0; i < array.GetLength(1); i++) 
    {
        double sum = 0.0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j,i];
        }
        result[i] = Math.Round(sum / array.GetLength(0),1);
    }
    return result;
}
int rowLength = getDataFromUser("Введите количество строк");
int colLength = getDataFromUser("Введите количество столбцов");
int[,] array = get2DDubleArray(rowLength, colLength, 0, 20);
double[] result = averageCol(array);
printArray(array, result);



