namespace EFT.Interactive;

public abstract class ExtendedNodeReference
{
	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__CreateReferenceTree; //Field offset: 0x0

	}

	public LootPointNode Node; //Field offset: 0x10
	public int Quantity; //Field offset: 0x18
	public int SpawnProbability; //Field offset: 0x1C

	public abstract ENodeStatus CurrentStatus
	{
		 get { } //Length: 0
	}

	protected ExtendedNodeReference() { }

	public static ExtendedNodeReference CreateReferenceTree(LootPointNode root) { }

	public abstract ENodeStatus get_CurrentStatus() { }

	public abstract IEnumerable GetSelected() { }

	public abstract void SetFilter(IEnumerable filters) { }

	public abstract void SetSelectedRecursive(bool value) { }

}

