namespace LeetCodeSolutions.Solutions.Array.Medium;

public static class Two_Sum_II___Input_Array_Is_Sorted {
    public static int[] TwoSum(int[] numbers, int target)
    {
        var searchValue = target - numbers[0];
        //Binary search
        var left = 0;
        var right = numbers.Length - 1;
        var mid = 0;
        while (left <= right) {
            mid = left + (right - left) / 2;

            if (searchValue == numbers[mid])
                break;

            if (searchValue > numbers[mid])
                left = mid + 1;
            else
                right = mid - 1;
        }
        
        var leftIndex = 0;
        var rightIndex = Math.Max(mid, 1);

        while (true)
        {
            if (numbers[leftIndex] + numbers[rightIndex] > target)
                rightIndex--;
            if (numbers[leftIndex] + numbers[rightIndex] < target)
                leftIndex++;
            if (numbers[leftIndex] + numbers[rightIndex] == target)
                break;
        }

        return [leftIndex + 1, rightIndex + 1];
    }
}