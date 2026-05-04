public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> storage = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            int diff = target - nums[i];
            if(storage.ContainsKey(diff)) return new int[] {storage[diff], i};
            storage[nums[i]] = i;
        }
        return new int[]{};
    }
}
