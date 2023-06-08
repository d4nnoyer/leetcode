namespace Playground.Solutions.Array.Easy;

public static class Plus_One {
    
    public static int[] PlusOne(int[] digits)
    {
        int overflowFlag = 0;

        if (digits[^1] == 9)
        {
            overflowFlag = 1;
            digits[^1] = 0;
        }
        else
        {
            digits[^1] += 1;
        }

        for (int i = digits.Length - 2; i >= 0; i--)
        {
            if (digits[i] + overflowFlag == 10)
            {
                digits[i] = 0;
            }
            else
            {
                digits[i] += overflowFlag;
                overflowFlag = 0;
            }
        }

        if (overflowFlag == 1)
        {
            int[] newValues = new int[digits.Length + 1];
            newValues[0] = 1;                                // set the prepended value
            System.Array.Copy(digits, 0, newValues, 1, digits.Length);
            return newValues;
        }
        
        return digits;
    }
    
}