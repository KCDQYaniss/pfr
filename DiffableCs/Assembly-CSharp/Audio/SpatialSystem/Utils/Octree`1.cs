namespace Audio.SpatialSystem.Utils;

public class Octree`1
{
	private class Node
	{
		private readonly int _maxItems; //Field offset: 0x0
		private readonly int _maxDepth; //Field offset: 0x0
		private readonly int _depth; //Field offset: 0x0
		[CompilerGenerated]
		private Node[] <Children>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private readonly Bounds <Bounds>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"Item", "ItemBounds"})]
		private readonly List <Items>k__BackingField; //Field offset: 0x0

		public Bounds Bounds
		{
			[CompilerGenerated]
			 get { } //Length: 21
		}

		public private Node[] Children
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"Item", "ItemBounds"})]
		public List Items
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public Node(Bounds bounds, int maxItems, int maxDepth, int depth = 0) { }

		[CompilerGenerated]
		public Bounds get_Bounds() { }

		[CompilerGenerated]
		public Node[] get_Children() { }

		[CompilerGenerated]
		public List get_Items() { }

		public void Insert(T item, Bounds itemBounds) { }

		public void Query(Vector3 point, List result) { }

		public void Query(Bounds bounds, List result) { }

		[CompilerGenerated]
		private void set_Children(Node[] value) { }

		private void Subdivide() { }

	}

	private readonly Node _root; //Field offset: 0x0

	public Octree`1(Bounds worldBounds, int maxItemsPerNode = 8, int maxDepth = 6) { }

	public void Insert(T item, Bounds itemBounds) { }

	public void Query(Vector3 point, List result) { }

	public List Query(Vector3 point) { }

	public void Query(Bounds bounds, List result) { }

	public List Query(Bounds bounds) { }

}

