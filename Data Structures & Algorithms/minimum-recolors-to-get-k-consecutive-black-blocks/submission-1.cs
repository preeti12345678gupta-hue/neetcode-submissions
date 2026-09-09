public class Solution {
    public int MinimumRecolors(string blocks, int k) {
        int white = 0;
        for(int i = 0; i < k; i++){
            if(blocks[i] == 'W'){
                white++;
            }
        }

        int res = white;
        for(int i = k; i < blocks.Length; i++){
            if(blocks[i - k] == 'W'){
                white--;
            }
            if(blocks[i] == 'W'){
                white++;
            }

            res = Math.Min(res, white);
        }

        return res;
    }
}