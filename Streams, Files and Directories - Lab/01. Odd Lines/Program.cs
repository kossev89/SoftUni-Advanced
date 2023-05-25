namespace OddLines
{
    using System.IO;

    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            var reader = new StreamReader(inputFilePath);
            var lines = reader.ReadToEnd();
            var writer = new StreamWriter(outputFilePath);
            var counter =0;
            using (reader)
            {
                while (lines != null)
                {

                }
            }

        }
    }
}