namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(0, 1001);

            Console.WriteLine("Pick a Number from 1 - 1000");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine($"{userInput} is too low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine($"{userInput} is too high");
            }
            else
            {
                Console.WriteLine("Congratulations BooZa!");
            }
            Console.WriteLine("what is your favorite subject?");

            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I hate Math");
                    break;
                case "Aljebra":
                    Console.WriteLine("I love Aljebra");
                    break;
                case "English":
                    Console.WriteLine("I love Learing English");
                    break;
                case "History":
                    Console.WriteLine("It's Always been hard to learn History");
                    break;
                case "Science":
                    Console.WriteLine("Nver mind that");
                    break;
                default:
                    Console.WriteLine("i don't know that subject!");
                    break;
            }
        }
    }
}
