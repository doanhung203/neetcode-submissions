public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
                Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
        foreach(string str in strs){
            int[] storage = new int[26];
            foreach(char index in str){
                storage[index - 'a']++;
            }
            string key = string.Join("", storage);
            if(!result.ContainsKey(key)){
                result[key] = new List<string>();
            }
            result[key].Add(str);
        }
        return result.Values.ToList();
    }
}
