/*Supliment 1
• Se citesc doua numere de la tastatura. Scrieti un program care va calcula
cel mai mare divizor comun al numerelor*/

Console.Write("x = ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("y = ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Cel mai mare divizor comun al numerelor este : {MaxDivCom(x, y)} ");

static int MaxDivCom(int num1, int num2)
{
    int rest;

    while (num2 != 0)
    {
        rest = num1 % num2;
        num1 = num2;
        num2 = rest;
    }

    return num1;
}