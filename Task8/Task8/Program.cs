﻿//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="CompanyName">
//     Company copyright. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Task8
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Main Program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args">Pass arguments from Comment prompt</param>
        public static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.Write("No inline parameters passed.");
            }
            else
            {
                List<string> input = new List<string>();
                foreach (var a in args)
                {
                    input.Add(a);
                }

                ////Split the given string into 2 array. 1st one is delimiter and 2nd one is the string with delimiter
                string[] splitValues = input[1].Split(new string[] { "\\\\" }, StringSplitOptions.RemoveEmptyEntries);
                ////Store arg 2nd string into array
                string[] inputValues = splitValues[0].Trim().Split(',');
                //// remove the 2nd string and replace with array
                input.RemoveAt(1);
                input.AddRange(inputValues);
                string output;

                bool flag = false;
                string negetiveValue = string.Empty;
                //// Check -ve value has been given or not
                for (int i = 1; i <= input.Count - 1; i++)
                {
                    if (Convert.ToDouble(input[i]) < 0)
                    {
                        if (negetiveValue == string.Empty)
                        {
                            negetiveValue = input[i];
                        }
                        else
                        {
                            negetiveValue = negetiveValue + "," + input[i];
                        }
                        flag = true;
                    }
                    else if (Convert.ToDouble(input[i]) > 1000)
                    {
                        input.RemoveAt(i);
                    }
                }
                if (flag == true)
                {
                    Console.WriteLine("Error: Negative numbers ({0}) not allowed. ", negetiveValue);
                    return;
                }

                switch (input.Count)
                {
                    case 1:
                        output = "0";
                        break;

                    case 2:
                        output = input[1];
                        break;

                    default:
                        switch (input[0])
                        {
                            case "add":
                                output = Addition(input).ToString();
                                break;
                            case "multiply":
                                output = multiply(input).ToString();
                                break;
                            default:
                                output = "Please enter add or multiply ";
                                break;
                        }

                        break;
                }

                Console.Write(output);
            }
        }

        /// <summary>
        /// Addition of numbers
        /// </summary>
        /// <param name="input">List of numbers to add</param>
        /// <returns>Result of addition</returns>
        public static double Addition(List<string> input)
        {
            double sum = 0;
            for (int i = 1; i <= input.Count - 1; i++)
            {
                sum += Convert.ToDouble(input[i]);
            }

            return sum;
        }

        /// <summary>
        /// multiply of numbers
        /// </summary>
        /// <param name="input">inputs of numbers</param>
        /// <returns>Return result</returns>
        static double multiply(List<string> input)
        {
            double mul = 1;
            for (int i = 1; i <= input.Count - 1; i++)
            {
                mul *= Convert.ToDouble(input[i]);
            }
            return mul;
        }

    }
}
