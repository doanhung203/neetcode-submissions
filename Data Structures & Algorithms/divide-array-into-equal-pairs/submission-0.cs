public class Solution {
    public bool DivideArray(int[] nums) {
        var map = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            if(!map.ContainsKey(nums[i])) map[nums[i]] = 0;
            map[nums[i]]++;
        }
        foreach(var obj in map){
            if(obj.Value % 2 != 0) return false;
        }
        return true;
    }
}