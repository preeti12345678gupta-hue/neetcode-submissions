public class Solution {
    public int MaxProduct(int[] nums) {
        int maxp = nums[0];
        int minp = nums[0];
        int res = nums[0];
        for(int i = 1; i < nums.Length; i++){
            int curr = nums[i];
            int tempMax = Math.Max(curr, Math.Max(curr * maxp, curr * minp));
            int tempMin = Math.Min(curr, Math.Min(curr * maxp, curr * minp));

            maxp = tempMax;
            minp = tempMin;

            res = Math.Max(res, maxp);
        }

        return res;
    }
}
