//Type is in global namespace

public class QueueSum
{
	private Queue _queue; //Field offset: 0x10
	private float _sum; //Field offset: 0x18

	public float Sum
	{
		 get { } //Length: 6
	}

	public QueueSum(int capacity = 0) { }

	public float Dequeue() { }

	public void DequeueCount(int count) { }

	public void Enqueue(float value) { }

	public float get_Sum() { }

}

