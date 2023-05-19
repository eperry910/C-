using System.Collections.Generic;
namespace LoopDetection;
public class Loop
{
    public LinkedListNode<T> detectsLoop<T>(LinkedList<T> values)
    {
        HashSet<LinkedListNode<T>> foundValues = new HashSet<LinkedListNode<T>>();
        LinkedListNode<T> pointer = values.First;
        while (pointer != null)
        {
            if (!foundValues.Contains(pointer))
            {
                foundValues.Add(pointer);
            }
            else
            {
                return pointer;
            }
        }
        return null;
    }
}