namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //My answer
                var a = 4;
                var myAnswer = $"The answer { ((a < 9) ? "is less than nine." : "is greater than or equal to nine.")}";

            Console.WriteLine(myAnswer);
            //The answer is less than nine.

            /* Using the given answer
            var a = 4;
            var myAnswer = (a < 9) ? $"{a} is less than nine" : $"{a} is greater than nine";
            Console.WriteLine(myAnswer);
            a is less than nine.*/


        }
    }
}
