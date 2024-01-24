using System;

namespace CSharpRampUp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* PART 1 */
            /* Conversion */
            Console.Write("Weight in Pounds: ");
            int Pound = Convert.ToInt32(Console.ReadLine());
            double Kilogram = Pound * 0.45392;
            Console.WriteLine($"Weight in Kilogram: {Kilogram}");
            Console.WriteLine("====================================");

            Console.Write("Length in Miles: ");
            int Length = Convert.ToInt32(Console.ReadLine());
            double Kilometer = Length * 1.60934;
            Console.WriteLine($"Length in Kilometer: {Kilometer}");
            Console.WriteLine("====================================");

            Console.Write("Temperature in Fahrenheit: ");
            int Temperature = Convert.ToInt32(Console.ReadLine());
            double Celsius = (Temperature - 32) * 5 / 9;
            Console.WriteLine($"Temperature in Celsius: {Celsius}");
            Console.WriteLine("====================================");

            /* Age */
            int Student1;
            int Student2;
            int Student3;
            int Student4;
            int Student5;
            int Student6;
            int Student7;
            int Student8;
            int Student9;
            int Student10;

            Console.WriteLine("====================================");
            Console.Write("Age of Student 1: ");
            Student1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Age of Student 2: ");
            Student2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Age of Student 3: ");
            Student3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Age of Student 4: ");
            Student4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Age of Student 5: ");
            Student5 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Age of Student 6: ");
            Student6 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Age of Student 7: ");
            Student7 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Age of Student 8: ");
            Student8 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Age of Student 9: ");
            Student9 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Age of Student 10: ");
            Student10 = Convert.ToInt32(Console.ReadLine());

            int total = Student1 + Student2 + Student3 + Student4 + Student5 + Student6 + Student7 + Student8 + Student9 + Student10;
            double average_age = (double)total / 10;
            Console.WriteLine($"The average age of students is: {average_age}");
            Console.WriteLine("====================================");

            /* Story */
            /* Characters */
            string character1 = "Marie";
            string character2 = "Executioner";
            string character3 = "people";
            string character4 = "family";
            string character5 = "flower";

            /* Skills */
            string skill1 = "long range";
            string skill2 = "summon";
            string skill3 = "mirror image";
            string skill4 = "blinding smoke";
            string skill5 = "lead a battalion";

            /* Equipment */
            string equip1 = "broken mirror";
            string equip2 = "harp";
            string equip3 = "excalibur";
            string equip4 = "jewelry";
            string equip5 = "dress";

            string story = $@"There was a little girl named, {character1}. She is born to {skill5}. She was trained to look out for {character3} as she will be the new queen of France. However, she was being mistreated by her {character4} because she refuses to take up the role.

One day, she was strolling outside their kingdom walls when she came across a {character5}. They formed a bond like no other. Therefore, she often visits {character5} whenever she feels left out by her {character3}. A morning after a week in which she met {character5}, she put on her {equip4} and {equip5}.

She went outside to meet and greet {character3} more cheerfully than ever before. The {character3} were cheering in a crowd in which she can see on a stage. And with shaky hands, she held the mirror as she adored herself one more time.

The {character3} were suddenly engulfed in {skill4}. A {skill2} of deadly and poisonous roses spread like wildfire. The melodic sound of {equip2} changed into terror. An {equip3} with {skill1} was suddenly held by an anonymous {character2} chopping the head of Marie. Turning the {equip5} red and chopping the {equip4} apart.

The {skill3} then dispersed with the {character3} left with the scene. They went up to the stage and saw the {equip1} with {character1}'s {skill3}. No one knew how her image stayed in that mirror.

No one knew who the {character2} is. And {character5} is missing in the spot where it used to be. Others believed that {character1} wished death upon her and misery to those people who made her feel that way.
End. ";
            Console.WriteLine(story);
            Console.ReadLine();

            /* PART 2 */
            Console.Write("Input for pattern 1: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            if (input1 <= 0)
                 {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                 }
            else
            {
                for (int i = 1; i <= input1; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write($"{j} ");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadLine();

            
            Console.Write("Input for pattern 2: ");
            if (int.TryParse(Console.ReadLine(), out int input2) && input2 <= 0)
                {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                }
           else
                {
                 int sum = 0;
                 for (int i = 1; i <= input2; i++)
                   {
                   sum += i;
                   }
                 Console.WriteLine($"The sum of numbers from 1 to {input2} is: {sum}");
                }
           Console.ReadLine(); 

            Console.Write("Input for pattern 3: ");
            int input3 = Convert.ToInt32(Console.ReadLine());
            if (input3 <= 0)
                 {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                 }
            else
            {
                for (int i = input3; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write($"{j} ");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
