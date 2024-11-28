using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Unesite niz brojeva odvojenih razmakom:");
        int[] niz = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        if (niz.Length < 3)
        {
            Console.WriteLine("Niz mora sadržavati najmanje 3 broja.");
        }
        else
        {
            var najveci = niz.OrderByDescending(x => x).Take(3); // Sortira niz opadajuće i uzima prva 3 broja
            Console.WriteLine("Tri najveća broja su: " + string.Join(" ", najveci));
        }
    }
}
