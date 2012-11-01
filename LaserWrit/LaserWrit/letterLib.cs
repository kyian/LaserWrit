﻿using System;
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
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));


            diction.Add(let, A);

            // B
            let = (char)((int)let + 1);
            A = new List<point>();
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));


            diction.Add(let, A);

            // C
            let = (char)((int)let + 1);
            A = new List<point>();
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));


            diction.Add(let, A);

            // d 
            let = (char)((int)let + 1);
            A = new List<point>();
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));


            diction.Add(let, A);

            // e
            let = (char)((int)let + 1);
            A = new List<point>();
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));


            diction.Add(let, A);

            // f
            let = (char)((int)let + 1);
            A = new List<point>();
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));


            diction.Add(let, A);

            // g
            let = (char)((int)let + 1);
            A = new List<point>();
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));


            diction.Add(let, A);

            // h
            let = (char)((int)let + 1);
            A = new List<point>();
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));


            diction.Add(let, A);

            // i
            let = (char)((int)let + 1);
            A = new List<point>();
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));


            diction.Add(let, A);

            // j
            let = (char)((int)let + 1);
            A = new List<point>();
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));


            diction.Add(let, A);

            // k
            let = (char)((int)let + 1);
            A = new List<point>();
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));


            diction.Add(let, A);

            // l
            let = (char)((int)let + 1);
            A = new List<point>();
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));


            diction.Add(let, A);

            // m
            let = (char)((int)let + 1);
            A = new List<point>();
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));


            diction.Add(let, A);

            // n
            let = (char)((int)let + 1);
            A = new List<point>();
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));


            diction.Add(let, A);

            // o
            let = (char)((int)let + 1);
            A = new List<point>();
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));


            diction.Add(let, A);

            // p
            let = (char)((int)let + 1);
            A = new List<point>();
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));


            diction.Add(let, A);

            // q
            let = (char)((int)let + 1);
            A = new List<point>();
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));


            diction.Add(let, A);

            // r
            let = (char)((int)let + 1);
            A = new List<point>();
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));


            diction.Add(let, A);

            // s
            let = (char)((int)let + 1);
            A = new List<point>();
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));


            diction.Add(let, A);

            // t
            let = (char)((int)let + 1);
            A = new List<point>();
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));


            diction.Add(let, A);

            // u
            let = (char)((int)let + 1);
            A = new List<point>();
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));


            diction.Add(let, A);

            // v
            let = (char)((int)let + 1);
            A = new List<point>();
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));


            diction.Add(let, A);

            // w
            let = (char)((int)let + 1);
            A = new List<point>();
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));


            diction.Add(let, A);

            // x
            let = (char)((int)let + 1);
            A = new List<point>();
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));


            diction.Add(let, A);

            // y
            let = (char)((int)let + 1);
            A = new List<point>();
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));


            diction.Add(let, A);

            // z
            let = (char)((int)let + 1);
            A = new List<point>();
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));
            A.Add(new point(3, 7));


            diction.Add(let, A);

            // [space]
            let = ' ';
            A = new List<point>();



            diction.Add(let, A);

           
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