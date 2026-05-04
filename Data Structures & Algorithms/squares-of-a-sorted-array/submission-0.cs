public class Solution {
    public int[] SortedSquares(int[] nums) {
        int n = nums.Length;
        int[] res = new int[n];
        int left = 0, right = n - 1, resIndex = n - 1;
        while(left <= right){
            if(Math.Abs(nums[left]) < Math.Abs(nums[right])){
                res[resIndex] = nums[right] * nums[right];
                right--;
            }else{
                res[resIndex] = nums[left] * nums[left];
                left++;
            }
            resIndex--;
        }
        return res;
    }
}