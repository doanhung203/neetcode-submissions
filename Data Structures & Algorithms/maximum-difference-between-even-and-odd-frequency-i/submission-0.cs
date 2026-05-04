public class Solution {
    public int MaxDifference(string s) {
        var count = new int[26];
        foreach(char c in s){
            count[c - 'a']++;
        }
        int maxOdd = 0, minEven = s.Length;
        foreach(int c in count){
            if(c == 0) continue;
            if(c % 2 == 1) maxOdd = Math.Max(maxOdd, c);
            else minEven = Math.Min(minEven, c);
        }
        return maxOdd - minEven;
    }
}