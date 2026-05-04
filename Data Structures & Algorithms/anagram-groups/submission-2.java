class Solution {
    public List<List<String>> groupAnagrams(String[] strs) {
        HashMap<String, List<String>> map = new HashMap<String, List<String>>();
        for(String str : strs){
            int[] indexCount = new int[26];
            for(char s : str.toCharArray()){
                indexCount[s - 'a']++;
            }
            String key = Arrays.toString(indexCount);
            if(!map.containsKey(key)) map.put(key, new ArrayList<>());
            map.get(key).add(str);
        }
        return new ArrayList<>(map.values());
    }
}
