namespace EFT.Interactive;

public class ExtendedNonLeafReference : ExtendedNodeReference
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__3_0; //Field offset: 0x8
		public static Func <>9__3_1; //Field offset: 0x10
		public static Func <>9__5_0; //Field offset: 0x18
		public static Func <>9__6_1; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal bool <get_CurrentStatus>b__3_0(ExtendedNodeReference x) { }

		internal bool <get_CurrentStatus>b__3_1(ExtendedNodeReference x) { }

		internal IEnumerable <GetSelected>b__5_0(ExtendedNodeReference x) { }

		internal string <SetFilter>b__6_1(LootableContainerParameters x) { }

	}

	public bool Open; //Field offset: 0x20
	public ExtendedNodeReference[] Children; //Field offset: 0x28

	public virtual ENodeStatus CurrentStatus
	{
		 get { } //Length: 667
	}

	public ExtendedNonLeafReference() { }

	[CompilerGenerated]
	private bool <SetFilter>b__6_0(LootableContainerParameters x) { }

	public virtual ENodeStatus get_CurrentStatus() { }

	public virtual IEnumerable GetSelected() { }

	public virtual void SetFilter(IEnumerable filters) { }

	public virtual void SetSelectedRecursive(bool value) { }

}

