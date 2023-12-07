/* Name: Lyra Karsaj
 * Date: 18/9/23
 * Desc: Nested if
 */
namespace Q3
{
    internal class Program
    {
        // LC HL points from H1 to H7
        static int[] higherPoints = { 100, 88, 77, 66, 56, 46, 37, 0 };

        // LC OL points from O1 to O8
        static int[] lowerPoints = { 56, 46, 37, 28, 20, 12, 0, 0 };
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
            }
            catch (Exception ex)
            {
                Console.WriteLine("You entered an invalid input.");
                return;
            }

            // Get input from user
            Console.Write("Enter H for higher level, O for ordinary: ");
            String inputLetter = Console.ReadLine();
            if (inputLetter.Length != 1)
            {
                Console.WriteLine("You entered an invalid input (must be 1 character).");
                return;
            }
            char letter = inputLetter[0];

            // If statements checking input against each point bracet
            int pointsEarned = -1;
            if (letter == 'H')
            {
                if (grade > 100 || grade < 0)
                {
                    
                }
                else if (grade >= 90)
                {
                    pointsEarned = higherPoints[0];
                }
                else if (grade >= 80)
                {
                    pointsEarned = higherPoints[1];
                }
                else if (grade >= 70)
                {
                    pointsEarned = higherPoints[2];
                }
                else if (grade >= 60)
                {
                    pointsEarned = higherPoints[3];
                }
                else if (grade >= 50)
                {
                    pointsEarned = higherPoints[4];
                }
                else if (grade >= 40)
                {
                    pointsEarned = higherPoints[5];
                }
                else if (grade >= 30)
                {
                    pointsEarned = higherPoints[6];
                }
                else if (grade <= 0)
                {
                    pointsEarned = higherPoints[7];
                }
            }
            else if (letter == 'O')
            {
                if (grade > 100 || grade < 0)
                {
                    
                }
                else if (grade >= 90)
                {
                    pointsEarned = lowerPoints[0];
                }
                else if (grade >= 80)
                {
                    pointsEarned = lowerPoints[1];
                }
                else if (grade >= 70)
                {
                    pointsEarned = lowerPoints[2];
                }
                else if (grade >= 60)
                {
                    pointsEarned = lowerPoints[3];
                }
                else if (grade >= 50)
                {
                    pointsEarned = lowerPoints[4];
                }
                else if (grade >= 40)
                {
                    pointsEarned = lowerPoints[5];
                }
                else if (grade >= 30)
                {
                    pointsEarned = lowerPoints[6];
                }
                else if (grade <= 0)
                {
                    pointsEarned = lowerPoints[7];
                }
            }

            if(pointsEarned == -1)
            {
                Console.WriteLine("Grade not recognized.");
            } else
            {
                Console.WriteLine("You earned: " + pointsEarned.ToString());
            }
        }
    }
}