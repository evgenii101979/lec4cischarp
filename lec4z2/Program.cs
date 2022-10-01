int[,] pic = new int[,]//картинка рука

void PrintImage(int[,] image)
{

    for (int i = 0; i < image.GetLength(0); i++)      // вместо 3 можно вставить imageix.GetLength(0)
    {
        for (int j = 0; j < image.GetLength(1); j++)  // вместо 4 можно вставить imageix.GetLength(1)
        {
            //Console.Write($"{image[i, j]} ");
            if(image[i, j] == 0)
            Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}

void FillImage(int row, int col)
{
    if(pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}



PrintImage(pic);
FillImage(13, 13);
PrintImage(pic);

/*void FillArray(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)      
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            image[i,j] = new Random().Next(1,10);  // [1; 10)
        }
    }
}

int[,] imageix = new int[3, 4];
PrintArray(imageix);
FillArray(imageix);
Console.WriteLine();
PrintArray(imageix);*/
