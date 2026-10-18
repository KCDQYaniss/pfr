namespace EFT.NextObservedPlayer.Operations;

public class FoldHandsOperation : BaseHandsOperation
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public Input input; //Field offset: 0x10
		public FoldHandsOperation <>4__this; //Field offset: 0x18
		public SafeTaskCompleteSource completeTask; //Field offset: 0x20

		public <>c__DisplayClass2_0() { }

		internal void <Start>g__Complete|0() { }

	}

	internal struct Input
	{
		public bool inInventory; //Field offset: 0x0
		public bool value; //Field offset: 0x1
		public float weaponSize; //Field offset: 0x4

	}


	public FoldHandsOperation() { }

	public static FoldHandsOperation CreateInstance() { }

	public virtual void FastForward() { }

	public virtual IHandsOperationResult Start(Input input) { }

}

