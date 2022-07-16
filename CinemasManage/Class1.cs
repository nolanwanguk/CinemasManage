using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemasManage
{
    public class Solver
    {
        string[] labels = new string[3] { "A", "B", "C" };
        int curSeat = 0;
        int curRow = 1;
        int rows = 3;
        int seats = 5;
        public List<string> Reserve(int tickets)
        {
            List<string> reserve=new List<string> { };
            
            for(int i=0; i < tickets; i++)
            {
               
                curSeat++;
                if (curSeat > seats && curRow < rows)
                {
                    curSeat = curSeat % 5;
                    curRow++;
                }
                if (!isFinish())
                {
                    reserve.Add(String.Format("{0}{1}", labels[curRow - 1], curSeat));
                }
                
            }

            return reserve;
        }
        private bool isFinish()
        {
            return curSeat > seats && curRow >= rows;
        }
        
    }
}
