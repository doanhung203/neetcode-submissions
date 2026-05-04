public class Solution {
    public int ScoreOfString(string s) {
        int rs = 0;
        for(int i = 0; i < s.Length - 1; i++){
            rs += Math.Abs(s[i] - s[i + 1]);
        }
        return rs;
    }
}