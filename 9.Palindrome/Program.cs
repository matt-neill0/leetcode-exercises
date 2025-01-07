public class Solution {
    static void Main() {
        int input = 121;
        Console.WriteLine(IsPalindrome(input));

        input = -121;
        Console.WriteLine(IsPalindrome(input));

        input = 10;
        Console.WriteLine(IsPalindrome(input));       
    }

    static bool IsPalindrome(int number){
        if (number < 0 || (number % 10 == 0 && number != 0)) {
            return false;
        }

        int reversedNumber = 0;
        int original = number;

        while (number > 0) {
            reversedNumber = reversedNumber * 10 + number % 10;
            number /= 10;
        }

        return original == reversedNumber;
    }
}
