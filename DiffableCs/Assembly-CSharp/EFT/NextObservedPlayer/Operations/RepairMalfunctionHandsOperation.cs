namespace EFT.NextObservedPlayer.Operations;

public class RepairMalfunctionHandsOperation : BaseHandsOperation
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public SafeTaskCompleteSource removeAmmoFromChamber; //Field offset: 0x10
		public SafeTaskCompleteSource addAmmoInChamber; //Field offset: 0x18
		public RepairMalfunctionCommandMessage input; //Field offset: 0x20
		public RepairMalfunctionHandsOperation <>4__this; //Field offset: 0x28
		public SafeTaskCompleteSource shellEject; //Field offset: 0x30
		public SafeTaskCompleteSource malfunctionOff; //Field offset: 0x38

		public <>c__DisplayClass2_0() { }

		internal void <Start>b__0() { }

		internal void <Start>b__1() { }

		internal void <Start>b__2() { }

		internal void <Start>b__3() { }

	}

	internal struct OperationCallbacks : IHandsOperationResult
	{
		[CompilerGenerated]
		private Task <Complete>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private Task <RemoveAmmoFromChamber>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private Task <AddAmmoInChamber>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private Task <MalfunctionOff>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private Task <ShellEject>k__BackingField; //Field offset: 0x20

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
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public Task MalfunctionOff
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public Task RemoveAmmoFromChamber
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
		public Task get_AddAmmoInChamber() { }

		[CompilerGenerated]
		[IsReadOnly]
		public override Task get_Complete() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Task get_MalfunctionOff() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Task get_RemoveAmmoFromChamber() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Task get_ShellEject() { }

		[CompilerGenerated]
		public void set_AddAmmoInChamber(Task value) { }

		[CompilerGenerated]
		public void set_Complete(Task value) { }

		[CompilerGenerated]
		public void set_MalfunctionOff(Task value) { }

		[CompilerGenerated]
		public void set_RemoveAmmoFromChamber(Task value) { }

		[CompilerGenerated]
		public void set_ShellEject(Task value) { }

	}


	public RepairMalfunctionHandsOperation() { }

	public static RepairMalfunctionHandsOperation CreateInstance() { }

	public virtual void FastForward() { }

	public virtual OperationCallbacks Start(RepairMalfunctionCommandMessage input) { }

}

