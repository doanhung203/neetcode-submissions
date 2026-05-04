public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        for(int i = 0; i < nums.Length / 2; i++){
            if(nums[i] % 2 != 0 && nums[nums.Length - 1 - i] % 2 == 0){
                int temp = nums[i];
                nums[i] = nums[nums.Length - 1 - i];
                nums[nums.Length - 1- i] = temp;
            }
        }
        return nums;
    }
}