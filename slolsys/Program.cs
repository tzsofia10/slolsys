using System;
using System.Collections.Generic;
using System.IO;

namespace slolsys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ora>bolygok=new List<ora>();
            var sr = new StreamReader(
                path: @"..\..\..\solsys.txt",
                encoding: System.Text.Encoding.UTF8
                );
            while ( !sr.EndOfStream ) {
                var sor = new ora(sr.ReadLine());
                bolygok.Add(sor);
            }
            Console.WriteLine($"3.1: {bolygok.Count} bolygó van a naprendszerben");

            int hold = 0;
            foreach (var ora in bolygok)
            {
                hold += ora.holdszam;
            }
            Console.WriteLine($"3.2: A naprendszerben egy bolygónak átlagosan: {hold/bolygok.Count} holdja van.");

            double maximum = 0;
            int ind = 0;
            for (int i = 0; i < bolygok.Count; i++) 
            {
                if (bolygok[i].bolygoter>maximum)
                {
                    maximum = bolygok[i].bolygoter;
                    ind = i;
                }
            }
            Console.WriteLine( $"3.3: A legnagyobb térfogatú bolygó: {bolygok[ind].name}" );

            Console.WriteLine("3.4: Írd be a keresett bolygó nevét");
            string kulcs = Console.ReadLine();
            bool igen = false;
            foreach (var ora in bolygok)
            {
                if (ora.name == kulcs)
                {
                    igen = true;

                }
            }
                if (igen)
                {
                    Console.WriteLine("van a listában");
                }
                else
                {
                Console.WriteLine( "nincs ilyen a listában.");
            }
            Console.WriteLine("3.5: írj be egy egész számot" );
            int szam= Convert.ToInt32( Console.ReadLine() );
            foreach (var ora in bolygok)
            {
                if (szam > ora.holdszam)
                {
                    Console.WriteLine(ora.name);
                }
            }
        }
    }
}