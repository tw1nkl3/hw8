/* Задайте двумерный массив. Напишите программу, которая упорядочит элементы по убыванию (или возрастанию). */

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int[,] num = new int[a, b];

fillArray(num);
printArray(num);
Console.WriteLine();
sortArray(num);
printArray(num);


/* int[,] sortArray(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            int temp = 0;
            temp = arr[i, j];
            arr[i, j] = arr[i, j + 1];
            arr[i, j + 1] = temp;
        }
    }
    return arr;

    IDK как делать :(
        
} */



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