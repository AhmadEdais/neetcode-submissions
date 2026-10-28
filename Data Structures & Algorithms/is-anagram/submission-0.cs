public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;
        Dictionary<char, int> sHashMap = new Dictionary<char, int>();
        Dictionary<char, int> tHashMap = new Dictionary<char, int>();
        foreach (char c in s) {
            if (!sHashMap.TryAdd(c, 1)) {
                sHashMap[c]++;
            }
        }
        foreach (char c in t) {
            if (!tHashMap.TryAdd(c, 1)) {
                tHashMap[c]++;
            }
        }
        foreach (var c in sHashMap.Keys) {
            if (!tHashMap.TryGetValue(c, out int count) || count != sHashMap[c])
                return false;
        }
        return true;
    }
}
