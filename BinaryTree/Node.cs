

public class Node<T>
{
	public T Data { get; set; }
	public Node<T>? Right { get; set; }
	public Node<T>? Left { get; set; }

	public Node(T value)
	{
		Left = null;
		Right = null;
		Data = value;
	}

}