using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreCaculator
{
    public class BowlingScorecaculator
    {
        int scorein(int Chancehits,int score)
        {
            if (Chancehits > 0 && Chancehits < 7)
                score += 1;
            else if (Chancehits > 6 && Chancehits < 9)
                score += 2;
            return score;
        }
        public int finalscore(int firstChancehits, int secondChancehits, int thirdChancehits)
        {
            int score = 0;

            if (firstChancehits <= 9 && secondChancehits <= 9 && thirdChancehits <= 9)
            {
                if (firstChancehits == 9)
                {
                    score += 10;
                }
                else if (firstChancehits != 9 && secondChancehits == 9)
                {
                    score += 7+ scorein(firstChancehits, score);
                }
                else if (firstChancehits != 9 && secondChancehits != 9 && thirdChancehits == 9)
                {
                    score += 4+ scorein(firstChancehits, score)+ scorein(secondChancehits, score);
                }
                else
                {
                  score+=  scorein(firstChancehits,score)+scorein(secondChancehits, score)+scorein(thirdChancehits, score);
                }
            }
            return score;
        }

    }
}
