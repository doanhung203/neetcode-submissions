public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int max = 0, currentMax = 0;
        for(int i = 0; i < nums.Length; i++){
            max = (nums[i] == 1) ? max + 1 : 0;
            currentMax = Math.Max(currentMax, max);
        }
        return currentMax;
    }
}