/*

*/

int [,] InitMatrix(int m,int n)
{
    int[,] matrix = new int[m,n];
    Random randomizer = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i,j] = randomizer.Next(1,10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }

        Console.WriteLine();
    }
}

void CheckIndex (int m, int n, int k, int l,int [,]matrix)
{
    if( k-1 >= m || 
        k < 0 || 
        l-1 >= n || 
        l < 0)
        
    Console.WriteLine("Вы ввели не корректные позиции.");
    else
    Console.WriteLine($"{matrix[k-1,l-1]}");
}


Console.WriteLine("Введите число m:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = int.Parse(Console.ReadLine());


int[,] matrix = InitMatrix(m,n);



Console.WriteLine($"Матрица размером {m}x{n}:");
Console.WriteLine();


PrintMatrix(matrix);
Console.WriteLine();

Console.WriteLine("Введите индекс по строке:");
int k = int.Parse(Console.ReadLine());
Console.WriteLine("Введите индекс по столбцу:");
int l = int.Parse(Console.ReadLine());

Console.WriteLine();
CheckIndex(m,n,k,l,matrix);