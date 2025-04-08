using System.Runtime.CompilerServices;

namespace LeetCodeSolutions.Solutions.Stack.Medium;

public class Evaluate_Reverse_Polish_Notation
{

    private const char add = '+';
    private const char rem = '-';
    private const char mul = '*';
    private const char div = '/';
    private static readonly HashSet<char> operators = [add, rem, mul, div];
    
    public static int EvalRPN(string[] tokens)
    {
        var operands = new Stack<int>(tokens.Length / 2 + 1);

        foreach (var token in tokens)
            if (token.Length == 1 && operators.Contains(token[0]))
            {
                var rightValue = operands.Pop();
                var leftValue = operands.Pop();
                var result = token[0] switch
                {
                    add => leftValue + rightValue,
                    rem => leftValue - rightValue,
                    mul => leftValue * rightValue,
                    div => (int)Math.Truncate((double)leftValue / rightValue),
                };
                operands.Push(result);
            }
            else
                operands.Push(ParseFast(token));
            
        return operands.Pop();
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int ParseFast(string token)
    {
        bool isNegative = token[0] == '-';
        int result = 0;

        for (int i = isNegative ? 1 : 0; i < token.Length; i++) 
            result = result * 10 + (token[i] - '0');

        return isNegative ? -result : result;
    }
}