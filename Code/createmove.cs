using System;
using System.Collections.Generic;

using System.Text;

namespace Simple_Cute_Timer
{
    class createmove
    {
        string[] rndMove = new string[] { "R", "L", "F", "B", "U", "D" };

        List<string> arr = new List<string>();
        string[] Arr;
        Random r = new Random();

        public bool isslice(string move1, string move2)
        {
            int i = Convert.ToInt32(move1);
            int k = Convert.ToInt32(move2);
            if (i / 2 == k / 2)
            {
                return true;
            }
            else return false;

        }


        public bool checkmove(string tmpRnd)
        {
            Arr = arr.ToArray();

            if (Arr.Length > 0 && tmpRnd == Arr[Arr.Length - 1])
                return true;
            else
            {
                if (Arr.Length > 1 && tmpRnd == Arr[Arr.Length - 2] && isslice(tmpRnd, Arr[Arr.Length - 1]))
                    return true;
                else
                    return false;
            }

        }


        public string rndcube(int Max)
        {
            string move = "";
            string tmpRnd;
            Max++;
            for (int i = 0; i < Max; i++)
            {
                do
                {
                    tmpRnd = r.Next(6).ToString();
                    //radom.next(6)返回【0，5】的随机整数
                }
                while (checkmove(tmpRnd));
                arr.Add(tmpRnd);

            }

            for (int i = 0; i < Arr.Length; i++)
            {
                int tmp = r.Next(5);
                if (tmp == 4)
                { move += rndMove[Convert.ToInt32(Arr[i])] + "2"; }
                else if (tmp == 2 || tmp == 3)
                { move += rndMove[Convert.ToInt32(Arr[i])] + "'"; }
                else
                { move += rndMove[Convert.ToInt32(Arr[i])]; }
                move += " ";
            }
            return move;

        }


    }

}
