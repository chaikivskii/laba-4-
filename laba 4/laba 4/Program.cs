using System;
namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            Console.WriteLine($"Вид дерева: {tree.Species}");
            Console.WriteLine();
            tree.Leaf.Blossom();
            Console.WriteLine();
            tree.Leaf.Fall();
            Console.WriteLine();
            tree.Branch.CoverWithHoarfrost();
            Console.WriteLine();
            tree.Leaf.TurnYellow();
        }
    }
    public class Tree
    {
        public string Species { get; } = "Яблуння";

        public Leaf Leaf { get; } = new Leaf();

        public Branch Branch { get; } = new Branch();
    }
    public class Leaf
    {
        public void Blossom()
        {
            Console.WriteLine("Лист зацвітає.");
        }

        public void Fall()
        {
            Console.WriteLine("Лист опадає.");
        }

        public void TurnYellow()
        {
            Console.WriteLine("Лист пожовтів.");
        }
    }
    public class Branch
    {
        public void CoverWithHoarfrost()
        {
            Console.WriteLine("Гілка покривається інеєм.");
        }
    }
}
