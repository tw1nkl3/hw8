int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,,] array = new int[a, b, c];
fillArray(array);
printArray(array);

void printArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"a({i}) b({j}) ");
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"c({k})={arr[i, j, k]}; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void fillArray(int[,,] arr)
{
    int[] temp = new int[arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(2)];
    int num;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(0, 10);
        num = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(0, 10);
                    j = 0;
                    num = temp[i];
                }
                num = temp[i];
            }
        }
    }
    int count = 0;
    for (int a = 0; a < arr.GetLength(0); a++)
    {
        for (int b = 0; b < arr.GetLength(1); b++)
        {
            for (int c = 0; c < arr.GetLength(2); c++)
            {
                arr[a, b, c] = temp[count];
                count++;
            }
        }
    }
}
