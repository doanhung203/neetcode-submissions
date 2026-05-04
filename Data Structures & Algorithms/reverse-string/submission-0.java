class Solution {
    public void reverseString(char[] s) {
        int right = 0, left = s.length - 1;
        while(right < left){
            char tmp = s[left];
            s[left] = s[right];
            s[right] = tmp;
            right++;
            left--;
        }
    }
}