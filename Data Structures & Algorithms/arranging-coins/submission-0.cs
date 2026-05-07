public class Solution {
    public int ArrangeCoins(int n) {
        int l = 0, r = n;
        int res = 0;
        while(l <= r){
            int mid = l + (r - l) / 2;
            long coins = (long)mid * (mid + 1) / 2;

            if(coins > n) r = mid - 1;
            else{
                res = Math.Max(res, mid);
                l = mid + 1;
            }
        }
        return res;
    }
}