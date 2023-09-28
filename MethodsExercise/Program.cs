namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your favorite girl's name?");
            string girlName = Console.ReadLine();
            
            Console.WriteLine("What's your favorite guy's name?");
            string guyName = Console.ReadLine();
            
            Console.WriteLine("What's your favorite outdoor activity using an -ing verb?");
            string ingVerb = Console.ReadLine();

            Console.WriteLine("What's a big and/or dangerous animal?");
            string bigAnimal = Console.ReadLine();

            Console.WriteLine("What's an adjective for the big and/or dangerous animal?");
            string adj1 = Console.ReadLine();

            Console.WriteLine("What's another adjective for the big and/or dangerous animal?");
            string adj2 = Console.ReadLine();


            Console.WriteLine($"{girlName} and {guyName} were {ingVerb} outside on a beautiful day.");
            Console.WriteLine($"Suddenly, a {adj1} and {adj2} {bigAnimal} came and started charging right at them!");
            Console.WriteLine($"{girlName} and {guyName} ran away as fast as they could but {guyName} fell and hurt himself.");
            Console.WriteLine($"{girlName} didn't notice that {guyName} was gone and ran back to town.");
            Console.WriteLine($"Nobody ever saw {guyName} again...");

        }
    }
}
