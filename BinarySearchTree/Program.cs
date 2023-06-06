namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree\n");
            CustomBST customTree = new CustomBST();

            customTree.Add(30);
            customTree.Add(35);
            customTree.Add(57);
            customTree.Add(15);
            customTree.Add(63);
            customTree.Add(49);
            customTree.Add(89);
            customTree.Add(77);
            customTree.Add(67);
            customTree.Add(98);
            customTree.Add(91);

            Console.WriteLine("Check 64 : " + customTree.Search(64));
            Console.WriteLine("Check 57 : " + customTree.Search(57));

            Console.Write("\nPreorder Traversal : ");
            customTree.PreorderDisplay(customTree.ReturnRoot());

            Console.Write("\nInorder Traversal : ");
            customTree.InorderDisplay(customTree.ReturnRoot());
        }
    }
}