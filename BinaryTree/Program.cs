// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

BNood Head= new BNood(8); 
BNood Right= new BNood(5); 
BNood Left= new BNood(3); 

Console.WriteLine(Head.value);

Head.Right= Right;
Head.Left= Left;

Console.WriteLine(Head.Right.value);
Console.WriteLine(Head.Left.value);