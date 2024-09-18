using System.Security.Cryptography.X509Certificates;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            try
            {
                Person p = new Person("Elon", "Musk");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            //p.age;
            //p.Age;

            Console.ReadLine();
        }
    }
}


