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
    }
}
