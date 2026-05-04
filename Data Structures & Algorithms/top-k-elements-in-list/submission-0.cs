public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        foreach(int num in nums){
            if(map.ContainsKey(num)) map[num]++;
            else map[num] = 1;
        }
        //define bucket
        List<int>[] bucket = new List<int>[nums.Length + 1];// 1 more position to store value with 0 frequent
        foreach(var obj in map){
            int frequent = obj.Value;
            if(bucket[frequent] is null){
                bucket[frequent] = new List<int>();
            }
            bucket[frequent].Add(obj.Key);
        }
        int[] result = new int[k];
        int count = 0;
        for(int i = bucket.Length - 1; i >= 0 && count < k; i--){
            if(bucket[i] != null){
                foreach(int key in bucket[i]){
                    result[count++] = key;
                    if(count == k) break;
                }
            }
        }
        return result;
    }
}
