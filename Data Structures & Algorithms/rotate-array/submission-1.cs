public class Solution {
       public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        k %= n;
        Reverse(nums, 0, n - 1);   // reverse all
        Reverse(nums, 0, k - 1);   // reverse first k
        Reverse(nums, k, n - 1);   // reverse remaining
    }

    private void Reverse(int[] nums, int left, int right) {
        while(left < right){
            int temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;
            left++;
            right--;
        }
    }
}