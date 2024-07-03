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
        }

        public void AppendList(int data)
        {
            Node newNode = new Node(data);
            tail.next = newNode;
            tail = newNode;
            length++;
        }

        public void PrintList()
        {
            Console.WriteLine("The nodes in LinkedList : ");
            Console.WriteLine("- - - - - - - - - - - - - ");

            Node temp = head;
            
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
            
        }
        
        public void ListLength()
        {
            Console.WriteLine("The length of LinkedList is : " + length);
        }

        public void PrintHead()
        {
            if(head != null) 
            {
                Console.WriteLine("The head of LinkedList is : " + head.data);
            }
            
        }

        public void PrintTail() 
        {
            if(tail != null)
            {
                Console.WriteLine("The tail of LinkedList is : " + tail.data);
            }
            
        }

        public Node DeleteLastNode()
        {
            if(length == 0)
                return null;
          
                Node temp = head;
                Node son = head;

                while(temp.next != null)
                {
                    son = temp;
                    temp = temp.next;
                }

                tail = son;
                tail.next = null;
           
          

            if (length == 1)
            {
                head = null;
                tail = null;
            }

            length--;
            return temp;

        }

        public Node DeleteFirstNode()
        {
            if (length == 0)
                return null;

            Node temp = head;

            head = head.next;
            temp.next = null;
            length--;

            if(length == 1)
            {
                head = null;
                tail = null;
            }

            return temp;
           
        }

    }
}
