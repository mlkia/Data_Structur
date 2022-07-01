// See https://aka.ms/new-console-template for more information

BTree<int> tree = new BTree<int> ();

Random random = new Random();
int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(1,100);
}

//foreach(int i in array)
//{
//    Console.WriteLine(i);
//    tree.Insert (i);
//}

tree.Insert(65);
tree.Insert(20);
tree.Insert(67);
tree.Insert(14);
tree.Insert(35);
tree.Insert(52);
tree.Insert(27);
tree.Insert(56);
tree.Insert(77);
tree.Insert(84);

Console.WriteLine("--------------------------");

 
Console.WriteLine(tree.Exists(77));
Console.WriteLine(tree.Exists(65));


Console.WriteLine(tree.Count());
