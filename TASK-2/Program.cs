int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j= 0; j < rows; j++)
            newArray[i,j] = new Random().Next(1,9);

    return newArray;
}


int Minsumrow(int[,] array)
{
    int minSum = 0;
    int minRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        if(i == 0) minSum = sum;
        else if(sum < minSum) 
        {
            minSum = sum;
            minRow = i;
        }
    }
    
    return minRow;
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
Console.WriteLine($"Minimal filled row is: {Minsumrow(myArray)}");

