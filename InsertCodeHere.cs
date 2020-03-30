using System;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            
            Person personA = new Person ("Madeleine", 29, 22522424);
            Person personB = new Person ("Thea", 25, 40592772);

            Console.WriteLine($"Person A's navn er:  {personA.Name}, alder: {personA.Age} og telefonnummer: {personA.TelephoneNumber}");
            Console.WriteLine($"Person B's navn er:  {personB.Name}, alder: {personB.Age} og telefonnummer: {personB.TelephoneNumber}");

            personA.IncreaseAge();
            System.Console.WriteLine($"Next time {personA.Name} will turn {personA.Age}");

            personB.IncreaseAge();
            System.Console.WriteLine($"Next time {personB.Name} will turn {personB.Age}");

            personA.IncreaseAge(); personB.IncreaseAge();
            System.Console.WriteLine($"And the year after that {personA.Name} will turn {personA.Age} and {personB.Name} will turn {personB.Age}");

            // The LAST line of code should be ABOVE this line
        }
    }
}
