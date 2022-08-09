namespace HashTable
{
    public class CustomHashTable
    {
        public Node head;

        public void AddLast(string data)
        {
            Node newnode = new Node(data);
            if (head == null)
            {
                head = newnode;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    if (newnode.data == temp.data)
                    {
                        Remove(data);
                        newnode.freq += 1;
                    }
                    temp = temp.next;
                }

                temp.next = newnode;
            }
            

        }

        public void Remove(string data)
        {
            Node temp = head;
            Node prev = head;

            if (head == null)
                Console.WriteLine("Empty!");
            else if (temp.data == data)
                head = temp.next;
            else
            {
                while (temp.data != data)
                {
                    prev = temp;
                    temp = temp.next;
                }
                prev.next = temp.next;
                temp = temp.next;
            }
            
        }

        public void display()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.data+" "+temp.freq);
                temp = temp.next;
            }
        }
        
    }
}

