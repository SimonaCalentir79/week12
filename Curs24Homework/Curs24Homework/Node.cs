using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs24Homework
{
    public class Node<T>
    {
        private T data;
        private Node<T> next;

        internal T Data { get => data; set => data = value; }
        internal Node<T> Next { get => next; set => next = value; }

        public Node(T d)
        {
            Data = d;
            Next = null;
        }
    }
}
