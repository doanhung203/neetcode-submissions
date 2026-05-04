public class Solution {
    public bool IsPalindrome(string s) {
        string parseString = "";
        s = s.ToLower();
        for(int i = 0; i < s.Length; i++){
            if(char.IsLetterOrDigit(s[i])) parseString += s[i];
        }
        int left = 0;
        int right = parseString.Length - 1;
        while(left < right){
            if(parseString[left] != parseString[right]) return false;
            left++;
            right--;
        }
        return true;
    }
}