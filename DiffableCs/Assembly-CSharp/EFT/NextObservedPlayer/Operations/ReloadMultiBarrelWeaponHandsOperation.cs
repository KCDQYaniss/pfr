namespace EFT.NextObservedPlayer.Operations;

public class ReloadMultiBarrelWeaponHandsOperation : BaseHandsOperation
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public SafeTaskCompleteSource removeShells; //Field offset: 0x10
		public SafeTaskCompleteSource magAppeared; //Field offset: 0x18
		public ReloadMultiBarrelWeaponHandsOperation <>4__this; //Field offset: 0x20
		public SafeTaskCompleteSource addAmmoInMag; //Field offset: 0x28

		public <>c__DisplayClass4_0() { }

		internal void <Start>b__0() { }

		internal void <Start>b__1() { }

		internal void <Start>b__2() { }

	}

	internal struct OperationCallbacks : IHandsOperationResult
	{
		[CompilerGenerated]
		private Task <MagAppeared>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private Task <RemoveShells>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private Task <Complete>k__BackingField; //Field offset: 0x10

		public override Task Complete
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public Task MagAppeared
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public Task RemoveShells
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
		public Task get_MagAppeared() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Task get_RemoveShells() { }

		[CompilerGenerated]
		public void set_Complete(Task value) { }

		[CompilerGenerated]
		public void set_MagAppeared(Task value) { }

		[CompilerGenerated]
		public void set_RemoveShells(Task value) { }

	}

	private int _shellsCountToUnload; //Field offset: 0x20
	private int _ammoCountToLoad; //Field offset: 0x24

	public ReloadMultiBarrelWeaponHandsOperation() { }

	public static ReloadMultiBarrelWeaponHandsOperation CreateInstance() { }

	public virtual void FastForward() { }

	private void SetChamberIndexForLoadAmmo(Nullable[] ammoToLoad) { }

	private void SetShellsForUnloadShells(Nullable[] shellsToUnload) { }

	public virtual OperationCallbacks Start(ReloadMultiBarrelWeaponCommandMessage input) { }

}

