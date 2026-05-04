public class Solution {
    public bool WordPattern(string pattern, string s) {
        string[] ss = s.Split(' ');
        if(pattern.Length != ss.Length) return false;
        var map = new Dictionary<char, string>();
        var used = new HashSet<string>();
        for(int i = 0; i < ss.Length; i++){
            if(map.ContainsKey(pattern[i])){
                if(!map[pattern[i]].Equals(ss[i])) return false;
            }else{
                if (used.Contains(ss[i])) return false;
                used.Add(ss[i]);
                map[pattern[i]] = ss[i];
            }
        }
        return true;
    }
}