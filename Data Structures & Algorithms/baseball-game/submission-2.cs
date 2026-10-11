public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> st = new Stack<int>();
        foreach(string op in operations){
            if(int.TryParse(op, out int score)){
                st.Push(score);
            }else if(op == "+"){
                int[] scor = st.ToArray();
                int sum = scor[0] + scor[1];
                st.Push(sum);
            }else if(op == "C"){
                
                st.Pop();
            }else if(op == "D"){
                int last = st.Peek();
                int mul = 2 * last;
                st.Push(mul);
            }
        }

        return st.Sum();
    }
}