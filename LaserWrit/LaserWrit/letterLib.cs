using System;
using System.Collections.Generic;
/// <summary>
/// Library for turning letters into Galvo coords
/// </summary>

namespace LaserWrit
{
    public class point
    {
        public int x;
        public int y;

        public point(){
            x = 0;
            y = 0;
        }

        public point(int xin, int yin)
        {
            x = xin;
            y = yin;
        }


    }
    public class letterLib
    {
        public Dictionary<char, List<point>> diction;
        public int xMaxPerLet = 20;
        public letterLib()
        {
            //
            // 
            //
            diction = new Dictionary<char,List<point> >();
            char let = 'A';


            // A
            List<point> A = new List<point>();
            A.Add(new point(3, 7));

            diction.Add(let, A);

/*
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

 */
           
        }

        public Queue<byte> genBytes(point pin)
        {
            Queue<byte> temp = new Queue<byte>();


            //256 x16
            int a, b, c;
            a = pin.x / 16;
            b = pin.x%256 * 16;
            b += pin.y / 256;
            c = pin.y%256;


            temp.Enqueue((byte)a);
            temp.Enqueue((byte)b);
            temp.Enqueue((byte)c);

            return temp;
        }
    }
}