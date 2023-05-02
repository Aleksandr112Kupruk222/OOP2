using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    abstract class Validation : IValidation
    {
        public double DoubleValidation(string message, int minRange, int maxRange)
        {
            double validInput;
            // Loop until a valid input is entered
            while (true)
            {
                // Prompt user for input and read from console
                Console.WriteLine(message);
                string input = Console.ReadLine();
                try
                {
                    if (double.TryParse(input, out validInput))
                    {

                        if (validInput > minRange && validInput <= maxRange)
                        {
                            // Return valid input
                            return validInput;
                        }
                        // Display error message if input is out of range
                        else
                        {
                            Console.WriteLine("Out of boundaries");
                        }

                    }
                    //Throw and exception if input is not a double
                    else
                    {
                        throw new Exception("Invalid input");
                    }

                }
                catch(Exception ex) 
                {
                   
                    
                    Console.WriteLine(ex);

                    
                }
              
                // Display error message if input cannot be converted to an integer
                
            }
        }
        public int IntValidation(string message, int minRange, int maxRange)
        {
            int validInput;
            // Loop until a valid input is entered
            while (true)
            {
                // Prompt user for input and read from console
                Console.WriteLine(message);
                string input = Console.ReadLine();
                try 
                {
                    if (int.TryParse(input, out validInput))
                    {

                        if (validInput > minRange && validInput <= maxRange)
                        {
                            // Return valid input
                            return validInput;
                        }
                        // Display error message if input is out of range
                        else
                        {
                            Console.WriteLine("Out of boundaries");
                        }

                    }
                    //Throw and exception if input is not an integer
                    else
                    {
                        throw new Exception("Invalid input");
                    }
                }
                
                catch(Exception ex) 
                {
                    Console.WriteLine(ex);

                }

             
            }
        }
    }
}
