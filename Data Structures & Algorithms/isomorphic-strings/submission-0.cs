public class Solution {
    public bool IsIsomorphic(string s, string t) {
        var mapST = new Dictionary<char, char>();
        var mapTS = new Dictionary<char, char>();
        for(int i = 0; i < s.Length; i++){
            char c1 = s[i], c2 = t[i];
            if((mapST.ContainsKey(c1) && mapST[c1] != c2) 
            || (mapTS.ContainsKey(c2) && mapTS[c2] != c1)) 
                return false;
            mapST[c1] = c2;
            mapTS[c2] = c1;
        }
        return true;
    }
}