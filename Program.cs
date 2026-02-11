namespace StudentGarde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region StudentGrade
            int[] score = new int[5];

            for (int i = 0; i < score.Length; i++)
            {
                Console.WriteLine($"Enter Score For Student {i + 1}:");
                bool isTrue;
                do
                {
                    isTrue = int.TryParse(Console.ReadLine(), out score[i]);
                    break;
                } while (!isTrue);
            }


            for (int i = 0; i < score.Length; i++)
            {
                char result = Convert.ToChar(GetGrade(score[i]));
                Console.WriteLine($"Student {i + 1}:{score[i]} => Grade {result}");

            }

            double Avg = CalculateAverage(score);
            Console.WriteLine($"Average ={Avg} ");
            int min = score[0], max = score[0];
            GetMinMax(score, out min, out max);
            Console.WriteLine($"Highest Score={max}");
            Console.WriteLine($"Lowest Score={min}");

            #endregion


        }
        static char GetGrade(int score)
        {
            char result;
            if (score >= 90)
                result = 'A';
            else if (score >= 80)
                result = 'B';
            else if (score >= 70)
                result = 'C';
            else if (score >= 60)
                result = 'D';
            else
                result = 'F';

            return result;
        }

        static double CalculateAverage(int[] scores)
        {
            double sum = 0;
            foreach (int item in scores)
                sum += item;
            return sum / scores.Length;
        }

        static void GetMinMax(int[] scores, out int min, out int max)
        {
            min = scores[0];
            max = scores[0];
            foreach (int score in scores)
            {
                if (score < min)
                    min = score;
                if (score > max)
                    max = score;
            }
        }
    }

    enum studentGrade
    {
        A,
        B,
        C,
        D,
        F
    }
}
