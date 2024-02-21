namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NamePets("Kieran", "Jason");
            NamePets("Colin", "Celia", "Cheryl");
            NamePets();
        }

        static void NamePets(string name, string name2)
        {
            Console.WriteLine($"Your pets {name} and {name2} will be joining your voyage across space!");
        }

        static void NamePets(string name, string name2, string name3)
        {
            Console.WriteLine($"Your pets {name}, {name2}, and {name3} will be joining your voyage across space!");
        }

        static void NamePets()
        {
            Console.WriteLine("Aw, you have no spacefaring pets!");
        }
    }
}