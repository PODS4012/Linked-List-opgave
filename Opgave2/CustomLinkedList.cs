using System;

namespace LinkedListsOpgave2
{
    public class CustomLinkedList
    {
        public CustomLinkedListNode Head { get; set; }

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
                // Looping through other nodes and checking if there is a match
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
            if (Head == null) throw new NullReferenceException($"Node me nr. {data} findes ikke");
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
    }
}
