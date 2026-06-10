class Solution {
    public int subarraySum(int[] nums, int k) {
        int count = 0, sum = 0;
        Map<Integer, Integer> prefixSum = new HashMap<Integer, Integer>();
        prefixSum.put(0, 1);//empty prefix
        for(int num : nums){
            sum += num;
            int diff = sum - k;
            count += prefixSum.getOrDefault(diff, 0);
            prefixSum.put(sum, prefixSum.getOrDefault(sum, 0) + 1);
        }
        return count;
    }
}