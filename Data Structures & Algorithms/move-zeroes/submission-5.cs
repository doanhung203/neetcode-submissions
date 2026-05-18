public class Solution {
    public void MoveZeroes(int[] nums) {
        int i = 0, j = 0;
        int n = nums.Length;
        while(j < n){
            if(nums[j] != 0){
                int temp = nums[i]; 
                nums[i] = nums[j];
                nums[j] = temp;
                i++;
            }
            j++;
        }
    }
}