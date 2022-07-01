using BinaryTree;


class BTree<T>: BST<T> where T : IComparable<T>
{
    public Node<T>? Head;
    public int count;

    public void Insert(T value)
    {
        if (Head == null)  
        {
            Head = new Node<T>(value);   
        }
        else
        {
            InsertTo(Head, value);   
        }

        count++; 
    }

    private void InsertTo(Node<T> node, T value)
    {
        if (value.CompareTo(node.Data) < 0 )
        {
            if (node.Left == null)
            {
                node.Left = new Node<T>(value);
            }
            else
            {
                InsertTo(node.Left, value);     
            }
        }
        else
        {
            if (node.Right == null)
            {
                node.Right = new Node<T>(value);
            }
            else
            {
                InsertTo(node.Right, value); 
            }
        }
    }

    public bool Exists(T value)
    {
        Node<T>? current = Head;
        
        while (current != null)      
        {
            if (value.CompareTo(current.Data) < 0 )
            {
                current = current.Left;
            }
            else if (value.CompareTo(current.Data) > 0)
            {
                current = current.Right;
            }
            else
            {
                return true;
            }
        }

        return false;
    }

    public int Count()
    {
        return count;  //--------1
    }
}