public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        var count = new Dictionary<int, int>();
        int res = 0;
        foreach(int num in nums){
            if(count.ContainsKey(num)){
                res += count[num];
                count[num]++;
            }else count[num] = 1;
        }
        return res;
    }
}