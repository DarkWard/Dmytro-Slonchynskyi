using System;

namespace HomeTask_3_1.Task1
{
    internal class Node<T>
    {
        public Node(T data)
        {
            Data = data;
        }

        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }
}
