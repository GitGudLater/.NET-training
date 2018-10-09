using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2variant
{
    class Program
    {
        static int[] ConverterNumbers(double number)
        {
            string length = Convert.ToString(number);
            int[] numbers = new int[length.Length];
            double buffer = 0;
            double count = length.Length - 1;
            for (int i = 0; i < length.Length; i++)
            {
                double alterpower = i;
                double power = -count;
                double leftnumber = Math.Truncate(number * Math.Pow(10, power));
                numbers[i] = Convert.ToInt32(leftnumber - buffer * Math.Pow(10, alterpower));
                buffer = Math.Truncate(number * Math.Pow(10, power));
                count--;
            }
            return numbers;
        }

        static int[] MultiplierArray(int[] number_matrix_1, int[] number_matrix_2)
        {
            int number2 = 0;
            int count2 = number_matrix_2.Length - 1;
            for (int i = 0; i < number_matrix_2.Length; i++)
            {
                number2 += Convert.ToInt32(number_matrix_2[i] * Math.Pow(10, count2));
                count2--;
            }
            int[] solution = new int[500];
            int count = 499;
            for (int i = number_matrix_1.Length - 1; i >= 0; i--)
            {
                solution[count] = number_matrix_1[i];
                count--;
            }
            int buffer = 0;
            int transfer = 0;
            for (int i = 499; i >= 0; i--)
            {
                transfer = (solution[i] * number2) + buffer;
                buffer = transfer / 10;
                solution[i] = transfer % 10;
                //Console.Write("{0} ", solution[i]);
            }
            return solution;
        }

        static void Main(string[] args)
        {
            //int[] solution = MultiplierArray(ConverterNumbers(99), ConverterNumbers(99));
            int[][] solution = new int[100][];
            solution [0] = MultiplierArray(ConverterNumbers(1),ConverterNumbers(1));
            for (int i = 1; i < 100; i++)
            {
                solution[i] = MultiplierArray(solution[i - 1], ConverterNumbers(i));
                int count = 0;
                Console.Write("{0} = ",i+1);
                for (int j = 0; j < solution[i].Length; j++)
                {
                    if (solution[i][j] == 0 && count == 0)
                    {
                        continue;
                    }
                    else if (solution[i][j] != 0 && count == 0)
                    {
                        count++;
                        Console.Write(solution[i][j]);
                    }
                    else
                    {
                        Console.Write(solution[i][j]);
                    }

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
