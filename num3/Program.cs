/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
1 4 | 3 5
3 5 | 1 2

Результирующая матрица будет:
7 13
14 25 */

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,] array1 = new int[a, b];
fillArray(array1);
printArray(array1);

Console.WriteLine();

int[,] array2 = new int[b, c];
fillArray(array2);
printArray(array2);

int[,] resArr = new int[a, c];

Console.WriteLine();
multiply(array1, array2, resArr);

void multiply(int[,] arr1, int[,] arr2, int[,] res){

    for (int i = 0; i < res.GetLength(0); i++){

        for (int j = 0; j < res.GetLength(1); j++){

            int sum = 0;
            for (int k = 0; k < arr1.GetLength(1); k++){
                sum += arr1[i,k] * arr2[k,j];
            }
            res[i,j] = sum;
        }
    }
    
    for (int i = 0; i < res.GetLength(0); i++){
        for (int j = 0; j < res.GetLength(1); j++){
            Console.Write(res[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void fillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}