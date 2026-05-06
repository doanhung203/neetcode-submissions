public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        var map = new Dictionary<int, List<int>>();
        int res = 0;
        for(int i = 0; i < nums.Length; i++){
            if(!map.ContainsKey(nums[i])) map[nums[i]] = new List<int>();
            map[nums[i]].Add(i);
        }
        foreach(var obj in map){
            int n = obj.Value.Count();
            if(n > 1) res += n * (n - 1) / 2;
        }
        return res;
    }
}