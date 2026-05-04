class Solution {
    public int majorityElement(int[] nums) {
        HashMap<Integer, Integer> map = new HashMap<Integer, Integer>();
        int res = 0, maxCount = 0;
        for(int num : nums){
            map.put(num, map.getOrDefault(num,  1) + 1);
            if(map.get(num) > maxCount){
                res = num;
                maxCount = map.get(num);
            }
        }
        return res;
    }
}