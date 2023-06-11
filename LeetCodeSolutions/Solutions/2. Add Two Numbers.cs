using System.Text;

namespace LeetCodeSolutions.Solutions;

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
