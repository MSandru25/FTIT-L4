/*Ex 3
Cititi de la tastatura continutul a doua matrici de intregi cu 2 dimensiuni avand lungimile n m,
respectiv m, n. Lungimile celor doua dimensiuni ale matricilor, m si n, vor fi citite de la tastaura.
Scrieti o functie care va calcula produsul celor doua matrici, apelati-o si afisati matricea rezultata*/

int[,] matrix1 = ReadMatrix();
int[,] matrix2 = ReadMatrix();
ShowMatrix(MatrixMultiplication(matrix1, matrix2));
static int[,] ReadMatrix()
{
    Console.WriteLine("n = ");
    var n = int.Parse(Console.ReadLine());
    Console.WriteLine("m = ");
    var m = int.Parse(Console.ReadLine());

    int[,] matrix = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write($"Elementul {i + 1},{j + 1} = ");
            matrix[i, j] = int.Parse(Console.ReadLine());
        }
    }
    return matrix;
}
static void ShowMatrix(int[,] matrix)
{
    int n = matrix.GetLength(0);
    int m = matrix.GetLength(1);
    for (var i = 0; i < n; ++i)
    {
        for (var j = 0; j < m; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

static int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] prod = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (var i = 0; i < matrix1.GetLength(0); i++)
    {
        for(var j = 0;j < matrix1.GetLength(1);j++)
        {
            prod[i,j] = matrix1[i, j] * matrix2[i,j];
        }
    }
    return prod;
}