namespace LineNumbers
{
    using System.IO;
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\input.txt";
            string outputPath = @"..\..\..\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            StreamReader reader = new(inputFilePath);
            StreamWriter writer = new(outputFilePath);
            var line = reader.ReadLine();
            var counter = 1;
            using (reader)
            {
                while (line != null)
                {
                    writer.WriteLine($"{counter}. {line}");
                    counter++;
                    line = reader.ReadLine();
                    writer.Flush();
                }
            }
        }
    }
}
