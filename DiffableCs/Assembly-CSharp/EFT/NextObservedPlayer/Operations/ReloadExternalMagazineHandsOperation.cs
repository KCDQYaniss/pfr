namespace EFT.NextObservedPlayer.Operations;

public class ReloadExternalMagazineHandsOperation : BaseHandsOperation
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public ReloadExternalMagazineHandsOperation <>4__this; //Field offset: 0x10
		public ReloadExternalMagazineCommandMessage input; //Field offset: 0x18

		public <>c__DisplayClass9_0() { }

		internal void <Start>b__0() { }

		internal void <Start>b__1() { }

		internal void <Start>b__2() { }

	}

	internal struct OperationCallbacks : IHandsOperationResult
	{
		[CompilerGenerated]
		private Task <Complete>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private Task <MagShow>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private Task <MagIn>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private Task <MagHide>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private Task <MagOut>k__BackingField; //Field offset: 0x20

		public override Task Complete
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public Task MagHide
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 5
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

		public Task MagOut
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
		public Task get_MagHide() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Task get_MagIn() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Task get_MagOut() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Task get_MagShow() { }

		[CompilerGenerated]
		public void set_Complete(Task value) { }

		[CompilerGenerated]
		public void set_MagHide(Task value) { }

		[CompilerGenerated]
		public void set_MagIn(Task value) { }

		[CompilerGenerated]
		public void set_MagOut(Task value) { }

		[CompilerGenerated]
		public void set_MagShow(Task value) { }

	}

	private SafeTaskCompleteSource _complete; //Field offset: 0x20
	private SafeTaskCompleteSource _magHide; //Field offset: 0x28
	private SafeTaskCompleteSource _magOut; //Field offset: 0x30
	private SafeTaskCompleteSource _magShow; //Field offset: 0x38
	private SafeTaskCompleteSource _magIn; //Field offset: 0x40
	private int _ammoInChamberResult; //Field offset: 0x48
	private bool _inMisfireMalfunction; //Field offset: 0x4C

	public ReloadExternalMagazineHandsOperation() { }

	private void CompleteOperation() { }

	public static ReloadExternalMagazineHandsOperation CreateInstance() { }

	public virtual void FastForward() { }

	public virtual OperationCallbacks Start(ReloadExternalMagazineCommandMessage input) { }

}

