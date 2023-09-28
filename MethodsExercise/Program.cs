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

            int sum = Add(17, 45);
            Console.WriteLine($"17 plus 45 is {sum}.");

            int sub = Minus(100, 75);
            Console.WriteLine($"100 minus 75 is {sub}.");

            int prod = Times(8, 7);
            Console.WriteLine($"8 times 7 is {prod}.");

            int quot = Divide(35, 5);
            Console.WriteLine($"35 divided by 5 is {quot}.");
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Minus(int num1, int num2) 
        { 
            return num1 - num2;
        }

        public static int Times(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            return (num1 / num2);
        }
     }
}
