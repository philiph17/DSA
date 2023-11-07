using DataStructures;

namespace Algorithms.Puzzles.Easy;

public static class ReverseLinkedList
{
    public static ListNode? ReverseListLoop(ListNode? head)// O(n) time & O(1) memory (no extra allocations)
    {
        ListNode? prev = null;
        var current = head;

        while (current is not null)
        {
            // Save the next node
            var next = current.Next;

            // Reverse the link
            current.Next = prev;

            // Move pointers one position ahead
            prev = current;
            current = next;
        }

        return prev;
    }

    public static ListNode? ReverseListRecursion(ListNode? head) // O(n) time & O(n) memory
    {
        if (head is null)
        {
            return null;
        }

        var newHead = head;
        if (head.Next is not null)
        {
            newHead = ReverseListRecursion(newHead);
            head.Next.Next = head;
        }

        head.Next = null;
        return newHead;
    }
}
