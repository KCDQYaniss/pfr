namespace EFT.NextObservedPlayer.Operations;

public class BoltActionReloadAfterFireHandsOperation : BaseHandsOperation
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public SafeTaskCompleteSource shellEject; //Field offset: 0x10
		public BoltActionReloadAfterFireHandsOperation <>4__this; //Field offset: 0x18
		public SafeTaskCompleteSource complete; //Field offset: 0x20

		public <>c__DisplayClass2_0() { }

		internal void <Start>b__0() { }

		internal void <Start>b__1() { }

	}

	internal struct OperationCallbacks : IHandsOperationResult
	{
		[CompilerGenerated]
		private Task <ShellEject>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private Task <Complete>k__BackingField; //Field offset: 0x8

		public override Task Complete
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public Task ShellEject
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
		[IsReadOnly]
		public Task get_ShellEject() { }

		[CompilerGenerated]
		public void set_Complete(Task value) { }

		[CompilerGenerated]
		public void set_ShellEject(Task value) { }

	}


	public BoltActionReloadAfterFireHandsOperation() { }

	public static BoltActionReloadAfterFireHandsOperation CreateInstance() { }

	public virtual void FastForward() { }

	public virtual OperationCallbacks Start(BoltActionReloadAfterFireCommandMessage input) { }

}

