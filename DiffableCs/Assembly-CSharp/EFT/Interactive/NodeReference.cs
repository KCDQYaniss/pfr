namespace EFT.Interactive;

public abstract class NodeReference
{
	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__CreateReferenceTree; //Field offset: 0x0

	}

	public LootPointNode Node; //Field offset: 0x10

	public abstract ENodeStatus CurrentStatus
	{
		 get { } //Length: 0
	}

	protected NodeReference() { }

	public static NodeReference CreateReferenceTree(LootPointNode root) { }

	public abstract ENodeStatus get_CurrentStatus() { }

	public abstract IEnumerable GetSelected() { }

	public abstract void GetSelectedLeavesNonAlloc(List list) { }

	public abstract void SetFilter(IEnumerable filters) { }

	public abstract void SetSelected(bool value) { }

}

