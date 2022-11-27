namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //For division, create two integer variables called a and b.

            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;

            //Console.WriteLine(a + "/" + b + " is " + quotient + " remainder " + remainder);
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

            Console.WriteLine("Please enter the radius of your circle:");
            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);
            Console.WriteLine(AreaOfCircle(radius));

          
        }
        public static double AreaOfCircle(double radius)
        {
            //this os the scope of method
            var area = Math.PI * Math.Pow(radius, 2);

            return area;

        }
    }
}
