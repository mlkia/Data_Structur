// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



MyStack<int> obj = new MyStack<int> (3);

obj.Push(1);
obj.Push(2);
obj.Push(3);
obj.Pop();
obj.Pop();
obj.Push(4);
obj.Pop();



Console.WriteLine(obj.arr[2]); // Print an element from the stack.

//Console.WriteLine("The Top = " + obj.arr[obj.top]); // Print the value of top element from the stack, (Dont use it if the stack is empty).
Console.WriteLine(obj.Peek()); // To get the index of top element.

Console.WriteLine("The Top = " + obj.arr[obj.top]);  //Print the value of top element from the stack, (Dont use it if the stack is empty).

Console.WriteLine("Is the Stack Epmty? " + obj.isStackEmpty()); // Print the status of the stack. ); 


// app or program to use the stack.
 // 1- Reverse: To reverse the string.

 string name =Console.ReadLine();

 static string Reverse(string name)
 {
	string rename = "";

 	MyStack<char> obj = new MyStack<char> (name.Length);

		foreach(var x in name)
			{
				obj.Push(x);
			}

			while (!obj.isStackEmpty())
			{
				//Console.Write(obj.arr[obj.Pop()]);
				//Or 

				rename = rename + obj.arr[obj.Pop()];
			}
				
	return rename;
 }

	//Reverse(name); 
	// Or 
 	var x = Reverse(name);
	Console.WriteLine(x); 