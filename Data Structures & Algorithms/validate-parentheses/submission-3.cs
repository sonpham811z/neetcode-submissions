public class Solution {
    public bool IsValid(string s) {
        
        Stack<char> Paranthese = new Stack<char>();
        for(int i = 0; i < s.Length; i++)
        {
            switch (s[i])
            {
                case ')':
                    if(Paranthese.Count == 0 || Paranthese.Pop() != '(')
                        return false;
                    break;
                case '}':
                    if(Paranthese.Count == 0 || Paranthese.Pop() != '{')
                        return false;
                    break;
                case ']':
                    if(Paranthese.Count == 0 || Paranthese.Pop() != '[')
                        return false;
                    break;
                default: 
                    Paranthese.Push(s[i]);
                    break;
            }
        }
        return Paranthese.Count > 0 ? false: true ;
    }
}
