namespace EvenLines
{
    using System;
    using System.IO;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            string output = String.Empty;
            using (StreamReader read = new StreamReader(inputFilePath))
            {
                StringBuilder b = new StringBuilder();

                string[] arr = new string[] { "-", ",", ".", "!", "?" };
                int counter = 0;
                string s = "";
                while ((s=read.ReadLine()) != null)
                {
                    if (counter % 2 == 0)
                    {b.Append(s);
                        for (int i = 0; i < arr.Length; i++)
                        {
                            b=b.Replace(arr[i], "@");
                        }
                        string[] tempArr=b.ToString().Split();
                        Array.Reverse(tempArr);
                        b.Clear();
                        
                         output+=(String.Join(" ",tempArr)+"\n");
                        
                    }
                    counter++;
                }
            }
            return output;
        }
    }
}
