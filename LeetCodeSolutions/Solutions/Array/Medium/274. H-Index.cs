namespace LeetCodeSolutions.Solutions.Array.Medium;

public static class H_Index {
    
    public static int HIndex(int[] citations)
    {
        var citationsCount = citations.Length;
        Span<int> papersCountByCitations = stackalloc int[citationsCount + 1];

        foreach (int citation in citations) {
            papersCountByCitations[Math.Min(citationsCount, citation)] += 1;
        }

        int hIndex = citationsCount;
        int papersCount = papersCountByCitations[citationsCount];

        while (papersCount < hIndex) {
            hIndex--;
            papersCount += papersCountByCitations[hIndex];
        }

        return hIndex;
    }
}