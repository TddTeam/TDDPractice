namespace StringCalculator
{
    public class Calculator     
    {
        public int CalculateFromString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            if (input.StartsWith("//"))
            {
                string[] parts = input.Split('\n');

                return Sum(parts[1], new[] { parts[0][2] });
            }

            return Sum(input, new[] {'\n', ','});
        }

        private static int Sum(string input, char[] separators)
        {
            string[] numbers = input.Split(separators);

            int sum = 0;

            foreach (var number in numbers)
            {
                sum += int.Parse(number);
            }

            return sum;
        }
    }
}