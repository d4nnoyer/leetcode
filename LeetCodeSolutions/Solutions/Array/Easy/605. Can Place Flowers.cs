namespace LeetCodeSolutions.Solutions.Array.Easy;

public static class Can_Place_Flowers {
    
    public static bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        if (n == 0)
            return true;
        if (flowerbed.Length == 1)
            return n == 1 && flowerbed is [0];
        if (flowerbed.Length == 2)
            return n == 1 && flowerbed is [0,0];
        
        var flowersSpan = flowerbed.AsSpan();
        var plantPlaces = 0;
        
        for (var i = 0; i < flowersSpan.Length; i++)
        {
            if (flowersSpan[i] != 0)
                continue;

            if (i > 0 && i < flowersSpan.Length - 1 && flowersSpan[i + 1] == 0 && flowersSpan[i - 1] == 0)
            {
                Plant(flowersSpan, i, ref plantPlaces);
                continue;
            }

            if (i == 0 && flowersSpan[i + 1] == 0)
            {
                Plant(flowersSpan, i, ref plantPlaces);
                continue;
            }

            if (i == flowersSpan.Length - 1 && flowersSpan[i - 1] == 0) 
                Plant(flowersSpan, i, ref plantPlaces);
        }

        return plantPlaces >= n;
    }

    private static void Plant(Span<int> flowers, int index, ref int plantPlaces)
    {
        plantPlaces++;
        flowers[index] = 1;
    }
}