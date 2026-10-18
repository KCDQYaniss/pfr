namespace EFT.NextObservedPlayer.Operations;

public class LoadAmmoToChamberHandsOperation : BaseHandsOperation
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public SafeTaskCompleteSource magShow; //Field offset: 0x10
		public SafeTaskCompleteSource removeShells; //Field offset: 0x18
		public LoadAmmoToChamberHandsOperation <>4__this; //Field offset: 0x20
		public SafeTaskCompleteSource addAmmoInChamber; //Field offset: 0x28

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
		private Task <MagShow>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private Task <RemoveShells>k__BackingField; //Field offset: 0x10
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
		public Task get_AddAmmoToChamber() { }

		[CompilerGenerated]
		[IsReadOnly]
		public override Task get_Complete() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Task get_MagShow() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Task get_RemoveShells() { }

		[CompilerGenerated]
		public void set_AddAmmoToChamber(Task value) { }

		[CompilerGenerated]
		public void set_Complete(Task value) { }

		[CompilerGenerated]
		public void set_MagShow(Task value) { }

		[CompilerGenerated]
		public void set_RemoveShells(Task value) { }

	}


	public LoadAmmoToChamberHandsOperation() { }

	public static LoadAmmoToChamberHandsOperation CreateInstance() { }

	public virtual void FastForward() { }

	public virtual OperationCallbacks Start(LoadAmmoToChamberCommandMessage input) { }

}

