using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class MyNode<T>
{
	public T Data { get; set; }
	public MyNode<T> Next { get; set; }

	public MyNode (T value)
		{
			Data = value;
			Next = null;
		}
}




