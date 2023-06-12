namespace LeetCodeSolutions.Shared.Model
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public static ListNode FromArray(params int[] nums)
        {
            var head = new ListNode(nums[0]);
            var currentNode = head;

            for (int i = 1; i < nums.Length; i++)
            {
                currentNode.next = new ListNode(nums[i]);
                currentNode = currentNode.next;
            }

            return head;
        }

        public int[] ToArray()
        {
            var nums = new List<int>();
            var currentNode = this;
            nums.Add(currentNode.val);

            while (currentNode.next is not null)
            {
                currentNode = currentNode.next;
                nums.Add(currentNode.val);
            }

            return nums.ToArray();
        }
    }
}