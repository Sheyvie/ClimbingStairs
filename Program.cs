﻿//You are climbing a staircase. It takes n steps to reach the top.

//Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?


public class Solution{
  
public int ClimbStairs(int n) {
    if (n == 1) return 1;
    if (n == 2) return 2;

    int[] dp = new int[n + 1];
    dp[1] = 1;
    dp[2] = 2;

    for (int i = 3; i <= n; i++) {
        dp[i] = dp[i - 1] + dp[i - 2];
    }

    return dp[n];
}

}
class Program {
    static void Main(string[] args) {
        Solution solution = new Solution();
        int n = 45; 
        int ways = solution.ClimbStairs(n);
        Console.WriteLine("Number of ways to climb the staircase with " + n + " steps: " + ways);
    }
}
