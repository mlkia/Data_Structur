
class QueueArray <T>
{

public int Head;
public int Tail;
public int Count;
public T [] arr;

public QueueArray(int size)
	{
		arr = new T[size];
		Head = Tail = Count = 0;
	}

	public void Enqueue(T value) // To add an element to the end of the queue
	{
		if (Tail == arr.Length)
		{
			Console.WriteLine("Queue is full");
		}else 
		{
			arr[Tail] = value;
			Tail++;
			Count++;
		}
	}

	public T Dequeue() // To det out an element from the front of the queue.
	{
		T value;
		if (Count == 0)
		{
			throw new Exception("Queue is empty");
			
		}else
		{
			value = arr[Head];  //The Head will start with index 0, and value takes the value of the index 0.
			Head++;
			Count--;
		}
		return value;
	}

	public bool isQueueEmpty()
	{
		if (Count == 0)
		{
			return true;
		}else
		{
			return false;
		}
	}
}