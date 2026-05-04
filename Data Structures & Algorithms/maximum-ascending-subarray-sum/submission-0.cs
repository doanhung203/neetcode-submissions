public class Solution {
    public int MaxAscendingSum(int[] nums) {
        int result = nums[0], maxCurrent = nums[0];
        for(int i = 1; i < nums.Length; i++){
            if(nums[i] > nums[i-1]) maxCurrent+=nums[i];
            else maxCurrent = nums[i];
            result = Math.Max(result,maxCurrent);
        }
        return result;
    }
}