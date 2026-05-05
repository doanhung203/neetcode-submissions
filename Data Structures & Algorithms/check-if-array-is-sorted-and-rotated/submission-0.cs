public class Solution {
    public bool Check(int[] nums) {
        int n = nums.Length, count  = 0;        
        for(int i  = 1; i < 2 * n; i++){// 34512 nối tiếp 34512 
            if(nums[(i - 1) % n] <= nums[i % n]) count++; // check liên tiếp 
            else count = 1; // reset count to check sort 345 ok reset từ 12 đếm tiếm 12345 
            if(count == n) return true; // check = length return 
        }
        return n == 1; //if = 1 => true
    }
}