using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProject
{
    class LinkedList
    {

        private Node head;
        private Node tail;
        private int length; 
        
    
        public LinkedList() 
        {
            head = null;
            tail = null;
        }

        public LinkedList(int data) 
        {

            Node newNode = new Node(data);
            head = newNode;
            tail = newNode;
            length = 1;
            Console.WriteLine(newNode.data);
        }

        public void AppendList(int data)
        {
            Node newNode = new Node(data);

            if (length == 0)
            {
                head = newNode;
                tail = newNode;
                length++;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
               
            }
            
        }

        public void PrintList()
        {
            Console.WriteLine("The nodes in LinkedList : ");
            Console.WriteLine("- - - - - - - - - - - - - -");
            Node temp = head;

            while(temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }

    }
}
