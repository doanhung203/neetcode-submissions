public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] storageCharacters = new int[26];
        int left = 0;
        int maxCount = 0;
        int maxLength = 0;
        for (int right = 0; right < s.Length; right++) {
            int index = s[right] - 'A';
            storageCharacters[index]++;
            maxCount = Math.Max(maxCount, storageCharacters[index]);
            if ((right - left + 1) - maxCount > k) {
                storageCharacters[s[left] - 'A']--;
                left++;
            }
            maxLength = Math.Max(maxLength, right - left + 1);
        }
        return maxLength;
    }
}
