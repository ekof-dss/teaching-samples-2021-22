
using System;

namespace DSS.PropertyBackingField
{
    class Program
    {
        static void Main()
        {
            FictionCharacter lik = new FictionCharacter(firstname:"Donald", "Duck");
            Console.WriteLine("lik - ime: {0}", lik.FirstName);
            Console.WriteLine("lik - prezime: {0}", lik.LastName);
            Console.WriteLine("lik - puno ime: {0}", lik.FullName);
            Console.WriteLine();

            lik.FirstName = "Ronald";
            Console.WriteLine("lik - ime: {0}", lik.FirstName);
            Console.WriteLine("lik - prezime: {0}", lik.LastName);
            Console.WriteLine("lik - puno ime: {0}", lik.FullName);
            Console.WriteLine();

            lik.FullName = "Felipe Caetano Lopes Martines Gonsales";
            Console.WriteLine("lik - ime: {0}", lik.FirstName);
            Console.WriteLine("lik - prezime: {0}", lik.LastName);
            Console.WriteLine("lik - puno ime: {0}", lik.FullName);
            Console.WriteLine();

            lik.FullName = "Supermen";
            Console.WriteLine("lik - ime: {0}", lik.FirstName);
            Console.WriteLine("lik - prezime: {0}", lik.LastName);
            Console.WriteLine("lik - puno ime: {0}", lik.FullName);
            Console.WriteLine();
        }
    }

}


