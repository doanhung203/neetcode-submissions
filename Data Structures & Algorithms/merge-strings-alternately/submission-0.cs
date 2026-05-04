public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int n1 = word1.Length, n2 = word2.Length;
        int i = 0, j = 0;
        var res = new StringBuilder();
        while(i < n1 || j < n2){
            if(i < n1){
                res.Append(word1[i]);
            }if(j < n2){
                res.Append(word2[j]);
            }
            i++;
            j++;
        }
        return res.ToString();
    }
}