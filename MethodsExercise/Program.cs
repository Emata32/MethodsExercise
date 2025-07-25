namespace MethodsExercise
{
    public class Program
    {
        public static void Madlib()
        {   Console.WriteLine("Hi nice to meet you whats you're name?");
            string name = Console.ReadLine();
            
            Console.WriteLine($"Hi {name}! What kind of pet do you have?");
            string kindOfPet = Console.ReadLine();
           
            Console.WriteLine($"Wow a {kindOfPet}! What color is your {kindOfPet}?");
            string colorOfPet = Console.ReadLine();
            
            Console.WriteLine($"what kind of snacks dose your {kindOfPet} like?");
            String kindOfSnacks = Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Madlib();
        }
    }
}

