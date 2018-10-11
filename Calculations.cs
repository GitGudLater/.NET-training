using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_Hometask
{
    class Calculations
    {
        private static int[] firstNumber;
        private static int[] secondNumber;
        private static int signOfNumber1;
        private static int signOfNumber2;
        private static bool firstBiggerThanSecond;

        static int[] ConverterNumbers(double number)
        {
            string length = Convert.ToString(number);
            int[] numbers = new int[length.Length];
            for (int i = 0; i < length.Length; i++)
            {
                numbers[i] = (int)Char.GetNumericValue(length[i]);
            }
            return numbers;
        }

        public Calculations(double number1, double number2)
        {
            if (number1 > 0)
            {
                firstNumber = ConverterNumbers(number1);
                signOfNumber1 = 1;
            }
            else
            {
                firstNumber = ConverterNumbers(number1*(-1));
                signOfNumber1 = -1;
            }
            if (number2 > 0)
            {
                secondNumber = ConverterNumbers(number2);
                signOfNumber2 = 1;
            }
            else
            {
                secondNumber = ConverterNumbers(number2 * (-1));
                signOfNumber2 = -1;
            }
            if(Math.Abs(number1)>Math.Abs(number2))
            {
                firstBiggerThanSecond=true;
            }
            else
            {
                firstBiggerThanSecond=false;
            }
        }

        public int GetFirstSign
        {
            get { return signOfNumber1; }
        }

        public int GetSecondSign
        {
            get { return signOfNumber2; }
        }

        public int[] GetFirstNumber
        {
            get { return firstNumber; }
        }

        public int[] GetSecondNumber
        {
            get { return secondNumber; }
        }

        private bool GetRelation
        {
            get { return firstBiggerThanSecond; }
        }

        public int[] Multiply(int[] number_matrix_1, int[] number_matrix_2,int firstSign,int secondSign)
        {
            Console.WriteLine("Произведение");
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
                transfer = (solution[i] * number_matrix_2[number_matrix_2.Length - 1]) + buffer;
                buffer = transfer / 10;
                solution[i] = transfer % 10;
            }
            int countI = 0;
            int[] reestr = new int[500];
            for (int j = number_matrix_2.Length - 2; j >= 0; j--)
            {
                int [] subSolution = new int[500];
                int subcount =498-countI;
                for (int i = number_matrix_1.Length - 1; i >= 0; i--)//!!!!!!!!
                {
                    subSolution[subcount] = number_matrix_1[i];
                    subcount--;
                }
                countI++;
                int subMultBuffer = 0;
                int subMultTransfer = 0;
                for (int i = 499; i >= 0; i--)
                {
                        subMultTransfer = (subSolution[i] * number_matrix_2[j]) + subMultBuffer;
                        subMultBuffer = subMultTransfer / 10;
                        subSolution[i] = subMultTransfer % 10;
                }
                int subbuffer = 0;
                int subtransfer = 0;
                for (int i = 499; i >= 0; i--)
                {
                    subtransfer = solution[i] + subSolution[i] + subbuffer;
                    subbuffer = subtransfer / 10;
                    solution[i] = subtransfer % 10;
                }
            }
            int n_count = 0;
            for (int i = 0; i < solution.Length; i++)
            {
                if (solution[i] == 0 && n_count == 0)
                {
                    continue;
                }
                else if (solution[i] != 0 && n_count == 0)
                {
                    n_count++;
                }
                else
                {
                    n_count++;
                }
            }
            Console.WriteLine();
            int finalsign = firstSign * secondSign;
            Console.WriteLine("{0} * ",finalsign);
            int[] final_solution = new int[n_count];
            for (int i = 0; i < n_count; i++)
            {
                final_solution[i] = solution[solution.Length - n_count + i];
                Console.Write("{0} ",final_solution[i]);
            }
            return final_solution;
        }


        private int[] SubSum(int[] number_matrix_1, int[] number_matrix_2,int finalSign)
        {
            int[] solution = new int[500];
            int[] subsolution = new int[500];
            int count = 499;
            for (int i = number_matrix_1.Length - 1; i >= 0; i--)
            {
                solution[count] = number_matrix_1[i];
                count--;
            }
            count = 499;
            for (int i = number_matrix_2.Length - 1; i >= 0; i--)
            {
                subsolution[count] = number_matrix_2[i];
                count--;
            }
            int buffer = 0;
            int transfer = 0;
            count = 499;
            for (int i = 499; i >= 0; i--)
            {
                transfer = (solution[i] + subsolution[i]) + buffer;
                buffer = transfer / 10;
                solution[i] = transfer % 10;
            }
            int n_count = 0;
            for (int i = 0; i < solution.Length; i++)
            {
                if (solution[i] == 0 && n_count == 0)
                {
                    continue;
                }
                else if (solution[i] != 0 && n_count == 0)
                {
                    n_count++;
                }
                else
                {
                    n_count++;
                }
            }
            Console.WriteLine();
            finalSign = finalSign/2;
            Console.WriteLine("({0}) * ", finalSign);
            int[] final_solution = new int[n_count];
            for (int i = 0; i < n_count; i++)
            {
                final_solution[i] = solution[solution.Length - n_count + i];
                Console.Write("{0} ", final_solution[i]);
            }
            return final_solution;

        }

        private int[] SubDifference(int[] number_matrix_1, int[] number_matrix_2,int finalSign)
        {
            int[] solution = new int[500];
            int[] subsolution = new int[500];
            int count = 499;
            for (int i = number_matrix_1.Length - 1; i >= 0; i--)
            {
                solution[count] = number_matrix_1[i];
                count--;
            }
            count = 499;
            for (int i = number_matrix_2.Length - 1; i >= 0; i--)
            {
                subsolution[count] = number_matrix_2[i];
                count--;
            }
            int buffer = 0;
            int transfer = 0;
            count = 499;
            for (int i = 499; i >= 0; i--)
            {
                transfer = (solution[i] - subsolution[i]) - buffer;
                buffer = transfer / 10;
                if (buffer < 0)
                {
                    buffer = -buffer;
                }
                if (transfer < 0)
                {
                    transfer = -transfer;
                }
                solution[i] = transfer % 10;
            }
            int n_count = 0;
            for (int i = 0; i < solution.Length; i++)
            {
                if (solution[i] == 0 && n_count == 0)
                {
                    continue;
                }
                else if (solution[i] != 0 && n_count == 0)
                {
                    n_count++;
                }
                else
                {
                    n_count++;
                }
            }
            Console.WriteLine("{0} * ", finalSign);
            int[] final_solution = new int[n_count];
            for (int i = 0; i < n_count; i++)
            {
                final_solution[i] = solution[solution.Length - n_count + i];
                Console.Write("{0} ", final_solution[i]);
            }
            return final_solution;
        }

        public int[] Sum(int[] number_matrix_1, int[] number_matrix_2, int firstSign,int secondSign)
        {
            int finalsign = firstSign + secondSign;
            int[] final_solution = new int[1];
            Console.WriteLine("Сумма");
            if (finalsign == -2 || finalsign == 2)
            {
                final_solution = SubSum(number_matrix_1, number_matrix_2,finalsign);
            }
            else 
            {
                if (GetRelation == true)
                {
                    finalsign = -1;
                }
                else
                {
                    finalsign = 1;
                }
                final_solution = SubDifference(number_matrix_1, number_matrix_2, finalsign);
            }
            return final_solution;
        }

        public int[] Difference(int[] number_matrix_1, int[] number_matrix_2, int firstSign, int secondSign)
        {
            int finalsign = firstSign - secondSign;
            Console.WriteLine("Разность");
            int[] final_solution = new int[1];
            if (finalsign == -2 || finalsign == 2)
            {
                final_solution = SubSum(number_matrix_1, number_matrix_2,finalsign);
            }
            else if (secondSign>firstSign)
            {
                if (GetRelation == true)
                {
                    finalsign = 1;
                }
                else
                {
                    finalsign = -1;
                }
                final_solution = SubDifference(number_matrix_2, number_matrix_1, finalsign);
            }
            else 
            {
                if (GetRelation == true)
                {
                    finalsign = 1;
                }
                else
                {
                    finalsign = -1;
                }
                final_solution = SubDifference(number_matrix_1, number_matrix_2, finalsign);
            }
            return final_solution;
        }
    }
}
