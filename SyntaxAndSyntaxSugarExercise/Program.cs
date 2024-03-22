namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = 20;
            var response = (answer < 9) ? $"{answer} is less than 9? That explains everything!" :
                                            $"{answer} is greater than or equal to 9? Swolebrain tricked me!"; //changed nine to 9, looks better when printed to console
            Console.WriteLine(response);

        }
    }
}
