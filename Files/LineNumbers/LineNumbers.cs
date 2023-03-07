namespace LineNumbers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
          string[] arr= File.ReadAllLines(inputFilePath);
            string[] output= new string[arr.Length];
            for (int i=0;i<arr.Length;i++)
            {
                StringBuilder builder= new StringBuilder(arr[i]);
                int letters = 0, symbols=0;
                foreach (char item in builder.ToString())
                {
                    if (Char.IsLetter(item))
                    {
                        letters++;
                    }
                    else if (item != ' ')
                        symbols++;
                }
                
                builder.Insert(0, "Line " + i+1+": ");
                builder.Append($" ({letters})({symbols})");
                output[i] = builder.ToString();
            }
            
            File.WriteAllLines(outputFilePath, output);
        }
    }
}
