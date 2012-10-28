using System;
using System.Collections.Generic;

/// <summary>
/// Library for turning letters into Galvo coords
/// </summary>

namespace LaserWrit
{
    public class letterLib
    {
        public Dictionary<char, List<byte>> diction;
        public letterLib()
        {
            //
            // 
            //
            diction = new Dictionary<char,List<byte> >();
            char let = 'A';


            // A
            List<byte> A = new List<byte>();
            A.Add(0);
            A.Add(0);
            A.Add(0);

            A.Add(255);
            diction.Add(let, A);

            // B
            let = (char)((int)let + 1);
            A = new List<byte>();
            A.Add(1);
            A.Add(1);
            A.Add(1);

            A.Add(255);
            diction.Add(let, A);

            // C
            let = (char)((int)let + 1);
            A = new List<byte>();
            A.Add(2);
            A.Add(2);
            A.Add(2);

            A.Add(255);
            diction.Add(let, A);

            // D
            let = (char)((int)let + 1);
            A = new List<byte>();
            A.Add(2);
            A.Add(2);
            A.Add(2);

            A.Add(255);
            diction.Add(let, A);

            // E
            let = (char)((int)let + 1);
            A = new List<byte>();
            A.Add(2);
            A.Add(2);
            A.Add(2);

            A.Add(255);
            diction.Add(let, A);

            // F
            let = (char)((int)let + 1);
            A = new List<byte>();
            A.Add(2);
            A.Add(2);
            A.Add(2);

            A.Add(255);
            diction.Add(let, A);

            // G
            let = (char)((int)let + 1);
            A = new List<byte>();
            A.Add(2);
            A.Add(2);
            A.Add(2);

            A.Add(255);
            diction.Add(let, A);

            // H
            let = (char)((int)let + 1);
            A = new List<byte>();
            A.Add(2);
            A.Add(2);
            A.Add(2);

            A.Add(255);
            diction.Add(let, A);

            //I

            let = (char)((int)let + 1);
            A = new List<byte>();
            A.Add(2);
            A.Add(2);
            A.Add(2);

            A.Add(255);
            diction.Add(let, A);

            // J
            let = (char)((int)let + 1);
            A = new List<byte>();
            A.Add(2);
            A.Add(2);
            A.Add(2);

            A.Add(255);
            diction.Add(let, A);

            // K
            let = (char)((int)let + 1);
            A = new List<byte>();
            A.Add(2);
            A.Add(2);
            A.Add(2);

            A.Add(255);
            diction.Add(let, A);

            // L
            let = (char)((int)let + 1);
            A = new List<byte>();
            A.Add(2);
            A.Add(2);
            A.Add(2);

            A.Add(255);
            diction.Add(let, A);

            // M
            let = (char)((int)let + 1);
            A = new List<byte>();
            A.Add(2);
            A.Add(2);
            A.Add(2);

            A.Add(255);
            diction.Add(let, A);

            // N
            let = (char)((int)let + 1);
            A = new List<byte>();
            A.Add(2);
            A.Add(2);
            A.Add(2);

            A.Add(255);
            diction.Add(let, A);

            // O
            let = (char)((int)let + 1);
            A = new List<byte>();
            A.Add(2);
            A.Add(2);
            A.Add(2);

            A.Add(255);
            diction.Add(let, A);

            // P
            let = (char)((int)let + 1);
            A = new List<byte>();
            A.Add(2);
            A.Add(2);
            A.Add(2);

            A.Add(255);
            diction.Add(let, A);

            // Q
            let = (char)((int)let + 1);
            A = new List<byte>();
            A.Add(2);
            A.Add(2);
            A.Add(2);

            A.Add(255);
            diction.Add(let, A);

            // R
            let = (char)((int)let + 1);
            A = new List<byte>();
            A.Add(2);
            A.Add(2);
            A.Add(2);

            A.Add(255);
            diction.Add(let, A);

            // S
            let = (char)((int)let + 1);
            A = new List<byte>();
            A.Add(2);
            A.Add(2);
            A.Add(2);

            A.Add(255);
            diction.Add(let, A);

            // T
            let = (char)((int)let + 1);
            A = new List<byte>();
            A.Add(2);
            A.Add(2);
            A.Add(2);

            A.Add(255);
            diction.Add(let, A);

            // U
            let = (char)((int)let + 1);
            A = new List<byte>();
            A.Add(2);
            A.Add(2);
            A.Add(2);

            A.Add(255);
            diction.Add(let, A);

            // V
            let = (char)((int)let + 1);
            A = new List<byte>();
            A.Add(2);
            A.Add(2);
            A.Add(2);

            A.Add(255);
            diction.Add(let, A);

            // W
            let = (char)((int)let + 1);
            A = new List<byte>();
            A.Add(2);
            A.Add(2);
            A.Add(2);

            A.Add(255);
            diction.Add(let, A);

            // X
            let = (char)((int)let + 1);
            A = new List<byte>();
            A.Add(2);
            A.Add(2);
            A.Add(2);

            A.Add(255);
            diction.Add(let, A);

            // Y
            let = (char)((int)let + 1);
            A = new List<byte>();
            A.Add(2);
            A.Add(2);
            A.Add(2);

            A.Add(255);
            diction.Add(let, A);

            // Z
            let = (char)((int)let + 1);
            A = new List<byte>();
            A.Add(2);
            A.Add(2);
            A.Add(2);

            A.Add(255);
            diction.Add(let, A);

            // [space]
            A = new List<byte>();
            A.Add(254);
            A.Add(254);
            A.Add(254);

            A.Add(255);
            diction.Add(' ', A);
        }

        private List<byte> genBytes(int posx, int posy)
        {
            // Todo
            return new List<byte>();

        }
    }
}