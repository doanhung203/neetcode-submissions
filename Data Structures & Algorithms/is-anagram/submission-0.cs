public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        Dictionary<char, int> storage = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++){
            if(storage.ContainsKey(s[i]))
                storage[s[i]]++;
            else
                storage[s[i]] = 1;
        }
        for(int j = 0; j < t.Length; j++){
            if(!storage.ContainsKey(t[j]) || storage[t[j]] <= 0) return false;
            storage[t[j]]--;
        }
        return true;
    }
}