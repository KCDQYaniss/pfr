namespace EFT.Interactive;

public class ExtendedLeafReference : ExtendedNodeReference
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__5_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <SetFilter>b__5_0(LootableContainerParameters x) { }

	}

	private bool _selected; //Field offset: 0x20

	public virtual ENodeStatus CurrentStatus
	{
		 get { } //Length: 14
	}

	public ExtendedLeafReference() { }

	[CompilerGenerated]
	private bool <SetFilter>b__5_1(LootableContainerParameters x) { }

	public virtual ENodeStatus get_CurrentStatus() { }

	public virtual IEnumerable GetSelected() { }

	public virtual void SetFilter(IEnumerable filters) { }

	public virtual void SetSelectedRecursive(bool value) { }

}

