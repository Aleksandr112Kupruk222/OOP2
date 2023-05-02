using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
        // Define a Card class with two properties
        
        public int Value { get; set;}
        public int Suit { get; set; }

         
        public Card(int s, int v)
        {
           
            // Set the suit property to the passed in value
            try
            {
                if (s > 0 && s <= 4)
                {
                    Suit = s;
                }
                else
                {
                    throw new Exception("Invalid value for Suit");
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }


            // Set the value property to the passed in value
            try
            {
                if (s > 0 && s <= 13)
                {
                    Value = v;
                }
                else
                {
                    throw new Exception("Invalid value for Value");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Method to display the card's suit and value
        public void show()
        {
            Console.WriteLine($"{Suit},{Value}"); // Output the card's suit and value to the console
        }
        

    }
}
