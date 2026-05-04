public class Solution {
    public void MoveZeroes(int[] nums) {
        int i = 0, j = 0;
        while(i < nums.Length && j < nums.Length){
            if(nums[j] == 0) j++;
            else{
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
                i++;
            }
        }
    }
}