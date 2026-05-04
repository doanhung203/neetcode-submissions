public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int max = 0, currentMax = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == 1){
                if(i != 0 && nums[i-1] != 1) max = 1;
                else max++;
            }
            currentMax = Math.Max(currentMax, max);
        }
        return currentMax;
    }
}