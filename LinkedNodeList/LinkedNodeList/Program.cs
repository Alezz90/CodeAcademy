namespace LinkedNodeList
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)//constractor
        {
            this.val = val;
            this.next = next;
        }
    }
    
        public class LinkedListMerger
        {
           public ListNode MergeTwoLists(ListNode l1, ListNode l2)
            {
                ListNode dummy = new ListNode(0);
                ListNode current = dummy;
            Console.WriteLine(dummy.val);
            while (l1 != null && l2 != null)
                {
                
                if (l1.val < l2.val)
                    {
                        current.next = l1;
                        l1 = l1.next;
                    }
                    else
                    {
                        current.next = l2;
                        l2 = l2.next;
                    }
                    current = current.next;
                }

                // Connect remaining nodes, if any
                if (l1 != null)
                {
                    current.next = l1;
                }
                else if (l2 != null)
                {
                    current.next = l2;
                }

                return dummy.next; // Return the merged list starting from the next of dummy node
            }

        }
    public class Program
    {

        static void Main(string[] args)
        {
            
                // Create sorted linked list 1: 1 -> 3 -> 5
                ListNode list1 = new ListNode(1);
                list1.next = new ListNode(3);
                list1.next.next = new ListNode(5);

                // Create sorted linked list 2: 2 -> 4 -> 6
                ListNode list2 = new ListNode(2);
                list2.next = new ListNode(2);
                list2.next.next = new ListNode(6);

                // Create an instance of LinkedListMerger
                LinkedListMerger merger = new LinkedListMerger();

                // Merge the two lists
                ListNode mergedList = merger.MergeTwoLists(list1, list2);

                // Print the merged list
                PrintList(mergedList);
            }

            // Helper function to print the linked list
            static void PrintList(ListNode node)
            {
                while (node != null)
                {
                    Console.Write(node.val + " ");
                    node = node.next;
                }
            }
            
    }
}