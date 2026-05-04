public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        Dictionary<char, int> map = new Dictionary<char, int>();
        foreach(char ch in s){
            if(map.ContainsKey(ch)) map[ch]++;
            else map[ch] = 1;
        }
        foreach(char ch2 in t){
            if(map.ContainsKey(ch2) && map[ch2] > 0) map[ch2]--;
            else return false;
        }
        return true;
    }
}