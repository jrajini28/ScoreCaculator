using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScoreCaculator;

namespace BowlingScore
{
    class Program
    {
        static void Main(string[] args)
        {
            BowlingScorecaculator s = new BowlingScorecaculator();
            int[] score= new int[20];
            Console.WriteLine("enter the no of games");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("enter the scores in "+(i+1)+" game");
                int firstChancehits = Convert.ToInt32(Console.ReadLine());
                int secondChancehits = Convert.ToInt32(Console.ReadLine());
                int thirdChancehits = Convert.ToInt32(Console.ReadLine());
                score[i] = s.finalscore(firstChancehits, secondChancehits, thirdChancehits);
            }
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("totalscore in "+(i+1)+" game is "+score[i]);
            }
        }
           
    }
}

