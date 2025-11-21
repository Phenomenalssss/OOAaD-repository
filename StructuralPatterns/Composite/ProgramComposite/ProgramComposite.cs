using Composite;

namespace ProgramCompsoite
{
    class ProgramCompsoite
    {
        public static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();

            tree.Add(5);
            tree.Add(12);
            tree.Add(1);
            tree.Add(7);
            tree.Add(0);
            tree.Add(8);
            tree.Add(2);
            tree.Add(6);
            Console.WriteLine($"Количество элементов = {tree.Count}");
            Console.WriteLine($"Высота дерева = {tree.Height()}");
            tree.Max();
            tree.Min();
            tree.IsEmptyString();
            tree.Contains(5);
            tree.Contains(3);

            double[] values = tree.GetAllValues();
            Console.WriteLine("Элементы дерева: " + string.Join(", ", values));

            tree.InOrderWalk();

            tree.Remove(3);
            Console.WriteLine("-------------------------------------------------");

            tree.Remove(5);
            Console.WriteLine($"Количество элементов = {tree.Count}");
            Console.WriteLine($"Высота дерева = {tree.Height()}");
            tree.InOrderWalk();
            Console.WriteLine("-------------------------------------------------");

            tree.Remove(7);
            Console.WriteLine($"Количество элементов = {tree.Count}");
            Console.WriteLine($"Высота дерева = {tree.Height()}");
            tree.InOrderWalk();
            Console.WriteLine("-------------------------------------------------");

            tree.Clear();
            Console.WriteLine($"Количество элементов = {tree.Count}");
            tree.IsEmpty();
            tree.InOrderWalk();
        }
    }
}