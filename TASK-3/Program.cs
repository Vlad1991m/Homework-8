
int[,] Spiral()
{
    int side = 4;
    int sideelement = 1;
    int[,] result = new int[side,side];
    int num = 1;
    for (int k = 0; k < side - sideelement * 2; k++)
    {
        for (int j = k; j < side - sideelement - k; j++, num++)
            result[k,j] = num;
        for (int i = k; i < side - sideelement - k; i++, num++)
            result[i,side - sideelement - k] = num;
        for (int j = side - sideelement - k; j >= k; j--, num++)
            result[side - sideelement - k,j] = num;
        for (int i = side - sideelement * 2 - k; i > k; i--, num++)
            result[i,k] = num;
    }
    return result;
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


int[,] myArray = Spiral();
Show2dArray(myArray);