namespace EFT.NextObservedPlayer.Operations;

public class HighThrowHandsOperation : BaseHandsOperation
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public ValueTuple cookAndDropActions; //Field offset: 0x10
		public HighThrowHandsOperation <>4__this; //Field offset: 0x20

		public <>c__DisplayClass4_0() { }

		internal void <Start>b__0() { }

	}

	internal struct OperationCallbacks : IHandsOperationResult
	{
		[CompilerGenerated]
		private Task <Complete>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private Task <Drop>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private Task <Cook>k__BackingField; //Field offset: 0x10

		public override Task Complete
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public Task Cook
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public Task Drop
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
		public Task get_Cook() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Task get_Drop() { }

		[CompilerGenerated]
		public void set_Complete(Task value) { }

		[CompilerGenerated]
		public void set_Cook(Task value) { }

		[CompilerGenerated]
		public void set_Drop(Task value) { }

	}


	public virtual bool CanFastForward
	{
		 get { } //Length: 3
	}

	public HighThrowHandsOperation() { }

	public static HighThrowHandsOperation CreateInstance() { }

	public virtual void FastForward() { }

	public virtual bool get_CanFastForward() { }

	protected override void SetGrenadeFireIdle() { }

	protected override void SetGrenadeFireThrow() { }

	public virtual OperationCallbacks Start(ValueTuple cookAndDropActions) { }

}

