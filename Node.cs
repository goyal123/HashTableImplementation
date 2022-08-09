namespace HashTable
{
    public class Node
    {
        public string data;
        public int freq;
        public Node next;

        public Node(string data)
        {
            this.data = data;
            this.freq = 1;
            this.next = null;
        }

    }
}
