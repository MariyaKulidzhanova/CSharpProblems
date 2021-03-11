using System.Collections;
using System.Collections.Generic;

namespace TestTasks
{
    public class DoubleLinkedList<T> : IEnumerable<T>
    {
        public DoubleLinkedListNode<T> First;
        public DoubleLinkedListNode<T> Last;
        private int count;

        public void AddFirst(T value)
        {
            DoubleLinkedListNode<T> node = new DoubleLinkedListNode<T>(value);
            DoubleLinkedListNode<T> temp = First;
            node.Next = temp;
            First = node;

            if (count == 0)
            {
                Last = First;
            }
            else
            {
                temp.Prev = node;
            }
            count++;
        }

        public void AddLast(T value)
        {
            DoubleLinkedListNode<T> node = new DoubleLinkedListNode<T>(value);

            if (First == null)
            {
                First = node;
            }
            else
            {
                Last.Next = node;
                node.Prev = Last;
            }
            Last = node;
            count++;
        }

        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public void Reverse()
        {
            var buffer = First;
            First = Last;
            Last = buffer;
            DoubleLinkedListNode<T> current;
            current = First;

            while (current != null)
            {
                current.Next = buffer;
                current.Next = current.Prev;
                current.Prev = buffer;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            DoubleLinkedListNode<T> current = First;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
    }
}
