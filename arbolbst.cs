
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

    // Insertar elementos
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

    // Mostrar árbol
    public void InOrder(Node root)
    {
        if (root != null)
        {
            InOrder(root.Left);
            Console.Write(root.Data + " ");
            InOrder(root.Right);
        }
    }

    // Identificar nodos hoja
    public void MostrarHojas(Node root)
    {
        if (root == null)
            return;

        if (root.Left == null && root.Right == null)
        {
            Console.Write(root.Data + " ");
        }

        MostrarHojas(root.Left);
        MostrarHojas(root.Right);
    }

    // Dibujar árbol
    public void DibujarArbol(Node root, int espacio = 0)
    {
        if (root == null)
            return;

        espacio += 5;

        DibujarArbol(root.Right, espacio);

        Console.WriteLine();

        for (int i = 5; i < espacio; i++)
            Console.Write(" ");

        Console.WriteLine(root.Data);

        DibujarArbol(root.Left, espacio);
    }
}

public class Program
{
    public static void Main()
    {
        BinarySearchTree bst = new BinarySearchTree();

        // Claves del ejercicio
        int[] claves = { 45, 23, 67, 12, 34, 56, 89 };

        foreach (int clave in claves)
        {
            bst.Insert(clave);
        }

        Console.WriteLine("ARBOL BINARIO DE BUSQUEDA");
        bst.DibujarArbol(bst.Root);

        Console.WriteLine("\n\nRECORRIDO INORDER:");
        bst.InOrder(bst.Root);

        Console.WriteLine("\n\nNODOS HOJA:");
        bst.MostrarHojas(bst.Root);

        Console.WriteLine("\n\nTotal de nodos: 7");
    }
}
