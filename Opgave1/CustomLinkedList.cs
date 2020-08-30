
namespace LinkedListsOpgave1
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
    }
}
