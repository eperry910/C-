using System.Collections.Generic;
public class Intersection
{
    public static LinkedListNode<T>? findIntersection<T>(LinkedList<T> A, LinkedList<T> B)
    {
        LinkedListNode<T>? pointer = A.First;
        HashSet<LinkedListNode<T>> values = new HashSet<LinkedListNode<T>>();
        while (pointer != null)
        {
            values.Add(pointer);
            pointer = pointer.Next;
        }
        pointer = B.First;
        while (pointer != null)
        {
            if (values.Contains(pointer))
            {
                return pointer;
            }
            pointer = pointer.Next;
        }
        return null;
    }
}