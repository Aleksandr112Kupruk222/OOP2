using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{

    sealed class Bodmas5 : Pack
    {

        // Generates and solves an equation using a set of 5 cards and returns the result
        public override double GetEquation()
        { 
            float res;
            List<Card> Cardslist = dealCard(5);

            PrintEquation(Cardslist[0].Value, Cardslist[1].Value, Cardslist[2].Value, Cardslist[3].Suit, Cardslist[4].Suit);

            res = BODMAS5(Cardslist[0].Value, Cardslist[1].Value, Cardslist[2].Value, Cardslist[3].Suit, Cardslist[4].Suit);

            double RoundedRes = Math.Round(res, 2);

            Console.WriteLine($"Answear:{RoundedRes}");
            return RoundedRes;
        }
        // Record the game statistics including time, number of tries, and answer
        public override void Record(string Time, int Tries, double answear)
        {
            Console.WriteLine($"Time:{Time} || Tries:{Tries}");
            Statistic stat = new Statistic(Equation, Time, Tries, answear);
        }
    }
}
