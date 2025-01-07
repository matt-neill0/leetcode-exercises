public class Solution {
    static void Main() {
        string s = "aa";
        string p = "a*";
        Solution solution = new Solution();
        Console.WriteLine(solution.IsMatch(s, p));
    }
    public bool IsMatch(string s, string p) {
        if (p.Length == 0) return s.Length == 0;
        bool firstMatch = s.Length > 0 && (p[0] == s[0] || p[0] == '.');
        if (p.Length >= 2 && p[1] == '*') {
            return IsMatch(s, p.Substring(2)) || (firstMatch && IsMatch(s.Substring(1), p));
        } else {
            return firstMatch && IsMatch(s.Substring(1), p.Substring(1));
        }
    }
}