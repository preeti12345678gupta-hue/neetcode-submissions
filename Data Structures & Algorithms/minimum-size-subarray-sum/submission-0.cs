public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int sum = 0;
        int minlen = int.MaxValue;
        int left = 0;
        for(int i = 0; i < nums.Length; i++){
            sum += nums[i];

            while(sum >= target){
                int curr = i - left + 1;
                minlen = Math.Min(minlen, curr);
                sum -= nums[left];
                left++;
            }
        }

        return minlen == int.MaxValue ? 0 : minlen;
    }
}