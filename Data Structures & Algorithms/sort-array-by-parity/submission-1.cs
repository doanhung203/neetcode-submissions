public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        int j = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] % 2 == 0){
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
                j++;
            }
        }
        return nums;
    }
}