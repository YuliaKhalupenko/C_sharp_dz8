// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine()!);
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 6); //Для увеличения размера чисел в матрицах поменять число 6 на большее
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

Console.Clear();

int sizeAi = InputInt("введите количество строк матрицы А: ");
int sizeAj = InputInt("введите количество столбцов матрицы А: ");
int[,] matrixA = new int[sizeAi, sizeAj];
Console.WriteLine($"По правилу перемножения матриц количество столбцов матрицы А должно быть равно количеству строк матрицы В и равна {sizeAj}");
int sizeBj = InputInt("введите количество столбцов матрицы B: ");
int[,] matrixB = new int[sizeAj, sizeBj];
FillArrayRandomNumbers(matrixA);
FillArrayRandomNumbers(matrixB);
int[,] matrixC = new int[sizeAi, sizeBj];

for (int i = 0; i < sizeAi; i++)
{
    for (int j = 0; j < sizeBj; j++)
    {
        for (int k = 0; k < sizeAj; k++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
        }
    }
}
Console.WriteLine("Матрица - А");
PrintArray(matrixA);
Console.WriteLine();
Console.WriteLine("Матрица - В");
PrintArray(matrixB);
Console.WriteLine();
Console.WriteLine("Произведение матриц А*В");
PrintArray(matrixC);

