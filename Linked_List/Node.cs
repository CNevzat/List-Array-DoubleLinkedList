using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    public class Node
    {
        public Data data; 
        public Node next;
        public Node prev;
        public Node(Data d) //I kept data as an object which consists of some props
        {           
            data = d;
            prev = null;
            next = null;

        }
    }
}
