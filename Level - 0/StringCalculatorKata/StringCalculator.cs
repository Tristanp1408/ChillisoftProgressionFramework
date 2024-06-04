namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            var negativeList = new List<int>();

            if (string.IsNullOrEmpty(input))
                return 0;

         
            var splitNumbers = ExtractOnlyNumbers(input).Split(Delimiter(input), StringSplitOptions.RemoveEmptyEntries);
            var parsedNumbers = splitNumbers.Select(int.Parse);
            var negatives = parsedNumbers.Where(x => x < 0);
            var positives = parsedNumbers.Where(x => x > 0);

            negativeList.AddRange(negatives);

            if (negativeList.Count > 0)
            {
                throw new InvalidOperationException($"negatives not allowed: {string.Join(" ", negativeList)}");
            }

            return positives.Sum();
        }

        private string[] Delimiter(string numbers)
        {
            var list = new List<string> { ",", "\n" };
            if (numbers.StartsWith("//"))
            {
                var delimiter = numbers.Substring(2, (numbers.IndexOf('\n') - 2));
                list.Add(delimiter);
            }

            return list.ToArray();
        }

        private string ExtractOnlyNumbers(string numbers)
        {
            if (numbers.StartsWith("//")) return numbers.Substring(numbers.IndexOf('\n') + 1);
            return numbers;
        }
    }
}
