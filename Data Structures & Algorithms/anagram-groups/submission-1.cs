public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
        foreach(string str in strs){
            int[] charCount = new int[26];
            foreach(char index in str){
                charCount[index - 'a']++;
            }
            string key = String.Join(",", charCount);
            if(!map.ContainsKey(key)) map[key] = new List<string>{str};
            else map[key].Add(str);
        }
        return map.Select(m => m.Value).ToList();
    }
}
