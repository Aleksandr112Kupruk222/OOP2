using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class Statistic
    {
        
        public Statistic(string Equation,string Time,int Tries,double Answear) 
        {
            //Writes players statistic in to the txt file 
            string fileName = "Statistic.txt";
            using (StreamWriter writer = new StreamWriter(fileName,true))
            {
                writer.WriteLine($"Equation:{Equation} || Time:{Time} || Tries:{Tries} || Correct Answear:{Answear}");
            }
        }
    }
}
