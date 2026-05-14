public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        int g = GCD(str1.Length, str2.Length);

        for(int i = 0; i < str1.Length; i++){
            if(str1[i] != str1[i % g]) return "";
        }
        for(int i = 0; i < str2.Length; i++){
            if(str2[i] != str1[i % g]) return "";
        }
        return str1.Substring(0, g);
    }
    private int GCD(int a, int b){
        // while (b != 0) {
        //     int temp = b;
        //     b = a % b;
        //     a = temp;
        // }
        // return a;
        return b == 0 ? a : GCD(b, a % b);
    }
}