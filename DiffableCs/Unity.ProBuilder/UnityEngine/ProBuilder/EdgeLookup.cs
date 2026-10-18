namespace UnityEngine.ProBuilder;

public struct EdgeLookup : IEquatable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public Dictionary lookup; //Field offset: 0x10

		public <>c__DisplayClass16_0() { }

		internal EdgeLookup <GetEdgeLookup>b__0(Edge x) { }

	}

	private Edge m_Local; //Field offset: 0x0
	private Edge m_Common; //Field offset: 0x8

	public Edge common
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public Edge local
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public EdgeLookup(Edge common, Edge local) { }

	public EdgeLookup(int cx, int cy, int x, int y) { }

	public override bool Equals(EdgeLookup other) { }

	public virtual bool Equals(object obj) { }

	public Edge get_common() { }

	public Edge get_local() { }

	public static IEnumerable GetEdgeLookup(IEnumerable edges, Dictionary lookup) { }

	public static HashSet GetEdgeLookupHashSet(IEnumerable edges, Dictionary lookup) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(EdgeLookup a, EdgeLookup b) { }

	public static bool op_Inequality(EdgeLookup a, EdgeLookup b) { }

	public void set_common(Edge value) { }

	public void set_local(Edge value) { }

	public virtual string ToString() { }

}

