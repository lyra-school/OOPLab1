/* Name: Lyra Karsaj
 * Date: 18/9/23
 * Desc: Switch statement revision
 */
namespace Q2
{
    internal class Program
    {
        // LC HL points from H1 to H8
        static int[] higherPoints = { 100, 88, 77, 66, 56, 46, 37, 0 };

        // LC OL points from O1 to O8
        static int[] lowerPoints = { 56, 46, 37, 28, 20, 12, 0, 0};
        static void Main(string[] args)
        {
            // Get input from user
            Console.Write("Enter LC grade (e.g. H1): ");
            String input = Console.ReadLine();
            // Input validation
            if(input.Length != 2 )
            {
                Console.WriteLine("You entered an invalid input (must be 2 characters).");
                return;
            }
            int numberMark;
            char letterMark;
            try
            {
                numberMark = input[1];
                letterMark = input[0];
            } catch (Exception ex)
            {
                Console.WriteLine("You entered an invalid input (second character must be a valid decimal number).");
                return;
            }
            // Gets points
            switch(letterMark)
            {
                case 'H':
                    switch(numberMark)
                    {
                        case '1':
                            Console.WriteLine("You earned: " + higherPoints[0].ToString());
                            break;
                        case '2':
                            Console.WriteLine("You earned: " + higherPoints[1].ToString());
                            break;
                        case '3':
                            Console.WriteLine("You earned: " + higherPoints[2].ToString());
                            break;
                        case '4':
                            Console.WriteLine("You earned: " + higherPoints[3].ToString());
                            break;
                        case '5':
                            Console.WriteLine("You earned: " + higherPoints[4].ToString());
                            break;
                        case '6':
                            Console.WriteLine("You earned: " + higherPoints[5].ToString());
                            break;
                        case '7':
                            Console.WriteLine("You earned: " + higherPoints[6].ToString());
                            break;
                        case '8':
                            Console.WriteLine("You earned: " + higherPoints[7].ToString());
                            break;
                        default:
                            Console.WriteLine("Grade not recognized.");
                            break;
                    }
                    break;
                case 'O':
                    switch (numberMark)
                    {
                        case '1':
                            Console.WriteLine("You earned: " + lowerPoints[0].ToString());
                            break;
                        case '2':
                            Console.WriteLine("You earned: " + lowerPoints[1].ToString());
                            break;
                        case '3':
                            Console.WriteLine("You earned: " + lowerPoints[2].ToString());
                            break;
                        case '4':
                            Console.WriteLine("You earned: " + lowerPoints[3].ToString());
                            break;
                        case '5':
                            Console.WriteLine("You earned: " + lowerPoints[4].ToString());
                            break;
                        case '6':
                            Console.WriteLine("You earned: " + lowerPoints[5].ToString());
                            break;
                        case '7':
                            Console.WriteLine("You earned: " + lowerPoints[6].ToString());
                            break;
                        case '8':
                            Console.WriteLine("You earned: " + lowerPoints[7].ToString());
                            break;
                        default:
                            Console.WriteLine("Grade not recognized.");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Grade not recognized.");
                    break;
            }
        }
    }
}