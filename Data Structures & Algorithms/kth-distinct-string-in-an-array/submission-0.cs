public class Solution {
    public string KthDistinct(string[] arr, int k) {
        var map = new Dictionary<string, int>();
        foreach(string s in arr){
            if(map.ContainsKey(s)){
                map[s]++;
            }else{
                map[s] = 1;
            }
        }
        foreach(string s in arr){
            if(map[s] == 1){
                k--;
                if(k == 0) return s;
            }
        }
        return "";
    }
}