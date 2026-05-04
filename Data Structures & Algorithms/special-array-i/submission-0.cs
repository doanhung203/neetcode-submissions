public class Solution {
    public bool IsArraySpecial(int[] nums) {
        for(int i = 1; i < nums.Length; i++){
            if((nums[i] & 1) == (nums[i - 1] & 1)) return false; // compare last digit in bitwise 001 == 010
        }
        return true;
    }
}