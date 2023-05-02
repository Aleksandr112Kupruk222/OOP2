using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class Pack
    {
        

        static Random _random = new Random();
        protected static List<Card> pack =  new List<Card>();
        protected string Equation;
        static int j;
       
        public Pack()
        {
            j = 0;  
            //Initialise the card pack here
            for (int i = 1; i <= 4; i++) 
            {
                for (int x = 1; x < 14; x++)
                {
                    pack.Add(new Card(i,x));
                    
                }   
            }
            shuffleCardPack();
           

        }
        static bool shuffleCardPack()
        {
            //Shuffles the pack based on the type of shuffl
            int n = pack.Count;
            for (int i = 0; i < (n - 1); i++)
            {
                int r = i + _random.Next(n - i);
                var t = pack[r];
                pack[r] = pack[i];
                pack[i] = t;
            }
            return true;
            //Show()

        }
        protected static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            List<Card> cards = new List<Card>();
            for (int i = 0; i < amount; i++)
            {
                cards.Add(pack[i]);

            }
            return cards;

        }
        // Calculates the result of a given operation between two float values
        protected float Calculate(float v1, float v2, int op1) 
        {
            
            float result;
            switch (op1) 
            {
                case 1:
                    result = v1 + v2; break;
                case 2:
                    result = v1 - v2; break;
                case 3:
                    result = v1 * v2; break;
                case 4:
                    result = v1 / v2; break;
                default: 
                    result = 0; break;
            }
            return result;
        }
        // Calculates the result of a given set of operations between three float values, using BODMAS order of operations
        protected float BODMAS5(float v1, float v2, float v3, int op1, int op2) 
        {
            float midRes;
            float finalRes;
            if (op1 >= op2) 
            { 
                midRes = Calculate(v1, v2, op1);
                finalRes = Calculate(midRes, v3, op2);
                return finalRes;
            }
            else 
            {
                midRes = Calculate(v2, v3, op2);
                finalRes = Calculate(v1, midRes, op1);
                return finalRes;
            }
        }
        // Returns a string representation of a given arithmetic operation
        string OpToString(int op1) 
        {
            string op;
            switch (op1)
            {
                case 1:
                    op = "+"; break;
                case 2:
                    op = "-"; break;
                case 3:
                    op = "*"; break;
                case 4:
                    op = "/"; break;
                default:
                    op = ""; break;
            }
            return op;
        }
        // Prints an equation with 3 cards
        void PrintEquation(float v1, float v2, int op1) 
        {
            Equation = $"{v1} {OpToString(op1)} {v2}";
            Console.WriteLine(Equation);
        }
        // Prints an equation with 5 cards 
        protected void PrintEquation(float v1, float v2, float v3, int op1, int op2)
        {
            
            Equation = $"{v1} {OpToString(op1)} {v2} {OpToString(op2)} {v3}";
            Console.WriteLine(Equation);

        }
        // Generates and solves an equation using a set of 3 cards and returns the result
        public virtual double GetEquation()
        {
            float res;
            List<Card> Cardslist = dealCard(3);

            PrintEquation(Cardslist[0].Value, Cardslist[1].Value, Cardslist[2].Suit);

            res = Calculate(Cardslist[0].Value, Cardslist[1].Value, Cardslist[2].Suit);

            double RoundedRes = Math.Round(res, 2);

            Console.WriteLine($"Answear:{RoundedRes}");
            return RoundedRes;

        }
        // Records the statistics of a solved equation, such as time taken and number of attempts
        public virtual void Record(string Time, int Tries, double answear) 
        {
            Console.WriteLine($"Time:{ Time} || Tries:{ Tries}");
            Statistic stat = new Statistic(Equation,Time,Tries,answear);
        }
    }
}

