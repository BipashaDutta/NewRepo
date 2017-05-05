//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="CompanyName">
//     Company copyright. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Task3
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
                ////Store arg 2nd string into array
                input[1] = input[1].Contains("\\n") ? input[1].Trim().Replace("\\n", ",") : input[1];
                string[] inputValues = input[1].Trim().Split(',');

                //// remove the 2nd string and replace with array
                input.RemoveAt(1);
                input.AddRange(inputValues);
                string output;

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
                            default:
                                output = "Please enter \"add\" ";
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
    }
}
