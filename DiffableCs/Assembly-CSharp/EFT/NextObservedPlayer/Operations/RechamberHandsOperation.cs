namespace EFT.NextObservedPlayer.Operations;

public sealed class RechamberHandsOperation : BaseHandsOperation
{
	internal struct OperationCallbacks : IHandsOperationResult
	{
		[CompilerGenerated]
		private Task <ShellEject>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private Task <DellAmmo>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private Task <AddAmmo>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private Task <Complete>k__BackingField; //Field offset: 0x18

		public Task AddAmmo
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public override Task Complete
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public Task DellAmmo
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
		public Task get_AddAmmo() { }

		[CompilerGenerated]
		[IsReadOnly]
		public override Task get_Complete() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Task get_DellAmmo() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Task get_ShellEject() { }

		[CompilerGenerated]
		public void set_AddAmmo(Task value) { }

		[CompilerGenerated]
		public void set_Complete(Task value) { }

		[CompilerGenerated]
		public void set_DellAmmo(Task value) { }

		[CompilerGenerated]
		public void set_ShellEject(Task value) { }

	}

	private bool _hasShellToUnload; //Field offset: 0x20
	private bool _hasAmmoToUnload; //Field offset: 0x21
	private bool _hasAmmoToLoad; //Field offset: 0x22
	private bool _inMisfireMalfunction; //Field offset: 0x23
	private readonly SafeTaskCompleteSource _shellEject; //Field offset: 0x28
	private readonly SafeTaskCompleteSource _dellAmmo; //Field offset: 0x30
	private readonly SafeTaskCompleteSource _addAmmo; //Field offset: 0x38

	public RechamberHandsOperation() { }

	[CompilerGenerated]
	private void <Start>b__9_0() { }

	[CompilerGenerated]
	private void <Start>b__9_1() { }

	[CompilerGenerated]
	private void <Start>b__9_2() { }

	private void CompleteOperation() { }

	public static RechamberHandsOperation CreateInstance() { }

	public virtual void FastForward() { }

	public virtual OperationCallbacks Start(RechamberCommandMessage input) { }

}

