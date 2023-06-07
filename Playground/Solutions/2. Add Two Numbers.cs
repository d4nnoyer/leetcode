using System.Text;

namespace Playground.Solutions;

public class Add_Two_Numbers {
    
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            var currentNode = this;
            sb.Append(currentNode.val);

            while (currentNode.next is not null)
            {
                currentNode = currentNode.next;
                sb.Append(currentNode.val);
            }

            return sb.ToString();
        }
    }
        
    public class Solution {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int of = 0;
            int sum = 0;
            GetDigitSum(l1.val, l2.val,ref sum,  ref of);
            
            var result = new ListNode(sum);
            var currentResultNode = result;

            while (l1?.next != null || l2?.next != null)
            {
                l1 = l1?.next;
                l2 = l2?.next;
                
                GetDigitSum(l1?.val ?? 0, 
                    l2?.val ?? 0, 
                    ref sum,
                    ref of);

                currentResultNode.next = new ListNode(sum);
                currentResultNode = currentResultNode.next;
            }

            if (of == 1)
            {
                currentResultNode.next = new ListNode(of);
            }
            
            return result;
        }

        private static void GetDigitSum(int d1, int d2, ref int sum, ref int of)
        {
            sum = d1 + d2 + of;
            
            if (sum > 9)
            {
                sum %= 10;
                of = 1;
            }
            else
            {
                of = 0;
            }
        }
    }
}


// public class Solution {
//     public double FindMedianSortedArrays(int[] nums1, int[] nums2)
//     {
//         if (nums1.Length == 0)
//         {
//             return GetSortedArrayMedian(nums2);
//         }
//         if (nums2.Length == 0)
//         {
//             return GetSortedArrayMedian(nums1);
//         }
//         
//         var commonLength = nums1.Length + nums2.Length;
//         bool isEven = commonLength % 2 == 0;
//         var indexToReach = isEven ? commonLength / 2 - 1 :  commonLength / 2 ;
//
//         int nums1Index = 0;
//         int nums2Index = 0;
//         int mergedIndex = -1;
//
//         var nextStep = () =>
//         {
//             if (nums2Index >= nums2.Length)
//                 nums1Index++;
//             else if (nums1Index >= nums1.Length)
//                 nums2Index++;
//             else if (nums1[nums1Index] < nums2[nums2Index])
//                 nums1Index++;
//             else
//                 nums2Index++;
//         };
//
//         while (mergedIndex != indexToReach)
//         {
//             nextStep.Invoke();
//             mergedIndex++;
//         }
//
//         if (isEven)
//         {
//             int leftValue = Math.Max(nums1[GetSafeIndex(nums1, nums1Index)], nums2[GetSafeIndex(nums2, nums2Index)]);
//             nextStep.Invoke();
//             int rightValue = Math.Max(nums1[GetSafeIndex(nums1, nums1Index)], nums2[GetSafeIndex(nums2, nums2Index)]);
//
//             return (double) (leftValue + rightValue) / 2;
//         }
//
//         return Math.Max(nums1[GetSafeIndex(nums1, nums1Index)], nums2[GetSafeIndex(nums2, nums2Index)]);
//     }
//
//     private static int GetSafeIndex(int[] arr, int index)
//     {
//         return index >= arr.Length ? arr.Length - 1 : index;
//     }
//
//     private static double GetSortedArrayMedian(IReadOnlyList<int> arr)
//     {
//         switch (arr.Count)
//         {
//             case 1:
//                 return arr[0];
//             case 2:
//                 return (double) (arr[0] + arr[1]) / 2;
//         }
//
//         bool isEven = arr.Count % 2 == 0;
//         var indexToReach = isEven ?  arr.Count / 2 - 1 : arr.Count / 2 ;
//
//         if (isEven)
//             return (double) (arr[indexToReach] + arr[indexToReach+1]) / 2;
//
//         return arr[indexToReach];
//     }
// }