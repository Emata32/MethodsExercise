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
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            return a / b;
        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
        
        

        static void Main(string[] args)
        {
            Madlib();
          
           //ADD two numbers
           Console.WriteLine(Add(1,1));
           //Subtract two numbers
           Console.WriteLine(Sub(8, 2));
           //Multiply two numbers
           Console.WriteLine(Multiply(1, 2));
           //Divide two numbers
           Console.WriteLine(Divide(4, 2));
           Console.WriteLine(Sum(5, 5 , 5));
           
           
           
        }
    }
}

