namespace OddLines
{
    using System.IO;
    using System.Text;

    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\input.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            var reader = new StreamReader(inputFilePath);
            var lines = reader.ReadLine();
            var writer = new StreamWriter(outputFilePath);
            var counter = 0;
            using (reader)
            {
                while (lines != null)
                {
                    if (counter % 2 != 0)
                    {
                        writer.WriteLine(lines);
                    }
                    counter++;
                    lines = reader.ReadLine();
                }
            }

        }
    }
}