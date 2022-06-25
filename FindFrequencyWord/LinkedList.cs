using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class LinkedList<K, V> where K : IComparable
    {
        public MyMapNode<K, V> Head;
        public MyMapNode<K, V> Tail;

        public LinkedList()
        {
            Head = null;
            Tail = null;
        }

        internal MyMapNode<K, V> Search(K key)
        {
            MyMapNode<K, V> temp = Head;
            while (temp != null)
            {
                if (temp.key.Equals(key))
                    return temp;
                temp = temp.next;
            }
            return null;
        }

        public void Append(MyMapNode<K, V> node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.next = node;
                Tail = node;
            }
        }
    }
}
