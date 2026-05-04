public class Solution {
    public int LengthOfLastWord(string s) {
        int rs = 0;
        for(int i  = s.Length - 1; i >= 0; i--){
            if(s[i] == ' ' && rs != 0) return rs;
            if(s[i] != ' ') rs++;
        }
        return rs;
    }
}