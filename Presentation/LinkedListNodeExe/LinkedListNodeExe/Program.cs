namespace LinkedListNodeExe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a linked list of integers
            LinkedList<int> list = new LinkedList<int>();

            // Add some nodes to the list
            LinkedListNode<int> node1 = list.AddLast(10);
            LinkedListNode<int> node2 = list.AddLast(20);
            LinkedListNode<int> node3 = list.AddLast(30);

            // Traverse the list and print the elements
            LinkedListNode<int> currentNode = list.First;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }

            // Remove the second node
            list.Remove(node2);

            // Traverse the list again and print the elements
            currentNode = list.First;
            Console.WriteLine("Ikinci node silinenden sonra listin veziyyeti: ");
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }
    }
}