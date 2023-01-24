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

        public void Insert_Front(LinkedList l_list, Data data) //Add Node to the Front
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

        public void Insert_End(LinkedList l_list, Data data)
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
            newNode.prev = last_Node;
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
            if (current != null && current.data.ID == key) //if node to be removed is head
            {
                l_list.head = current.next; //head will be the next one
                l_list.head.prev = null; //first node will be removed
            }

            while (current != null && current.data.ID != key) 
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
                Console.WriteLine("Name:" +current.data.Name);
                Console.WriteLine("Surname:" + current.data.Surname);
                Console.WriteLine("Department:" + current.data.department);
                Console.WriteLine("GNO:" + current.data.gno);
                Console.WriteLine("Age:" + current.data.age);
                Console.WriteLine("ID:" + current.data.ID);
                Console.WriteLine("-----------:");
                current = current.next; //iteration for the next Node while current is not NULL
            }
        }

        static int Main(string[] args)
        {

            LinkedList list = new LinkedList();  
            //5 students are created
            Data s1 = new Data("Nevzat", "Cirpicioglu", 1, "SE" ,2.80, 24);
            Data s2 = new Data("Furkan", "Demir", 2, "SE", 2.80, 22);
            Data s3 = new Data("Beril", "Atav", 3, "SE", 2.80, 23);
            Data s4 = new Data("Oyku", "Ortakci", 4, "SE", 2.80, 22);
            Data s5 = new Data("Aysenur", "Tunc", 5, "SE", 2.80, 24);
            //Add first 4 students to FRONT
            list.Insert_Front(list, s1); //will be 4th in the order because it is added from the front
            list.Insert_Front(list, s2);
            list.Insert_Front(list, s3);
            list.Insert_Front(list, s4);

            list.Insert_End(list, s5); //Add to end of the list

            list.Print_List(); 
       
            return 0;

        }

    }
}
