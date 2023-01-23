using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    public class Node
    {
        public int data;
        public Node next;
        public Node prev;
        public Node(int d)
        {
            this.data = d;
            prev = null;
            next = null;
        }
    }
}
