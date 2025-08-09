using System.ComponentModel.DataAnnotations;

public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        if (value == Data)
            return;

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        if (value == Data)
        {
            return true;
        }

        if (Left == null && Right == null)
            return false;

        return Left!.Contains(value) || Right!.Contains(value);
    }

    public int GetHeight()
    {
        int lHeight = Left is not null ? Left.GetHeight() : 0;
        int rHeight = Right is not null ? Right.GetHeight() : 0;

        return Math.Max(lHeight, rHeight) + 1;
    }
}
