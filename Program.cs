using System;
using System.Threading;
using System.Timers;

namespace Sorting_Algorithms_AWESOME
{
    class Program
    {
        static void Main(string[] args)
        {
            Visualization.Initialize();
            Sorting.Initialize();
            while (true)
            {
                Thread.Sleep(1000);
            }
        }
    }

    public class Candle
    {
        int X        { get; set; }
        int Y        { get; set; }
        int value    { get; set; }
        string state { get; set; }
    }

    public class Sorting
    {
        public delegate void ActionPerformed();

        public static event ActionPerformed Action_Performed;

        public static System.Timers.Timer timer;

        public static void Initialize()
        {
            OnTimedEvent(); //starts sorting
            //timer = new System.Timers.Timer(10);
            //timer.Elapsed += OnTimedEvent;
            //timer.AutoReset = true;
            //timer.Start();
            //probably dont even want to use a timer
        }

        public static void OnTimedEvent()
        {
            //perform action
            //Console.Beep(); // works

            //na.iedere.actie.opnieuw.getekend

            int[] arr = Visualization.RandomIntegerArray;

            int buffer = 0;

            while (true) 
            {
                Console.Clear();
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        buffer = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = buffer;

                    }

                }
                Action_Performed?.Invoke();
            }
            //Action_Performed?.Invoke();
            /*
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        temp2 = arr[1];
                        arr[i + 1] = temp2;
                        arr[i] = temp;
                    }


                }
            }
            */


        }

    }


    public class Visualization
    {
        public static string Neutral        = "N";
        public static string BeingRead      = "R";
        public static string BeingWritten   = "W";

        public static int[] RandomIntegerArray;

        public static int    arraysize      = 100;
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
