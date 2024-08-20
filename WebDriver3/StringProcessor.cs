public class StringProcessor
{
    public int CountMaxUnequalConsecutiveChars(string input)
    {
        if (string.IsNullOrEmpty(input)) return 0;
        int maxCount = 1, currentCount = 1;

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != input[i - 1])
            {
                currentCount++;
                if (currentCount > maxCount)
                    maxCount = currentCount;
            }
            else
            {
                currentCount = 1;
            }
        }
        return maxCount;
    }

    public int CountMaxConsecutiveIdenticalLetters(string input)
    {
        if (string.IsNullOrEmpty(input)) return 0;
        int maxCount = 0, currentCount = 0;
        char? lastChar = null;

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                if (c == lastChar)
                {
                    currentCount++;
                    maxCount = Math.Max(maxCount, currentCount);
                }
                else
                {
                    currentCount = 1;
                    lastChar = c;
                }
            }
        }
        return maxCount;
    }

    public int CountMaxConsecutiveIdenticalDigits(string input)
    {
        if (string.IsNullOrEmpty(input)) return 0;
        int maxCount = 0, currentCount = 0;
        char? lastDigit = null;

        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                if (c == lastDigit)
                {
                    currentCount++;
                    maxCount = Math.Max(maxCount, currentCount);
                }
                else
                {
                    currentCount = 1;
                    lastDigit = c;
                }
            }
        }
        return maxCount;
    }
}
