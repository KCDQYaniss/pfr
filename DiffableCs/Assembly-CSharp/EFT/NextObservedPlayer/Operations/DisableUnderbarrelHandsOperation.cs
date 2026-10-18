namespace EFT.NextObservedPlayer.Operations;

public class DisableUnderbarrelHandsOperation : BaseHandsOperation
{
	internal struct OperationCallbacks : IHandsOperationResult
	{
		[CompilerGenerated]
		private Task <Complete>k__BackingField; //Field offset: 0x0

		public override Task Complete
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 82
		}

		[CompilerGenerated]
		[IsReadOnly]
		public override Task get_Complete() { }

		[CompilerGenerated]
		public void set_Complete(Task value) { }

	}


	public virtual bool CanFastForward
	{
		 get { } //Length: 3
	}

	public DisableUnderbarrelHandsOperation() { }

	public static DisableUnderbarrelHandsOperation CreateInstance() { }

	public virtual void FastForward() { }

	public virtual bool get_CanFastForward() { }

	public virtual OperationCallbacks Start(HandsOperationEmptyInput input) { }

}

