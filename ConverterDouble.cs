using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_23_Convert
{
    internal static class ConverterDouble
    {
        public static double GetDouble(string value)
        {
            bool negative = false;

            var lists = SearchForNumbers(ref negative, Encoding.Default.GetBytes(value));

            var doubles = GetArrayDouble(lists);

            double valueDoble = default(double);

            if (doubles[doubles.Length - 1] == 999)
            {
                return 0;
            }



            foreach (var item in doubles)
            {
                valueDoble += item;
            }

            if (negative)
            {
                return -valueDoble;
            }
            else
            {

                return valueDoble;
            }

        }


        private static double[] GetArrayDouble((List<int>, List<int>) value)
        {
            int cout = value.Item1.Count + value.Item2.Count;

            double[] doubles = new double[cout];

            try
            {
                for (int i = 0; i < cout; i++)
                {

                    if (value.Item1.Count > i)
                    {
                        checked
                        {
                            doubles[i] = value.Item1[i] * GetNaturalNumbers(value.Item1.Count - (i + 1));
                        }
                    }
                    else
                    {
                        checked
                        {
                            doubles[i] = value.Item2[i - value.Item1.Count] * GetNumbersAfterPoint((i - value.Item1.Count) + 1);
                        }
                    }
                }
            }
            catch (Exception)
            {
                doubles[doubles.Length - 1] = 999;
            }

            return doubles;
        }

        private static (List<int>, List<int>) SearchForNumbers(ref bool negative, byte[] bytes)
        {
            bool afterPoint = false;
            bool beginning = true;

            List<int> naturalNumbers = new List<int>();

            List<int> numbersAfterPoint = new List<int>();

            foreach (byte b in bytes)
            {
                switch (b)
                {
                    case 48:
                        if (afterPoint)
                        {
                            numbersAfterPoint.Add(0);
                        }
                        else
                        {
                            naturalNumbers.Add(0);
                        }
                        beginning = false;
                        break;

                    case 49:
                        if (afterPoint)
                        {
                            numbersAfterPoint.Add(1);
                        }
                        else
                        {
                            naturalNumbers.Add(1);
                        }
                        beginning = false;
                        break;

                    case 50:
                        if (afterPoint)
                        {
                            numbersAfterPoint.Add(2);
                        }
                        else
                        {
                            naturalNumbers.Add(2);
                        }
                        beginning = false;
                        break;

                    case 51:
                        if (afterPoint)
                        {
                            numbersAfterPoint.Add(3);
                        }
                        else
                        {
                            naturalNumbers.Add(3);
                        }
                        beginning = false;
                        break;

                    case 52:
                        if (afterPoint)
                        {
                            numbersAfterPoint.Add(4);
                        }
                        else
                        {
                            naturalNumbers.Add(4);
                        }
                        beginning = false;
                        break;

                    case 53:
                        if (afterPoint)
                        {

                            numbersAfterPoint.Add(5);
                        }
                        else
                        {
                            naturalNumbers.Add(5);
                        }
                        beginning = false;
                        break;

                    case 54:
                        if (afterPoint)
                        {
                            numbersAfterPoint.Add(6);
                        }
                        else
                        {
                            naturalNumbers.Add(6);
                        }
                        beginning = false;
                        break;

                    case 55:
                        if (afterPoint)
                        {
                            numbersAfterPoint.Add(7);
                        }
                        else
                        {
                            naturalNumbers.Add(7);
                        }
                        beginning = false;
                        break;

                    case 56:
                        if (afterPoint)
                        {
                            numbersAfterPoint.Add(8);
                        }
                        else
                        {
                            naturalNumbers.Add(8);
                        }
                        beginning = false;
                        break;

                    case 57:
                        if (afterPoint)
                        {
                            numbersAfterPoint.Add(9);
                        }
                        else
                        {
                            naturalNumbers.Add(9);
                        }
                        beginning = false;
                        break;

                    case 46:
                        afterPoint = true;
                        break;

                    case 44:
                        afterPoint = true;
                        break;

                    case 45:
                        if (beginning)
                        {
                            negative = true;
                        }

                        break;
                }
            }

            return (naturalNumbers, numbersAfterPoint);

        }

        private static double GetNaturalNumbers(int count)
        {
            int value = 1;

            for (int i = 0; i < count; i++)
            {
                checked
                {
                    value *= 10;
                }
            }

            return value;
        }

        private static double GetNumbersAfterPoint(int count)
        {
            double value = 1.0;

            for (int i = 0; i < count; i++)
            {
                value *= 0.1;
            }

            if (count <= 15)
            {
                return Math.Round(value, count);
            }
            else
            {
                return value;
            }
        }
    }
}
