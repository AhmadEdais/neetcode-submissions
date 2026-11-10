public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 0)
            return "";
            string res = "";
        for (int i = 0; i < strs[0].Length; i++) {
            char c = strs[0][i];

            for (int j = 1; j < strs.Length; j++) {
                if(i >= strs[j].Length )
                return res;
                if(strs[0][i] != strs[j][i])
                return res;
            }
            res += strs[0][i];
        }

        return res;
    }
}