/*Ex 2
Cititi de la tastatura continutul unei matrici de intregi cu 3 dimensiuni avand lungimile n, m k.
Lungimile celor trei dimensiuni ale matricii, n, m si k, vor fi citite de la tastaura.
 Scrieti o functie care va calcula suma elementelor unei astfel de matrici , apelati-o si afisati-i rezultatul.
 Scrieti o functie care va determina elementul cu valoare maxima, apelati-o si afisati-i rezultatul*/

int[,,] matrix = ReadMatrix();
Console.WriteLine($"Suma elementelor matricii este: {SumOf3DMatrix(matrix)}");
Console.WriteLine($"Cel mai mare element al matricii este: { MatrixMax(matrix)}");
static int[,,] ReadMatrix()
{
    Console.WriteLine("n = ");
    var n = int.Parse(Console.ReadLine());
    Console.WriteLine("m = ");
    var m = int.Parse(Console.ReadLine());
    Console.WriteLine("k = ");
    var k = int.Parse(Console.ReadLine());

    int[,,] matrix = new int[n, m, k];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int l = 0; l < k; l++)
            {
                Console.Write($"Elementul {i + 1},{j + 1},{l + 1} = ");
                matrix[i, j, l] = int.Parse(Console.ReadLine());
            }
        }
    }
    return matrix;
}

int SumOf3DMatrix(int[,,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0;j < matrix.GetLength(1); j++)
        {
            for (int l = 0;l < matrix.GetLength(2); l++)
            {
                sum += matrix[i, j, l];
            }
        }
    }
    return sum;
}

int MatrixMax(int[,,] matrix)
{
    int max = 0;
    foreach (int i in matrix)
    {
        if(i > max)
        {
            max = i;
        }
    }
    return max;
}