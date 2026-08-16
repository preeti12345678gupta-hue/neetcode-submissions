public class Solution {
    public int NumSubarraysWithSum(int[] nums, int goal) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        map[0] = 1;
        int res = 0;
        int sum = 0;
        foreach(int num in nums){
            sum += num;

            int need = sum - goal;

            if(map.ContainsKey(need)){
                res += map[need];
            }

             if(!map.ContainsKey(sum)){
                map[sum] = 0;
            }
            map[sum]++;


        }

        return res;
    }
}