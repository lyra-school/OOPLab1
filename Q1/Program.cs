/* Name: Lyra Karsaj
 * Date: 18/9/23
 * Desc: If statement revision
 */
namespace Q1
{
    internal class Program
    {
        // LC HL points from H1 to H8
        static int[] higherPoints = { 100, 88, 77, 66, 56, 46, 37, 0 };
        static void Main(string[] args)
        {
            // Get input from user
            Console.Write("Enter percentage grade as a number: ");
            String input = Console.ReadLine();
            double grade;
            
            // Try to parse input as a double. End program if it fails
            try
            {
                grade = Double.Parse(input);
            } catch(Exception ex)
            {
                Console.WriteLine("You entered an invalid input.");
                return;
            }
            // If statements checking input against each point bracet
            if(grade > 100 || grade < 0)
            {
                Console.WriteLine("You entered an invalid number.");
            } else if (grade >= 90)
            {
                Console.WriteLine("You earned: " + higherPoints[0].ToString());
            } else if(grade >= 80)
            {
                Console.WriteLine("You earned: " + higherPoints[1].ToString());
            } else if(grade >= 70)
            {
                Console.WriteLine("You earned: " + higherPoints[2].ToString());
            } else if(grade >= 60)
            {
                Console.WriteLine("You earned: " + higherPoints[3].ToString());
            } else if(grade >= 50)
            {
                Console.WriteLine("You earned: " + higherPoints[4].ToString());
            } else if(grade >= 40)
            {
                Console.WriteLine("You earned: " + higherPoints[5].ToString());
            } else if(grade >= 30)
            {
                Console.WriteLine("You earned: " + higherPoints[6].ToString());
            }
            else if (grade <= 0)
            {
                Console.WriteLine("You earned: " + higherPoints[7].ToString());
            }
        }
    }
}