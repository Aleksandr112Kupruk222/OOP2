using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class Testing : Pack,IValidation
    {
        //Add comments to this class
        //Testing class to tet the methods in the pack class
        public Testing()
        {
            RunTest();
        }
        
        void RunTest()
        {
            Pack pack5 = new Bodmas5();
            
            //Test the shuffle method
            Console.WriteLine("Test deck creation and shuffle method");
            foreach (Card x in Pack.pack) 
            {
                x.show();
            }
            //Test pack calculations method for 3 and 5 cards cards to see if math is correct
            Console.WriteLine("Test pack calculations method for 3 and 5 cards cards to see if math is correct");
            TestEquations();
            //Test the record method
            Console.WriteLine("Test the record method");
            Equation = "Test";
            Record("Tes time",1,0.00);
            //Print statistic out of statistic.txt
            Console.WriteLine("Print statistic out of statistic.txt");
            PrintStatistic();
            //Test validation methods for int and double
            Console.WriteLine("Test validation methods for int and double");
            Console.WriteLine("Int validation");
            Console.WriteLine(IntValidation("Test int min = 0 max = 2", 0, 2));
            Console.WriteLine("Double validation");
            Console.WriteLine(DoubleValidation("Test Double min = -100000000 max = 1000000000 ", -100000000, 1000000000));
            //Test the user answear method
            Console.WriteLine("Test the user answear method");
            Main main = new Main();
            
            
        }
        
        void TestEquations() 
        {
            Console.WriteLine($"5 + 5 = {Calculate(5,5,1)}");
            Console.WriteLine($"5 - 5 = {Calculate(5, 5, 2)}");
            Console.WriteLine($"5 * 5 = {Calculate(5, 5, 3)}");
            Console.WriteLine($"5 / 5 = {Calculate(5, 5, 4)}");
            Console.WriteLine($"5 + 5 + 5 = {BODMAS5(5, 5, 5,1,1)}");
            Console.WriteLine($"5 + 5 - 5 = {BODMAS5(5, 5, 5, 1, 2)}");
            Console.WriteLine($"5 + 5 * 5 = {BODMAS5(5, 5, 5, 1, 3)}");
            Console.WriteLine($"5 + 5 / 5 = {BODMAS5(5, 5, 5, 1, 4)}");
            Console.WriteLine($"5 - 5 + 5 = {BODMAS5(5, 5, 5, 2, 1)}");
            Console.WriteLine($"5 - 5 - 5 = {BODMAS5(5, 5, 5, 2, 2)}");
            Console.WriteLine($"5 - 5 * 5 = {BODMAS5(5, 5, 5, 2, 3)}");
            Console.WriteLine($"5 - 5 / 5 = {BODMAS5(5, 5, 5, 2, 4)}");
            Console.WriteLine($"5 * 5 + 5 = {BODMAS5(5, 5, 5, 3, 1)}");
            Console.WriteLine($"5 * 5 - 5 = {BODMAS5(5, 5, 5, 3, 2)}");
            Console.WriteLine($"5 * 5 * 5 = {BODMAS5(5, 5, 5, 3, 3)}");
            Console.WriteLine($"5 * 5 / 5 = {BODMAS5(5, 5, 5, 3, 4)}");
            Console.WriteLine($"5 / 5 + 5 = {BODMAS5(5, 5, 5, 4, 1)}");
            Console.WriteLine($"5 / 5 - 5 = {BODMAS5(5, 5, 5, 4, 2)}");
            Console.WriteLine($"5 / 5 * 5 = {BODMAS5(5, 5, 5, 4, 3)}");
            Console.WriteLine($"5 / 5 / 5 = {BODMAS5(5, 5, 5, 4, 4)}");
            



        }
        void PrintStatistic()
        {
            string fileName = "Statistic.txt";
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        //Same validation methods to test their implementation
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
                    else
                    {
                        throw new Exception("Invalid input");
                    }

                }
                catch (Exception ex)
                {


                    Console.WriteLine(ex);


                }
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
                    else
                    {
                        throw new Exception("Invalid input");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);

                }


            }
        }
    }
}
