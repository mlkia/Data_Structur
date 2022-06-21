// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


QueueArray <int> obj = new QueueArray <int>(5);

obj.Enqueue(1); //Add a value to the queue.
obj.Enqueue(3);
obj.Enqueue(7);
obj.Enqueue(11);
obj.Enqueue(19);



//Console.WriteLine(obj.arr[obj.Head]);
//Console.WriteLine(obj.arr[obj.Tail-1]);

Console.WriteLine(obj.Dequeue());
Console.WriteLine(obj.Dequeue());
Console.WriteLine(obj.Dequeue());
Console.WriteLine(obj.Dequeue());

Console.WriteLine("Is the Queue empty? " + obj.isQueueEmpty());