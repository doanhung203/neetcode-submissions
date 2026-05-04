public class Solution {
    private int[] dp = new int[31];
    public int ClimbStairs(int n) {     
        // if (n == 1) return 1; 
        // if (n == 2) return 2; 
        // if (dp[n] != 0) return dp[n];
        // dp[n] = ClimbStairs(n - 1) + ClimbStairs(n - 2);
        // return dp[n];
        //top-down

        //bottom-up
        if(n == 1) return 1;
        int[] dp = new int[n+1];
        dp[1] = 1;
        dp[2] = 2;

        for(int i = 3; i <= n; i++){
            dp[i] = dp[i-1] + dp[i-2];
        }
        return dp[n];
    }
}
