using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        public static int[] RandomArray()
        {
            Random rand = new Random();
            int[] random_array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                random_array[i] = rand.Next(5,25);
            }
            var max = random_array[0];
            var min = random_array[0];
            var sum = 0;
            for (int j = 0; j < 10; j++)
            {
                sum += random_array[j];
                if (random_array[j] > max)
                {
                    max = random_array[j];
                }
                if (random_array[j] < min)
                {
                    min = random_array[j];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(sum);
            return random_array;
        }
        public static string TossCoin()
        {
            Console.WriteLine("Tossing a Coin!");
            Random toss = new Random();
            int toss_answer = toss.Next(1,3);
            string toss_result = "";
            if (toss_answer == 1)
            {
                toss_result = "Heads";
                Console.WriteLine(toss_result);
            }
            if (toss_answer == 2)
            {
                toss_result  = "Tails";
                Console.WriteLine(toss_result);
            }
            return toss_result;

        }
        public static double TossMultipleCoins(int num)
        {
            double heads = 0;
            double tails = 0;
            for (int i = 0; i < num; i++)
            {
                string outcome = TossCoin();
                if (outcome == "Heads")
                {
                    heads += 1;
                }
                if (outcome == "Tails")
                {
                    tails += 1;
                }
            }
            double ratio = (heads / tails);
            Console.WriteLine($"Ratio of {heads} heads to {tails} tails in {num} tosses is {ratio}");
            return ratio;
        }
        public static string[] Names()
        {
            string[] Names = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            Random rand = new Random();
            for (int i = 0; i < Names.Length; i++)
            {
                int idx = rand.Next(Names.Length);
                Names[i] = Names[idx];
            }
            List<string>OverFive = new List<string>();
            foreach (var name in Names)
            {
                if (name.Length > 5)
                {
                    OverFive.Add(name);
                }
            }
            Console.WriteLine(OverFive.ToArray());
            return OverFive.ToArray();
        }
        static void Main(string[] args)
        {
            RandomArray();
            string outcome = TossCoin();
            int num = 3;
            TossMultipleCoins(num);
            Names();
        }
    }
}
