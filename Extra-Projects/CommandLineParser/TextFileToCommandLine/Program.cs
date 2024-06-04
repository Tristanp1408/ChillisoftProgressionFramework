using CommandLine;

namespace TextFileToCommandLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed(options =>
                {
                    var filePath = options.FilePath;

                    ReadAndDisplayFileContent(filePath);
                });
        }

        static void ReadAndDisplayFileContent(string filePath)
        {
            var fileContent = File.ReadAllText(filePath);
            Console.WriteLine("File Content: \n");
            Console.WriteLine(fileContent);
        }

        public class Options
        {
            [Option('f', "file")]
            public string FilePath { get; set; } = "C:\\Users\\Tristan\\Documents\\Projects\\CommandLineParser\\MyTextFile.txt";
        }

        //[Option('f', "file", Required = true, HelpText = "C:\\Users\\Tristan\\Documents\\Projects\\CommandLineParser\\MyTextFile.txt")]
    }
}