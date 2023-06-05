namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree\n");
            CustomBST customTree = new CustomBST();

            customTree.Add(67);
            customTree.Add(45);
            customTree.Add(38);
            customTree.Add(51);
            customTree.Add(64);
            customTree.Add(81);

            Console.WriteLine("Check 64 : " + customTree.Search(64));
            Console.WriteLine("Check 52 : " + customTree.Search(52));
        }
    }
}