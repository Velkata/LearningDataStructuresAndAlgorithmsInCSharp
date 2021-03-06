﻿using System;
using System.Collections.Generic;

namespace Learning.DataStructures.LinkedList
{
    public class Node
    {
        public int data { get; set; }
        public Node next { get; set; }

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

    /// <summary>
    /// This LinkedList is created only for learning purposes. 
    /// You should you the .NET LinkedList object in production.
    /// LinkedList is double linked.
    /// See also Circular Linked List: http://www.tutorialspoint.com/data_structures_algorithms/circular_linked_list_algorithm.htm
    /// </summary>
    public class SinglyLinkedList
    {
        public Node head;
        public IList<int> output;

        public SinglyLinkedList()
        {
            output = new List<int>();
        }

        public void PushFirst(int value)
        {
            // Allocate the Node & Put in the data
            Node newNode = new Node(value);

            // Make next of new Node as head
            newNode.next = head;

            // Move the head to point to new Node
            head = newNode;
        }

        public void PushLast(int value)
        {
            // Allocate the Node & Put in the data
            Node node = new Node(value);
            if (head == null)
            {
                head = node;
            }
            else
            {
                var current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = node; //new head
            }
        }

        // This function prints contents of linked list starting from  the given node */
        public IList<int> PrintList()
        {
            Node tnode = head;
            IList<int> list = new List<int>();

            while (tnode != null)
            {
                Console.Write(tnode.data + "->");
                list.Add(tnode.data);
                tnode = tnode.next;
            }
            Console.Write("null");
            return list;
        }

        public void Remove(Node node)
        {
            if (head == null) return;

            if (head == node)
            {
                head = head.next;
                node.next = null;
            }

            var current = head;
            while (current?.next != null)
            {
                if (current.next == node)
                {
                    current.next = node.next;
                }

                current = current.next;
            }
        }

        // Given only a pointer/reference to a node to be deleted in a singly linked list, how do you delete it?
        // http://www.geeksforgeeks.org/given-only-a-pointer-to-a-node-to-be-deleted-in-a-singly-linked-list-how-do-you-delete-it/
        public void DeleteNode(Node nodePtr)
        {
            Node temp = nodePtr.next;
            nodePtr.data = temp.data;
            nodePtr.next = temp.next;
            temp = null;
        }

        public void Reverse()
        {
            if (head == null) return;

            Node prev = null;
            Node curr = null;
            Node nxt = head;

            while (nxt != null)
            {
                curr = nxt;
                nxt = curr.next;
                curr.next = prev;
                prev = curr;
            }

            head = curr;
        }

        public Node ReverseRecurive(Node curr, Node prev)
        {
            if (curr.next == null)
            {
                head = curr;
                curr.next = prev;
                return null;
            }
            Node nxt = curr.next;
            curr.next = prev;

            ReverseRecurive(nxt, curr);

            return head;
        }
    }
}
