namespace EFT.Interactive;

public class NonLeafReference : NodeReference
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__3_0; //Field offset: 0x8
		public static Func <>9__3_1; //Field offset: 0x10
		public static Func <>9__6_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <get_CurrentStatus>b__3_0(NodeReference x) { }

		internal bool <get_CurrentStatus>b__3_1(NodeReference x) { }

		internal IEnumerable <GetSelected>b__6_0(NodeReference x) { }

	}

	public bool Open; //Field offset: 0x18
	public NodeReference[] Children; //Field offset: 0x20

	public virtual ENodeStatus CurrentStatus
	{
		 get { } //Length: 667
	}

	public NonLeafReference() { }

	public virtual ENodeStatus get_CurrentStatus() { }

	public virtual IEnumerable GetSelected() { }

	public virtual void GetSelectedLeavesNonAlloc(List list) { }

	public virtual void SetFilter(IEnumerable filters) { }

	public virtual void SetSelected(bool value) { }

}

