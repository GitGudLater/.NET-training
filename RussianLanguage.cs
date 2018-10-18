using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_1
{
    class Program
    {
        public static string ClassicSchool(string text)
        {
            char[] aLetters = { 'у', 'е', 'ы', 'а', 'о', 'э', 'я', 'и', 'ю', 'ё' };
            char[] bLetters = { 'ъ', 'ь' };
            char special = 'й';
            string[] stringFromText = text.Split(new char[] { ' ' });
            string solution = null;
            for (int i = 0; i < text.Length - 2; i++)
            {
                solution += text[i];
                if (solution[i] == special)
                {
                    int count = 0;
                    for (int k = 0; k < aLetters.Length; k++)
                    {
                        if(text[i+1]==aLetters[k])
                        {
                            count++;
                        }
                        if (text[i + 1] != ' ' && text[i + 2] == aLetters[k])
                        {
                            count++;
                        }

                    }
                    if (count > 0)
                    {
                        solution += '-';
                    }
                }
                for (int k = 0; k < bLetters.Length; k++)
                {
                    int count = 0;
                    if (text[i] == bLetters[k] && text[i + 1] != ' ')
                    {
                        for (int a = 0; a < aLetters.Length; a++)
                        {
                            if (text[i + 1] == aLetters[a])
                            {
                                count++;
                            }
                            if (text[i + 1] != ' ' && text[i + 2] == aLetters[a])
                            {
                                count++;
                            }
                        }
                        if (count > 0)
                        {
                            solution += '-';
                        }
                    }
                }
                for (int k = 0; k < aLetters.Length; k++)
                {
                    if (text[i] == aLetters[k] && text[i + 1] != ' ' && text[i + 2] != ' ')
                    {
                        int count = 0;
                        for (int l = 0; l < bLetters.Length; l++)
                        {
                            if (text[i + 2] == bLetters[l])
                                count++;
                        }
                        if (text[i + 1] == special)
                        {
                            count++;
                        }
                        if (count == 0)
                        {
                            solution += "-";
                        }

                    }
                }

            }
            for (int i = 0; i < text.Length - 2; i++)
            {

            }
            solution += text[text.Length - 2];
            solution += text[text.Length - 1];
            return solution;

        }
        static void Main(string[] args)
        {
            ///char[] bLetters = { 'р', 'л', 'м', 'н', 'й' };
            string text = Console.ReadLine();
            Console.WriteLine(ClassicSchool(text));
            Console.ReadLine();
        }
    }
}

