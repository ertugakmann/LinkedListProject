﻿using System;
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
            if (head != null)
            {
                Console.WriteLine("The head of LinkedList is : " + head.data);
            }

        }

        public void PrintTail()
        {
            if (tail != null)
            {
                Console.WriteLine("The tail of LinkedList is : " + tail.data);
            }

        }

        public Node DeleteLastNode()
        {
            if (length == 0)
                return null;

            Node temp = head;
            Node son = head;

            while(temp.next != null)
            {
                son = temp;
                temp = temp.next;
            }

            tail = son;
            son.next = null;
            length--;

            if (length == 1)
            {
                head = null;
                tail = null;
            }

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

            if (length == 0)
            {
                tail = null;
                head = null;
            }   

            return temp;
        }

        public void AddFirst(int data)
        {
            Node newNode = new Node(data);

            if (length == 0)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }

            
        }

        public Node GetNode(int index) 
        {
            if (index >= 0 && length > index) 
            {
                Node temp = head;

                for (int i = 0; i < index; i++)
                {
                    temp = temp.next;
                }
                return temp;
            }
            else
            {
                Console.WriteLine("Please enter a valid index number...");
                return null;
            }
        }

        public void SetNode(int index, int data)
        {
            Node temp = GetNode(index);

            if(temp != null)
            {
                temp.data = data;
            }
            else
            {
                Console.WriteLine("That Node is unvalid...");
            }
        }

        public bool InsertNode(int index, int data)
        {
            if(index >= 0 && index < length)
            {
                if(index == 0)
                {
                    AddFirst(data);
                    return true;
                }

                if(index == length)
                {
                    AppendList(data);
                    return true;
                }

                Node newNode = new Node(data);
                Node temp = GetNode(index - 1);

                newNode.next = temp.next;
                temp.next = newNode;
                length++;
                return true;
            }
            return false;
            
        }

        public Node DeleteNode(int index)
        {
            if (index >= 0 && index < length)
            {
                if (index == 0) 
                    DeleteFirstNode();

                if (index == length - 1)
                    DeleteLastNode();

                Node temp = GetNode(index - 1);
                Node deleteNode = GetNode(index);

                temp.next = deleteNode.next;
                deleteNode.next = null;
                length--;

                return deleteNode;
            }
            else
                return null;
        }

    }
}