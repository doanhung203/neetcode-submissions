class Solution {
    public int lengthOfLastWord(String s) {
        s = s.trim();
        String[] sl = s.split("\\s+");
        return sl[sl.length - 1].length();
    }
}