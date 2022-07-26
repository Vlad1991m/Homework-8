int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j= 0; j < rows; j++)
            newArray[i,j] = new Random().Next(1,9);

    return newArray;
}


int[,] Decrease(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int z = j + 1; z < array.GetLength(1); z++)
            {
                if(array[i,z] < array[i,j])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,z];
                    array[i,z] = temp;
                }
            }
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j= 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] myArray = CreateRandom2dArray(m,n);
Show2dArray(myArray);
Console.WriteLine();
Decrease(myArray);
Show2dArray(myArray);

