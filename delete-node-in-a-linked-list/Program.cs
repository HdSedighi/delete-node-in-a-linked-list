public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public void DeleteNode(ListNode node)
    {
        // Copy the next node's value to the current node
        node.val = node.next.val;
        // Set the current node's next pointer to the next node's next pointer
        node.next = node.next.next;
    }
}

// Usage example:
public static void Main(string[] args)
{
    // Create linked list: 4 -> 5 -> 1 -> 9
    ListNode head = new ListNode(4);
    head.next = new ListNode(5);
    head.next.next = new ListNode(1);
    head.next.next.next = new ListNode(9);

    // Node to delete is node with value 5 (second node)
    ListNode nodeToDelete = head.next;

    // Create an instance of the solution
    Solution solution = new Solution();

    // Delete the node
    solution.DeleteNode(nodeToDelete);

    // Print the linked list
    ListNode current = head;
    while (current != null)
    {
        Console.Write(current.val + " ");
        current = current.next;
    }
    // Output: 4 1 9
}
