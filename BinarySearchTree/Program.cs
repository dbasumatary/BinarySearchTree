namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree\n");
            CustomBST customObject = new CustomBST();

            customObject.Add(67);
            customObject.Add(45);
            customObject.Add(61);
            customObject.Add(38);
            customObject.Add(51);
            customObject.Add(64);
            customObject.Add(81);
        }
    }
}