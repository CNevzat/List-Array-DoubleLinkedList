using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    public class LinkedList
    {
        public Node head;

        public void Insert_Front(LinkedList l_list, int data) //Add Node to the Front
        {
            Node newNode = new Node(data);
            newNode.next = l_list.head;
            newNode.prev = null;

            if (l_list.head != null)
            {
                l_list.head.prev = newNode; //our new node added to the front
            }
            l_list.head = newNode; //node which is added newly becomes head of the list
        }

        public void Insert_End(LinkedList l_list, int data)
        {
            Node newNode = new Node(data);
            if (l_list.head == null)
            {
                newNode.prev = null;
                l_list.head = newNode;
                return;
            }
            Node last_Node = Get_Last_Node(l_list);
            last_Node.next = newNode;
            newNode.prev.prev = last_Node;
        }
        public Node Get_Last_Node(LinkedList l_list)
        {
            Node current = l_list.head;
            while (current.next != null)
            {
                current = current.next;
            }
            return current;
        }

        public static void Remove_Node(LinkedList l_list, int key)
        {
            Node current = l_list.head; //current node is the head of the list initially
            if (current != null && current.data == key) //if node to be removed is head
            {
                l_list.head = current.next; //head will be the next one
                l_list.head.prev = null; //first node will be removed
            }

            while (current != null && current.data != key) 
            {
                current = current.next; // pass to another Node               
            }

            if (current == null) 
            {
                return;
            }
            if (current.next != null) 
            {
                current.next.prev = current.prev; //setting previous None 
            }
            if (current.prev != null)
            {
                current.prev.next = current.next; //setting next Node
            }
            Console.WriteLine("The node {0} is removed", key);

        }

        public void Print_List()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        static int Main(string[] args)
        {

            LinkedList list = new LinkedList();
            list.Insert_Front(list, 10);
            list.Insert_Front(list, 20);
            list.Insert_Front(list, 30);
            list.Insert_Front(list, 40);
            list.Insert_Front(list, 50);

            list.Print_List();

            Remove_Node(list,20); //static method does not require object instance

            list.Print_List(); //new list
           
            return 0;

        }

    }
}
