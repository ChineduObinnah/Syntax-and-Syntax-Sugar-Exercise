namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = 5;

            var response = (answer == 4) ? "equal" : "its less than" ;
            Console.WriteLine(response);
        }
    }
}
