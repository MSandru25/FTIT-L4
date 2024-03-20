/*Supliment 2
• Scrie un program care afiseaza numerele de la 1 la N. Daca numarul este
multiplu de 3, sa se afiseze Fizz, daca este multiplu de 3 sa se afiseze Buzz,
daca e multiplu si de 3 si de 5 (ex: 15) sa se afiseze FizzBuzz, in restul
cazurilor sa se afiseze numarul*/

Console.Write("Introduceti un numar: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    { Console.WriteLine("FizzBuzz"); }
    else if (i % 3 == 0)
    { Console.WriteLine("Fizz"); }
    else if (i % 5 == 0)
    { Console.WriteLine("Buzz"); }
    else
    { Console.WriteLine(i); }
}