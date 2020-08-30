using System;

namespace LinkedListsOpgave6
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
        public void Add(string firstName, string lastName, string email)
        {
            if (Head == null)
            {
                // Create node as head if no node exists and add data to it
                Head = new CustomLinkedListNode() { Data = new Person() { FirstName = firstName, LastName = lastName, Email = email } };
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
            current.Next = new CustomLinkedListNode() { Data = new Person() { FirstName = firstName, LastName = lastName, Email = email } };
            current.Next.Previous = current;
        }
        public CustomLinkedListNode Find(string email)
        {
            // Checking if Head match the data
            if (Head.Data.Email == email)
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
                    if (current.Next.Data.Email == email)
                    {
                        return current.Next;
                    }
                    current = current.Next;
                }
                return null;
            }
        }
        public void Remove(string email)
        {
            // If head node dont exists throw back exception 
            if (Head == null) throw new NullReferenceException($"Brugeren med email: {email} findes ikke");
            // If head match the data, point the head to the next node
            if (Head.Data.Email == email && Head.Next != null)
            {
                Head = Head.Next;
                Head.Previous = null;
                return;
            }
            else if(Head.Data.Email == email && Head.Next == null)
            {
                Head = null;
                return;
            }
            // Assign Head as the current node
            CustomLinkedListNode current = Head;
            // Looping through other nodes, if there is a match point the node to the next node
            while (current.Next != null)
            {
                if(current.Next.Data.Email == email)
                {
                    current.Next = current.Next.Next;
                    current.Previous = current;
                    return;
                }
                current = current.Next;
            }
            // If no match throw back exception
            throw new NullReferenceException($"Brugeren med email: {email} findes ikke");
        }
        public void Clear()
        {
            Head = null;
        }
        public bool InsertBefore(string firstName, string lastName, string email, CustomLinkedListNode n)
        {
            // Create node
            CustomLinkedListNode newNode = new CustomLinkedListNode() { Data = new Person() };
            // Searching for the selected value in the head and inserting new node before the head
            if (Head.Data.Email == n.Data.Email)
            {
                newNode.Data.Email = email;
                newNode.Data.FirstName = firstName;
                newNode.Data.LastName = lastName;
                newNode.Next = Head;
                Head = newNode;
                Head.Previous = null;
                return true;
            }
            else
            {
                // Assign Head as the current node
                CustomLinkedListNode current = Head;
                // Searching for the selected value in other nodes and inserting new node before the node with the match
                while (current.Next != null)
                {
                    if (current.Next.Data.Email == n.Data.Email)
                    {
                        newNode.Data.Email = email;
                        newNode.Data.FirstName = firstName;
                        newNode.Data.LastName = lastName;
                        newNode.Next = current.Next;
                        current.Next = newNode;
                        current.Next.Previous = current.Previous;
                        return true;
                    }
                    current = current.Next;
                }
                return false;
            }
        }
        public bool InsertAfter(string firstName, string lastName, string email, CustomLinkedListNode n)
        {
            // Create node
            CustomLinkedListNode newNode = new CustomLinkedListNode() { Data = new Person() };
            // Searching for the selected value in the head and inserting new node after the head
            if (Head.Data.Email == n.Data.Email)
            {
                newNode.Data.FirstName = firstName;
                newNode.Data.LastName = lastName;
                newNode.Data.Email = email;
                newNode.Next = Head.Next;
                Head.Next = newNode;
                Head.Previous = null;
                return true;
            }
            else
            {
                // Assign Head as the current node
                CustomLinkedListNode current = Head;
                // Searching for the selected value in other nodes and inserting new node after the node with the match
                while (current.Next != null)
                {
                    if (current.Data.Email == n.Data.Email)
                    {
                        newNode.Data.FirstName = firstName;
                        newNode.Data.LastName = lastName;
                        newNode.Data.Email = email;
                        newNode.Next = current.Next;
                        current.Next = newNode;
                        current.Next.Previous = current.Previous.Previous;
                        return true;
                    }
                    current = current.Next;
                }
                if (current.Data.Email == n.Data.Email && current.Next == null)
                {
                    newNode.Data.FirstName = firstName;
                    newNode.Data.LastName = lastName;
                    newNode.Data.Email = email;
                    newNode.Next = null;
                    current.Next = newNode;
                    current.Next.Previous = current.Previous.Previous;
                    return true;
                }
                return false;
            }
        }

    }
}
