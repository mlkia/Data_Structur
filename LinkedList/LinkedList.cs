using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class List<T>
{
	MyNode<T> Head;
	MyNode<T> Tail;

	public List()
	{
		Head = Tail = null;
	}

//insert the data at the top of the list
	public void AddFirst(T value)
	{
		MyNode<T> newNode = new MyNode<T>(value);

		if (Head == null)
		{
			Head = Tail = newNode;
		}
		else
		{
			newNode.Next = Head;
			Head = newNode;
		}
	}

//insert the data at the end of the list
	public void AddLast(T value)
	{
		MyNode<T> newNode = new MyNode<T>(value);

		if (Head == null)
		{
			Head = Tail = newNode;
		}
		else
		{
			Tail.Next = newNode;
			Tail = newNode;
		}
	}

	

	public void Display()
	{
		MyNode<T> Start = Head;
		if (Start == null)
		{
			Console.WriteLine("List is empty");
		}
		else
		{
			while (Start != null)
			{
				Console.WriteLine(Start.Data);
				//Console.WriteLine(Start.Next); Test to see if the next node is null.
				
				Start = Start.Next;
			}
		}
	}

	public void Search(T value)
	{
		MyNode<T> current = Head;
		int possition = 0;

		while (current != null)
		{
			if (value.Equals( current.Data))
			{
				Console.WriteLine("The value is at possition " + possition);
				return;
			}

			possition += 1;
			current = current.Next;

			if (current == null)
			{
				Console.WriteLine("The value is not in the list");
			}
		}
	}
		
	public void Remove(T value)
	{
		if (Head == null)  //If the List is empty.
		{
			Console.WriteLine("List is empty");
			return;
		}

		//If the value is at the head of the list.
		if(Head.Data.Equals(value))
		{
			Head = Head.Next;
			return;
		}
		//If the value after the head.
		MyNode<T> current = Head.Next;
		MyNode<T> previous = Head;

		while (current != null)
		{
			if (current.Data.Equals(value))
			{
				previous.Next = current.Next;

				//if The value is at the end of the list. We do that to can add a new value at the end of the list again.
				if (previous.Next == null)
				{
					Tail = previous;
				}
				return;
			}

			previous = previous.Next;
			current = current.Next;

			if (current == null)
			{
				Console.WriteLine("The value is not in the list");
			}
		}
	}

	public void insert (T value, int poss)
	{
		MyNode<T> current = Head;
		for (int i=0; i<poss; i++)
		{
			current = current.Next;
			if (current == null)
			{
				Console.WriteLine("Out of the range");
				return;
			}
		}

		MyNode<T> newNode = new MyNode<T>(value);
		newNode.Next = current.Next;
		current.Next = newNode;
	}

	public void count ()
	{
		int count = 0;
		MyNode<T> current = Head;

		while (current != null)
		{
			count += 1;
			current = current.Next;
		}
			Console.WriteLine("The number of elements in the list is " + count);
	}

	//To clear all the nodes in the list
	public void clear () 
	{
		Head = Tail = null;
	}
}