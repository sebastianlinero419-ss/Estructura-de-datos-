
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

    // Recorrido Inorden
    public void InOrder(Node node)
    {
        if (node == null)
            return;

        InOrder(node.Left);
        Console.Write(node.Data + " ");
        InOrder(node.Right);
    }

    // Verificar si la secuencia esta ordenada
    public bool VerificarOrden(Node root, ref int anterior, ref bool primero)
    {
        if (root == null)
            return true;

        if (!VerificarOrden(root.Left, ref anterior, ref primero))
            return false;

        if (!primero && root.Data <= anterior)
            return false;

        anterior = root.Data;
        primero = false;

        return VerificarOrden(root.Right, ref anterior, ref primero);
    }
}

public class Program
{
    public static void Main()
    {
        BinarySearchTree bst = new BinarySearchTree();

        // Valores del Ejercicio 1
        int[] valores = { 45, 23, 67, 12, 34, 56, 89 };

        foreach (int valor in valores)
        {
            bst.Insert(valor);
        }

        Console.WriteLine("RECORRIDO INORDEN:");
        bst.InOrder(bst.Root);

        Console.WriteLine("\n");

        // Comprobar orden ascendente
        int anterior = 0;
        bool primero = true;

        bool ordenado = bst.VerificarOrden(
            bst.Root, ref anterior, ref primero
        );

        if (ordenado)
            Console.WriteLine("El recorrido esta ordenado de menor a mayor.");
        else
            Console.WriteLine("El recorrido no esta ordenado.");
    }
}
