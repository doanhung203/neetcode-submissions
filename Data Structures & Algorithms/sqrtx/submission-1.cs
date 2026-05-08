public class Solution {
    public int MySqrt(int x) {
        int l = 0, r = x;
        int res = 0;
        while(l <= r){
            int mid = l + (r - l) / 2;
            long sq = (long)mid * mid;
            if(sq == x) return mid;
            if(sq > x) r = mid - 1;
            else{ 
                l = mid + 1; 
                res = mid;
            } 
        }
        return res;
    }
}