namespace Assignment2
{
    public class DoublyLinkedListNode<T>
    {
        public T Data { get; set; }
        public DoublyLinkedListNode<T> Next { get; set; }
        public DoublyLinkedListNode<T> Prev { get; set; }

        public DoublyLinkedListNode(T data)
        {
            this.Data = data;
            this.Next = null;
            this.Prev = null;
        }
    }
}