namespace Algorithms.Searching;

public class MiddleNode
{
    public LinkedListNode<T> FindMiddleNode<T>(LinkedListNode<T> head)
    {
        var slow = head;
        var fast = head;

        while (fast?.Next != null)
        {
            fast = fast.Next.Next;
            slow = slow!.Next;
        }

        return slow!;
    }
}