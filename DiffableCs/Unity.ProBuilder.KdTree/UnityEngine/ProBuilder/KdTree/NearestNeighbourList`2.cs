namespace UnityEngine.ProBuilder.KdTree;

internal class NearestNeighbourList`2 : INearestNeighbourList
{
	private PriorityQueue queue; //Field offset: 0x0
	private ITypeMath distanceMath; //Field offset: 0x0
	private int maxCapacity; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 26
	}

	public bool IsCapacityReached
	{
		 get { } //Length: 32
	}

	public override int MaxCapacity
	{
		 get { } //Length: 4
	}

	public NearestNeighbourList`2(int maxCapacity, ITypeMath distanceMath) { }

	public override bool Add(TItem item, TDistance distance) { }

	public override int get_Count() { }

	public bool get_IsCapacityReached() { }

	public override int get_MaxCapacity() { }

	public override TItem GetFurtherest() { }

	public TDistance GetFurtherestDistance() { }

	public override TItem RemoveFurtherest() { }

}

