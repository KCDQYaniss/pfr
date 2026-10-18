namespace EFT.NextObservedPlayer.Operations;

public class InsertMagazineHandsOperation : BaseHandsOperation
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public InsertMagazineHandsOperation <>4__this; //Field offset: 0x10
		public InsertMagazineCommandMessage input; //Field offset: 0x18

		public <>c__DisplayClass7_0() { }

		internal void <Start>b__0() { }

		internal void <Start>b__1() { }

	}

	internal struct OperationCallbacks : IHandsOperationResult
	{
		[CompilerGenerated]
		private Task <Complete>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private Task <MagShow>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private Task <MagIn>k__BackingField; //Field offset: 0x10

		public override Task Complete
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public Task MagIn
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public Task MagShow
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		[CompilerGenerated]
		[IsReadOnly]
		public override Task get_Complete() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Task get_MagIn() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Task get_MagShow() { }

		[CompilerGenerated]
		public void set_Complete(Task value) { }

		[CompilerGenerated]
		public void set_MagIn(Task value) { }

		[CompilerGenerated]
		public void set_MagShow(Task value) { }

	}

	private SafeTaskCompleteSource _complete; //Field offset: 0x20
	private SafeTaskCompleteSource _magShow; //Field offset: 0x28
	private SafeTaskCompleteSource _magIn; //Field offset: 0x30
	private int _ammoInChamberResult; //Field offset: 0x38
	private bool _inMisfireMalfunction; //Field offset: 0x3C

	public InsertMagazineHandsOperation() { }

	private void CompleteOperation() { }

	public static InsertMagazineHandsOperation CreateInstance() { }

	public virtual void FastForward() { }

	public virtual OperationCallbacks Start(InsertMagazineCommandMessage input) { }

}

