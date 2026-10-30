using System;

public class Node
{
    public int Data;
    public Node Left;
    public Node Right;

    public Node(int value)
    {
        Data = value;
        Left = null;
        Right = null;
    }
}

public class BinarySearchTree
{
    public Node Root;

    // Insertar elementos en el arbol
    public void Insert(int data)
    {
        Root = InsertRec(Root, data);
    }

    private Node InsertRec(Node root, int data)
    {
        if (root == null)
            return new Node(data);

        if (data < root.Data)
            root.Left = InsertRec(root.Left, data);
        else if (data > root.Data)
            root.Right = InsertRec(root.Right, data);

        return root;
    }

    // Recorrido Preorden
    public void PreOrder(Node node)
    {
        if (node == null)
            return;

        Console.Write(node.Data + " ");
        PreOrder(node.Left);
        PreOrder(node.Right);
    }

    // Recorrido Inorden
    public void InOrder(Node node)
    {
        if (node == null)
            return;

        InOrder(node.Left);
        Console.Write(node.Data + " ");
        InOrder(node.Right);
    }

    // Recorrido Posorden
    public void PostOrder(Node node)
    {
        if (node == null)
            return;

        PostOrder(node.Left);
        PostOrder(node.Right);
        Console.Write(node.Data + " ");
    }
}

public class Program
{
    public static void Main()
    {
        BinarySearchTree bst = new BinarySearchTree();

        // Claves del Ejercicio 1
        int[] valores = { 45, 23, 67, 12, 34, 56, 89 };

        foreach (int valor in valores)
        {
            bst.Insert(valor);
        }

        Console.WriteLine("RECORRIDOS DEL ARBOL BST");

        Console.Write("Preorden: ");
        bst.PreOrder(bst.Root);

        Console.WriteLine();

        Console.Write("Inorden: ");
        bst.InOrder(bst.Root);

        Console.WriteLine();

        Console.Write("Posorden: ");
        bst.PostOrder(bst.Root);

        Console.WriteLine();
    }
}
