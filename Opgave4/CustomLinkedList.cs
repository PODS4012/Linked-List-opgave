using System;

namespace LinkedListsOpgave4
{
    public class CustomLinkedList
    {
        public CustomLinkedListNode Head { get; private set; }
        public CustomLinkedListNode First { get { return Head; } }
        public CustomLinkedListNode Last
        {
            get
            {
                if (Head.Next == null)
                {
                    return Head;
                }
                else
                {
                    CustomLinkedListNode current = Head;
                    while (current.Next != null)
                    {
                        if (current.Next.Next == null)
                        {
                            return current.Next;
                        }
                        current = current.Next;
                    }
                    return null;
                }
            }
        }
        public void Add(int data)
        {
            if (Head == null)
            {
                // Create node as head if no node exists and add data to it
                Head = new CustomLinkedListNode() { Data = data };
                return;
            }
            // Assign Head as the current node
            CustomLinkedListNode current = Head;
            // Loop to find the last node without the Next pointer
            while (current.Next != null)
            {
                current = current.Next;
            }
            // Create new node at the end of the last node
            current.Next = new CustomLinkedListNode() { Data = data };
        }
        public CustomLinkedListNode Find(int data)
        {
            // Checking if Head match the data
            if (Head.Data == data)
            {
                return Head;
            }
            else
            {
                // Assign Head as the current node
                CustomLinkedListNode current = Head;
                //If value not found in the head, looping through all other nodes for the value
                while (current.Next != null)
                {
                    if (current.Next.Data == data)
                    {
                        return current.Next;
                    }
                    current = current.Next;
                }
                return null;
            }
        }
        public void Remove(int data)
        {
            // If head node dont exists throw back exception 
            if (Head == null) throw new NullReferenceException($"Node me nr. { data } findes ikke");
            // If head match the data, point the head to the next node
            if (Head.Data == data)
            {
                Head = Head.Next;
                return;
            }

            // Assign Head as the current node
            CustomLinkedListNode current = Head;
            // Looping through other nodes, if there is a match point the node to the next node
            while (current.Next != null)
            {
                if(current.Next.Data == data)
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
            // If no match throw back exception
            throw new NullReferenceException($"Node me nr. { data } findes ikke");
        }
        public void Clear()
        {
            Head = null;
        }

        public bool InsertBefore(int data, CustomLinkedListNode n)
        {
            // Create node
            CustomLinkedListNode newNode = new CustomLinkedListNode();
            // Searching for the selected value in the head and inserting new node before the head
            if (Head.Data == n.Data)
            {
                newNode.Data = data;
                newNode.Next = Head;
                Head = newNode;
                return true;
            }
            else
            {
                // Assign Head as the current node
                CustomLinkedListNode current = Head;
                // Searching for the selected value in other nodes and inserting new node before the node with the match
                while (current.Next != null)
                {
                    if (current.Next.Data == n.Data)
                    {
                        newNode.Data = data;
                        newNode.Next = current.Next;
                        current.Next = newNode;
                        return true;
                    }
                    current = current.Next;
                }
                return false;
            }
        }
        public bool InsertAfter(int data, CustomLinkedListNode n)
        {
            // Create node
            CustomLinkedListNode newNode = new CustomLinkedListNode();
            // Searching for the selected value in the head and inserting new node after the head
            if (Head.Data == n.Data)
            {
                newNode.Data = data;
                newNode.Next = Head.Next;
                Head.Next = newNode;
                return true;
            }
            else
            {
                // Assign Head as the current node
                CustomLinkedListNode current = Head;
                // Searching for the selected value in other nodes and inserting new node after the node with the match
                while (current.Next != null)
                {
                    if (current.Data == n.Data)
                    {
                        newNode.Data = data;
                        newNode.Next = current.Next;
                        current.Next = newNode;
                        return true;
                    }
                    current = current.Next;
                }
                if (current.Data == n.Data && current.Next == null)
                {
                    newNode.Data = data;
                    newNode.Next = null;
                    current.Next = newNode;
                    return true;
                }
                return false;
            }
        }
    }
}
