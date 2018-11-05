using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hometask14.Models
{
    public class Calculations
    {
        public double NumberA { get; set; }

        public double NumberB { get; set; }

        public double NumberC { get; set; }

        public double X1 { get; set; }

        public double X2 { get; set; }

        public char Solution { get; set; }

        public string Complex { get; set; }

        public double GetSum(double a,double b)
        {
            return a + b;
        }

        public double GetDiff(double a,double b)
        {
            return a - b;
        }

        public double GetMultiply(double a,double b)
        {
            return a * b;
        }

        public double GetDeg(double a,double b)
        {
            return a / b;
        }

        public double GetPower(double a, double power)
        {
            return Math.Pow(a, power);
        }

        private double GetD(double a,double b,double c)
        {
            return (Math.Pow(b, 2) - (4 * a * c));
        }

        public void GetX (double a,double b,double c)
        {
            double D = GetD(a, b, c);
            if(D>0)
            {
                X1 = ((-b) + Math.Sqrt(D)) / (2 * a);
                X2 = ((-b) - Math.Sqrt(D)) / (2 * a);
            }
            else if(D==0)
            {
                X1 = (-b)  / (2 * a);
                X2 = X1;
            }
            else
            {
                double firstnumber = -b / (2 * a);
                double secondnumber = Math.Sqrt(-D) / (2 * a);
                Complex = Convert.ToString(firstnumber) + " +(-) " + Convert.ToString(secondnumber)+"*i";
            }
        }

        public double GetNumber(int a, int b)
        {
            Random random = new Random();
            return random.Next(a, b);
        }

        public void GetPolynomSolution()
        {
            X2 = ((Math.Pow(X1,2)*NumberA)+(X1*NumberB)+NumberC);
        }

        public void GetTask()
        {
            if( NumberB == 1)
            {
                Solution = '+';
            }
            else if(NumberB==2)
            {
                Solution = '-';
            }
            else if(NumberB==3)
            {
                Solution = '*';
            }
            else
            {
                Solution = '/';
            }
        }

        public void GetAnsver()
        {
            if(X1==X2)
            {
                Complex = "true";
            }
            else
            {
                Complex = "false";
            }
        }
    }
}