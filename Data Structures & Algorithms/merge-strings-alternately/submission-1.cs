public class Solution {
    public string MergeAlternately(string word1, string word2) {
        StringBuilder merged = new StringBuilder();
        int n1 = word1.Length, n2 = word2.Length;
        int i = 0;
        while(i < n1 || i < n2){
            if(i < n1) merged.Append(word1[i]);
            if(i < n2) merged.Append(word2[i]);
            i++;    
        }
        return merged.ToString();
    }
}