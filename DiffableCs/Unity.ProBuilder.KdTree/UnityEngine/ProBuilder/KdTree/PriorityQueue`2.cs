namespace UnityEngine.ProBuilder.KdTree;

internal class PriorityQueue`2 : IPriorityQueue
{
	private ITypeMath priorityMath; //Field offset: 0x0
	private ItemPriority[] queue; //Field offset: 0x0
	private int capacity; //Field offset: 0x0
	private int count; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 4
	}

	public PriorityQueue`2(int capacity, ITypeMath priorityMath) { }

	public override TItem Dequeue() { }

	public override void Enqueue(TItem item, TPriority priority) { }

	private void ExpandCapacity() { }

	public override int get_Count() { }

	public TItem GetHighest() { }

	public TPriority GetHighestPriority() { }

	private void ReorderItem(int index, int direction) { }

}

