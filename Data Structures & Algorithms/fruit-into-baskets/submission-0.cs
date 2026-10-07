public class Solution {
    public int TotalFruit(int[] fruits) {
        int left = 0;
        int windowlength = 0;
        int max = 0;
        Dictionary<int,int> map = new Dictionary<int,int>();
        for(int right = 0; right < fruits.Length; right++){
            if(!map.ContainsKey(fruits[right])){
                map[fruits[right]] = 0;
            }
            map[fruits[right]]++;

            while(map.Count > 2){

                map[fruits[left]]--;

                if(map[fruits[left]] == 0){
                map.Remove(fruits[left]);

            }

                left++;
            }

             

            max = Math.Max(max, right - left + 1);

        }
        return max;
    }
}