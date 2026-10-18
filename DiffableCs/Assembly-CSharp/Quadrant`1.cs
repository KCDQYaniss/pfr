//Type is in global namespace

public class Quadrant`1
{
	private Quadrant parent; //Field offset: 0x0
	private Rect bounds; //Field offset: 0x0
	protected List nodes; //Field offset: 0x0
	protected Quadrant topLeft; //Field offset: 0x0
	protected Quadrant topRight; //Field offset: 0x0
	protected Quadrant bottomLeft; //Field offset: 0x0
	protected Quadrant bottomRight; //Field offset: 0x0

	internal Rect Bounds
	{
		internal get { } //Length: 11
	}

	internal Quadrant Parent
	{
		internal get { } //Length: 5
	}

	public Quadrant`1(Quadrant parent, Rect bounds) { }

	protected override Quadrant CreateQuadrant(Quadrant parent, Rect bounds) { }

	internal Rect get_Bounds() { }

	internal Quadrant get_Parent() { }

	public List GetDataList() { }

	internal void GetIntersectingNodes(List nodes, Rect bounds) { }

	private static void GetIntersectingNodes(List last, List nodes, Rect bounds) { }

	internal bool HasIntersectingNodes(Rect bounds) { }

	private static bool HasIntersectingNodes(List last, Rect bounds) { }

	internal Quadrant Insert(TNodeData node, Rect bounds, float sizeLimit) { }

	internal bool RemoveNode(TNodeData node) { }

}

