class Program
{
    static void Main()
    {
        string input = "  12357245zxf";
        Console.WriteLine($"Extracted Number: {ExtractInteger(input)}");
    }

    static int ExtractInteger(string input)
    {
        bool isNegative = false;
        long extractedNumber = 0;

        const int INT_MIN = -2147483648;
        const int INT_MAX = 2147483647;

        if (string.IsNullOrWhiteSpace(input))
        {
            return 0;
        }

        input = input.TrimStart();

        if (input[0] == '-' || input[0] == '+')
        {
            isNegative = input[0] == '-';
            input = input.Substring(1);
        }
        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                extractedNumber = extractedNumber * 10 + (c - '0');
                if (isNegative && -extractedNumber < INT_MIN)
                {
                    return INT_MIN;
                }
                else if (!isNegative && extractedNumber > INT_MAX)
                {
                    return INT_MAX;
                }
            }
            else
            {
                break;
            }
        }
        if (isNegative)
        {
            extractedNumber = -extractedNumber;
        }
        if (extractedNumber < INT_MIN) return INT_MIN;
        if (extractedNumber > INT_MAX) return INT_MAX;

        return (int)extractedNumber;
    }
}