public class Solution {
    public List<int> FindDisappearedNumbers(int[] nums) {
        int n = nums.Length;
        var set = new HashSet<int>();
        for(int i = 1; i <= n; i++){
            set.Add(i);
        }
        for(int i = 0; i < n; i++){
            set.Remove(nums[i]);
        }
        return new List<int>(set);
    }
}