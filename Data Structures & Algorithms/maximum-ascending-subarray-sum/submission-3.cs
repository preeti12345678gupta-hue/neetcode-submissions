public class Solution {
    public int MaxAscendingSum(int[] nums) {
        int sum = nums[0];
        int max = nums[0];

        for(int i = 1; i < nums.Length; i++){
            if(nums[i] > nums[i - 1]){
                sum += nums[i];
            }else{
                sum = nums[i];
            }

            max = Math.Max(max, sum);
        }
        return max;
    }
}