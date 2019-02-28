using System;

namespace Curs24Homework
{
    public class SingleLinkedList<T>
    {
        private Node<T> head;

        public Node<T> Head { get => head; set => head = value; }

        public void InsertFront(SingleLinkedList<T> singleLinkedList, T new_data)
        {
            Node<T> new_node = new Node<T>(new_data);
            new_node.Next = singleLinkedList.Head;
            singleLinkedList.Head = new_node;
        }

        public Node<T> GetLastNode(SingleLinkedList<T> singleLinkedList)
        {
            Node<T> temp = singleLinkedList.Head;
            while (temp.Next != null)
                temp = temp.Next;
            return temp;
        }

        public void InsertLast(SingleLinkedList<T> singleLinkedList, T new_data)
        {
            Node<T> new_node = new Node<T>(new_data);
            if (singleLinkedList.Head == null)
            {
                singleLinkedList.Head = new_node;
                return;
            }
            Node<T> lastNode = GetLastNode(singleLinkedList);
            lastNode.Next = new_node;
        }

        public Node<T> nthToLast(Node<T> head, int n)
        {
            if (head == null || n < 1)
                return null;
            Node<T> p1 = head;
            Node<T> p2 = head;
            for (int i = 0; i < n - 1; i++)
            {
                if (p2 == null)
                    return null;
                p2 = p2.Next;
            }
            while (p2.Next != null)
            {
                p1 = p1.Next;
                p2 = p2.Next;
            }
            return p1;
        }
    }
}
