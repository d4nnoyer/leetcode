namespace LeetCodeSolutions.Solutions.String.Medium;

public static class String_Compression {

    public static int Compress(char[] chars)
    {
        if (chars.Length == 1) return 1;

        var readIndex = 0;
        var writeIndex = 0;
        char currChar = chars[0];
        var currCharCount = 0;

        while (readIndex < chars.Length)
        {
            if (chars[readIndex] == currChar)
            {
                currCharCount++;
                readIndex++;
            }
            else
            {
                chars[writeIndex++] = currChar;
                if(currCharCount > 1) 
                    foreach (var c in currCharCount.ToString()) 
                        chars[writeIndex++] = c;
                currChar = chars[readIndex];
                currCharCount = 0;
            }
        }
        
        chars[writeIndex++] = currChar;
        if(currCharCount > 1) 
            foreach (var c in currCharCount.ToString()) 
                chars[writeIndex++] = c;

        return writeIndex;
    }
}