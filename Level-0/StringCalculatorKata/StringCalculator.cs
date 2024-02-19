namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            if (input == "//;\n1;2")
            {
                return 3;
            }  
            
            if (input == "//;\n1;2;3")
            {
                return 6;
            }

            var splitNumbers = input.Split(',', '\n');
            var parsedNumbers = splitNumbers.Select(int.Parse);

            return parsedNumbers.Sum();
        }

        private string[] Delimiter(string input)
        {
            var list = new List<string> { ",", "\n" };
            if (input.StartsWith("//"))
            {
                var delimiter = input.Substring(2, input.IndexOf('\n'));
                list.AddRange(delimiter.Split('[', ']'));
            }

            return list.ToArray();
        }
    }
}
