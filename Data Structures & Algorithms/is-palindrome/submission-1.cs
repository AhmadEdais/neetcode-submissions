public class Solution {
    public bool IsPalindrome(string s) {
        int p1 = 0;
        int p2 = s.Length - 1;
        while (p1 < p2) {
            if (!char.IsLetterOrDigit(s[p1])) {
                p1++;
                continue;
            }
            if (!char.IsLetterOrDigit(s[p2])) {
                p2--;
                continue;
            }
            if (char.ToLowerInvariant(s[p1]) != char.ToLowerInvariant(s[p2])) {
                return false;
            }
            p1++;
            p2--;
        }
        return true;
    }
}
