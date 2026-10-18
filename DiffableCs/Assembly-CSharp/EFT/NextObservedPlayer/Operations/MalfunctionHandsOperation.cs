namespace EFT.NextObservedPlayer.Operations;

public class MalfunctionHandsOperation : BaseHandsOperation
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public SafeTaskCompleteSource onShellEject; //Field offset: 0x10
		public MalfunctionHandsOperation <>4__this; //Field offset: 0x18
		public MalfunctionCommandMessage input; //Field offset: 0x20
		public SafeTaskCompleteSource removeAmmo; //Field offset: 0x28
		public SafeTaskCompleteSource onComplete; //Field offset: 0x30

		public <>c__DisplayClass2_0() { }

		internal void <Start>b__0() { }

		internal void <Start>b__1() { }

		internal void <Start>b__2() { }

	}

	internal struct OperationCallbacks : IHandsOperationResult
	{
		[CompilerGenerated]
		private Task <Complete>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private Task <ShellEject>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private Task <RemoveAmmo>k__BackingField; //Field offset: 0x10

		public override Task Complete
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public Task RemoveAmmo
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
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		[CompilerGenerated]
		[IsReadOnly]
		public override Task get_Complete() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Task get_RemoveAmmo() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Task get_ShellEject() { }

		[CompilerGenerated]
		public void set_Complete(Task value) { }

		[CompilerGenerated]
		public void set_RemoveAmmo(Task value) { }

		[CompilerGenerated]
		public void set_ShellEject(Task value) { }

	}


	public MalfunctionHandsOperation() { }

	public static MalfunctionHandsOperation CreateInstance() { }

	public virtual void FastForward() { }

	public virtual OperationCallbacks Start(MalfunctionCommandMessage input) { }

}

