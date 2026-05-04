class Solution {
    public int search(int[] nums, int target) {
        int left = nums[0], right = nums[nums.length - 1];
        while(left <= right){
            int mid = left + ((right - left) / 2);
            if(nums[mid] > target){
                right = mid - 1;
            }else if(nums[mid] < target){
                left = mid + 1;
            }else return mid;
        }
        return -1;
    }
}
