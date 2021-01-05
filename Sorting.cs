using System;

namespace Sorting_Algorithms_AWESOME
{
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
            // maybe generate a new one everytime one is solved
        }

        public static void BubbleSort()
        {
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
        }

        public static void OnTimedEvent()
        {
            BubbleSort();
            //perform action
            //Console.Beep(); // works

            //na.iedere.actie.opnieuw.getekend

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
}
