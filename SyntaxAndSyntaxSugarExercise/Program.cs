using System;

namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = int.Parse(Console.ReadLine());
            
            var response = answer < 9 ? $"{answer} is less than 9" : $"{answer} is greater than 9";
            Console.WriteLine(response);
        }
    }
}
