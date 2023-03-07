namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            string[] files=Directory.GetFiles(inputFolderPath);
            
            SortedDictionary<string, List<FileInfo>> pathsAndStuff = new SortedDictionary<string, List<FileInfo>>();
            for (int i = 0; i < files.Length; i++)
            {
                FileInfo info = new FileInfo(files[i]);
                if (!pathsAndStuff.ContainsKey(info.Extension))
                {
                    pathsAndStuff.Add(info.Extension, new List<FileInfo>());
                }
                pathsAndStuff[info.Extension].Add(info);
               
            }
            StringBuilder builder = new StringBuilder();
            foreach (var item in pathsAndStuff.OrderByDescending(x=>x.Value.Count).OrderBy(x=>x.Key))
            {
                builder.Append(item.Key + "\n");
                foreach (var item2 in item.Value.OrderBy(x=>x.Length))
                {
                    builder.Append($"--{item2.Name} - {item2.Length / (double)1000}kb\n");
                }
            }
            return builder.ToString();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {


            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+ reportFileName;
            File.WriteAllText(path, textContent);

        }
    }
}
