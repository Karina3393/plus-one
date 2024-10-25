namespace plus_one
{
    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }

            int[] result = new int[digits.Length + 1];
            result[0] = 1;
            return result;
        }

        public static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] digits1 = { 1, 2, 3 };
            Console.WriteLine($"Результат: [{string.Join(", ", solution.PlusOne(digits1))}]");

            int[] digits2 = { 4, 3, 2, 1 };
            Console.WriteLine($"Результат: [{string.Join(", ", solution.PlusOne(digits2))}]");

            int[] digits3 = { 9, 9, 9 };
            Console.WriteLine($"Результат: [{string.Join(", ", solution.PlusOne(digits3))}]");

            int[] digits4 = { 0 };
            Console.WriteLine($"Результат: [{string.Join(", ", solution.PlusOne(digits4))}]");
        }
    }
}
