namespace EFT.NextObservedPlayer;

public class DryShotFireHandsOperation : BaseHandsOperation
{
	internal struct OperationCallbacks : IHandsOperationResult
	{
		[CompilerGenerated]
		private Task <Complete>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private Task <Sound>k__BackingField; //Field offset: 0x8

		public override Task Complete
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public Task Sound
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
		public Task get_Sound() { }

		[CompilerGenerated]
		public void set_Complete(Task value) { }

		[CompilerGenerated]
		public void set_Sound(Task value) { }

	}

	private SafeTaskCompleteSource _sound; //Field offset: 0x20

	public DryShotFireHandsOperation() { }

	[CompilerGenerated]
	private void <Start>b__3_0() { }

	public static DryShotFireHandsOperation CreateInstance() { }

	public virtual void FastForward() { }

	public virtual OperationCallbacks Start(DryShotFirearmCommandMessage input) { }

}

