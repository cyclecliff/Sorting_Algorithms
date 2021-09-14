using System;

namespace Sorting_Algorithms_AWESOME
{
    public class Visualization
    {
        public static string Neutral        = "N";
        public static string BeingRead      = "R";
        public static string BeingWritten   = "W";

        public static int[] RandomIntegerArray;

        internal static void SijmenIsTheBest()
        {
            Console.WriteLine("");
        }

        public static int    arraysize      = 140;
        public static int    maxheight      = 90;

        public static int                 X = 0;
        public static int                 Y = maxheight;
        public static void Initialize()
        {
            Console.CursorVisible = false;
            //DRAW A STANDARD FRAME IN WHICH THE SORTING WILL TAKE PLACE
            //Console.WriteLine(ReturnsCandle(Neutral, 20));
            Sorting.Action_Performed += OnActionPerformed;
            GenerateRandomIntegerArray(arraysize, maxheight);
            //DrawCandle(candle1);
            //Console.WriteLine("xxxxx");
          //  DrawBaseLine(arraysize, maxheight);
            DrawCandles();
        }

        //draw all candles from the array

        public static void DrawCandles()
        {
            for(int i = 0; i < RandomIntegerArray.Length; i++)
            {
                Console.SetCursorPosition(X, Y);
                DrawCandle(MakeCandle(Neutral, RandomIntegerArray[i]));
                X++;
                //Console.Write(RandomIntegerArray[i]);
            }
            X = 0;
            //Console.Clear();
        }
       

        public static void GenerateRandomIntegerArray(int arraysize, int maxheight) //succesfully creates a fixed array of randomly generated, non-unique integers with a  maximum value of "maxheight"
        {
            RandomIntegerArray = new int[arraysize];
            Random random = new Random();
            for(int i = 0; i < arraysize; i++)
            {
                RandomIntegerArray[i] = random.Next(0, maxheight);
            }
            //Console.WriteLine(randomints);
            //return randomints;
        }

        public static void DrawBaseLine(int arraysize, int maxheight) //317 is the max size
        { 
            for(int i = 0; i < arraysize; i++)
            {
                Console.SetCursorPosition(i, maxheight); //(X <->, Y \/-/\)
                Console.Write("_");
            }

        }
        
        //gebruik ipv console >  System.Drawing
        public static void DrawChar(string letter)
        {
            Console.Write(letter);
        }

        public static void DrawCandle(string[] candle)
        {
            foreach(string letter in candle)
            {
                Console.SetCursorPosition(X, Y);
                //DrawChar(letter);
                Console.Write(letter);
                Y--;
            }
            Y = maxheight;
        }

        public static string[] candle1 = MakeCandle(Neutral, 20);

        public static string[] MakeCandle(string character, int height)
        {
            string[] candle = new string[height];

            for(int i = 0; i < height; i++)
            {
                candle[i] = character;
            }

            return candle;
        }

        public static void OnActionPerformed()
        {
            DrawCandles();
        }


    }    
}
