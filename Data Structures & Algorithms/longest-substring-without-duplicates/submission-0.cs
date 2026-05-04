public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> map = new Dictionary<char, int>();
        int i = 0;
        int maxLength = 0;
        for(int j = 0; j < s.Length; j++){
            if(map.ContainsKey(s[j]) && map[s[j]] >= i){
                i = map[s[j]] + 1;
            }
            map[s[j]] = j;
            maxLength = Math.Max(maxLength, j - i + 1);
        }
        return maxLength;
    }
}
