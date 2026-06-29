class Solution {
    public int[] twoSum(int[] numbers, int target) {
        Map<Integer, Integer> map = new HashMap<Integer, Integer>();
        for(int i = 0; i < numbers.length; i++){
            int diff = target - numbers[i];
            if(map.containsKey(diff)) return new int[]{ map.get(diff), i + 1};
            else map.put(numbers[i], i + 1);
        }
        return new int[0];
    }
}
