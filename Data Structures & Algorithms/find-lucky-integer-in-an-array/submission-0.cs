public class Solution {
    public int FindLucky(int[] arr) {
        int res = 0;
        var map = new Dictionary<int, int>();
        for(int i = 0; i < arr.Length; i++){
            if(!map.ContainsKey(arr[i])) map[arr[i]] = 0;
            map[arr[i]]++;
        }
        foreach(var obj in map){
            if(obj.Key == obj.Value) res = Math.Max(res, obj.Key);
        }
        return res != 0 ? res : -1;
    }
}