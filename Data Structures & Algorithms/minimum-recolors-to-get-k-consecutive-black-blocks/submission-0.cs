public class Solution {
    public int MinimumRecolors(string blocks, int k) {
        int count_w = 0;
        for(int i = 0; i < k; i++){
            if(blocks[i] == 'W') count_w++;
        }
        int res = count_w;
        for(int i = k; i < blocks.Length; i++){
            if(blocks[i - k] == 'W') count_w--;
            if(blocks[i] == 'W') count_w++;
            res = Math.Min(res, count_w);
        }
        return res;
    }
}