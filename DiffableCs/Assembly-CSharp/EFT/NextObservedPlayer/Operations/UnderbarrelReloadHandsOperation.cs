namespace EFT.NextObservedPlayer.Operations;

public class UnderbarrelReloadHandsOperation : BaseHandsOperation
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public SafeTaskCompleteSource magShow; //Field offset: 0x10
		public UnderbarrelReloadHandsOperation <>4__this; //Field offset: 0x18
		public SafeTaskCompleteSource addAmmoInChamber; //Field offset: 0x20

		public <>c__DisplayClass5_0() { }

		internal void <Start>b__0() { }

		internal void <Start>b__1() { }

	}

	internal struct OperationCallbacks : IHandsOperationResult
	{
		[CompilerGenerated]
		private Task <ShellEject>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private Task <MagShow>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private Task <AddAmmoInChamber>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private Task <Complete>k__BackingField; //Field offset: 0x18

		public Task AddAmmoInChamber
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

		public Task MagShow
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
		public Task get_AddAmmoInChamber() { }

		[CompilerGenerated]
		[IsReadOnly]
		public override Task get_Complete() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Task get_MagShow() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Task get_ShellEject() { }

		[CompilerGenerated]
		public void set_AddAmmoInChamber(Task value) { }

		[CompilerGenerated]
		public void set_Complete(Task value) { }

		[CompilerGenerated]
		public void set_MagShow(Task value) { }

		[CompilerGenerated]
		public void set_ShellEject(Task value) { }

	}

	private bool _hasShellInWeapon; //Field offset: 0x20

	public virtual bool CanFastForward
	{
		 get { } //Length: 3
	}

	public UnderbarrelReloadHandsOperation() { }

	public static UnderbarrelReloadHandsOperation CreateInstance() { }

	public virtual void FastForward() { }

	public virtual bool get_CanFastForward() { }

	public virtual OperationCallbacks Start(UnderbarrelReloadCommandMessage input) { }

}

