public class Solution {
    public int MaxNumberOfBalloons(string text) {
        var map = new Dictionary<char, int>();
        foreach(char c in text){
            if(!map.ContainsKey(c)) map[c] = 0;
            map[c]++;            
        }
        var balloon = new Dictionary<char, int>{
            {'b', 1}, {'a', 1}, {'l', 2}, {'o', 2}, {'n', 1}
        };

        int res = text.Length;
        foreach(var entry in balloon){
            int count = map.ContainsKey(entry.Key) ? map[entry.Key] : 0;
            res = Math.Min(res, count / entry.Value);
        }
        return res;
    }
}