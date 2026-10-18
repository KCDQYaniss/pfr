namespace EFT.NextObservedPlayer.Operations;

public sealed class LoadAmmoToUnderbarrelHandsOperation : BaseHandsOperation
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public SafeTaskCompleteSource magShow; //Field offset: 0x10
		public LoadAmmoToUnderbarrelHandsOperation <>4__this; //Field offset: 0x18
		public SafeTaskCompleteSource addAmmoInChamber; //Field offset: 0x20

		public <>c__DisplayClass3_0() { }

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
		private Task <ShellEject>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private Task <AddAmmoToChamber>k__BackingField; //Field offset: 0x18

		public Task AddAmmoToChamber
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
			 get { } //Length: 4
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
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		[CompilerGenerated]
		[IsReadOnly]
		public Task get_AddAmmoToChamber() { }

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
		public void set_AddAmmoToChamber(Task value) { }

		[CompilerGenerated]
		public void set_Complete(Task value) { }

		[CompilerGenerated]
		public void set_MagShow(Task value) { }

		[CompilerGenerated]
		public void set_ShellEject(Task value) { }

	}

	private bool _hasShellInWeapon; //Field offset: 0x20

	public LoadAmmoToUnderbarrelHandsOperation() { }

	public static LoadAmmoToUnderbarrelHandsOperation CreateInstance() { }

	public virtual void FastForward() { }

	public virtual OperationCallbacks Start(LoadAmmoToUnderbarrelWeaponCommandMessage input) { }

}

