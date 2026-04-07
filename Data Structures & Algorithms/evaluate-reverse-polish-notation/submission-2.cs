public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        int num1, num2;
        foreach(string token in tokens)
        {
            switch (token) {
                case "+":
                    num1 = stack.Pop();
                    num2 = stack.Pop();
                    stack.Push(num2+num1);
                    break;
                case "-":
                    num1 = stack.Pop();
                    num2 = stack.Pop();
                    stack.Push(num2-num1);
                    break;
                case "*":
                    num1 = stack.Pop();
                    num2 = stack.Pop();
                    stack.Push(num2*num1);
                    break;
                case "/":
                    num1 = stack.Pop();
                    num2 = stack.Pop();
                    stack.Push(num2/num1);
                    break;
                default:
                    stack.Push(int.Parse(token));
                    break;
            }

        }

        return stack.Pop();
    }
}
