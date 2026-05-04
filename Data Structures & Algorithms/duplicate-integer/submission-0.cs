public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Dictionary<int, int> storageValue = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            if(storageValue.ContainsKey(nums[i])) return true;
            storageValue[nums[i]] = i;
        }
        return false;
    }
}