// Напишите программу, которая заполнит спирально прямоугольного массива.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

void PrintArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write("[ ");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (array[i, j] > 9)
            {
                Console.Write(array[i, j] + " ");
            }
            else Console.Write("0" + array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

Console.Clear();

Console.WriteLine($"\nВведите размер массива m x n: ");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int[,] nums = new int[m, n];
int contnum = m * n;
int num = 2, minI = 0, minJ = 1;
int i = 0, j = 0 ;
nums[0,0] = 1;

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

while (num <= contnum)
{
    while (i + 1 < m && nums[i + 1, j] == 0)
        { 
        i++;
        nums[i, j] = num;
        num++;
        }
    while (j + 1 < n && nums[i, j + 1] == 0)
        {
        j++;
        nums[i, j] = num;
        num++;     
        }    
    while ( i - 1 > minI - 1 && nums[i -1 ,j] == 0)
        {
        i--;
        nums[i, j] = num;
        num++;   
        }
    while (j - 1> minJ - 1 &&  nums[i, j - 1] == 0)
        {
        j--;
        nums[i, j] = num;
        num++;
        } 
}

 PrintArray(nums);





