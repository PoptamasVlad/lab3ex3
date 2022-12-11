using System;

namespace lab3ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Scrieti o functie care va determina daca un numar este sau nu patrat perfect. Apelati-o si afisati-i rezultatul */

            int n = int.Parse(Console.ReadLine());

            if(PatratPerfect(n))
            {
                Console.WriteLine(n + " este patrat perfect");
            }
            else
            {
                Console.WriteLine(n + " nu este patrat perfect");
            }

            static bool PatratPerfect(int n)
            {
                for(int i=0; i<=n; i++)
                {
                    if(i*i == n)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
