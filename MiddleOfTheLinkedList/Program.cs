// See https://aka.ms/new-console-template for more information

ListNode listNode = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
Solution solution = new Solution();
var flex = solution.MiddleNode(listNode);
Console.WriteLine("hello world");
public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        ListNode headCopy = head;
        int count = 0;
        while (headCopy != null)
        {
            count++;
            headCopy = headCopy.next;
        }

        int middle = count / 2;
        for (int i = 0; i < middle; i++)
        {
            head = head.next;
        }


        return head;
    }
}

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