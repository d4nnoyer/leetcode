namespace LeetCodeSolutions.Solutions.String.Easy;

public static class Find_the_Index_of_the_First_Occurrence_in_a_String {
    
    public static int StrStr(string haystack, string needle)
    {
        for (var index = 0; index <= haystack.Length - needle.Length; index++)
        {
            if (haystack[index] != needle[0]) 
                continue;

            bool isNeedle = true;
            for (int i = 0; i < needle.Length; i++)
            {
                if (haystack[index+i] != needle[i])
                {
                    isNeedle = false;
                    break;
                }
            }

            if (isNeedle) return index;
        }
        
        return -1;
    }
}