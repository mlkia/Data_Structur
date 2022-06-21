using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MyStack <T>
		{	
			public T[] arr;
			public int top;

			public MyStack(int size)
			{
				arr = new T[size];
				top = -1;
			}

			// Push an element onto stack.
			public void Push(T value)
			{
				if (top == arr.Length-1) //if top = length of array, we can't add mor elements.
				{
					Console.WriteLine("Stack Overflow");
				}else
				{
					top++;
					arr[top] = value;
				}
				
			}

			public int Pop()  // Pop an element from stack, not from array
			{
				if (top == -1)
				{
					Console.WriteLine("Stack Underflow");
					return -1;
				}
				else
				{
					int t = top;
					top--;
					return t;
				}
			}

			public bool isStackEmpty() //To check if stack is empty?.
			{
				if (top == -1)
				{
					return true;
				}
				else
				{
					return false;
				}
			}

			public int Peek() //To peek (show up) the top element of stack.
			{
				if (top == -1)
				{
					Console.WriteLine("Stack Underflow");
					return -1;
				}
				else
				{
					return top;
				}
			}
		}