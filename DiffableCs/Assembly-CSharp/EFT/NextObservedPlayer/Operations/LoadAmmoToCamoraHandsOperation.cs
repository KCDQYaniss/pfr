namespace EFT.NextObservedPlayer.Operations;

public class LoadAmmoToCamoraHandsOperation : BaseHandsOperation
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public SafeTaskCompleteSource addAmmoInChamber; //Field offset: 0x10
		public LoadAmmoToCamoraHandsOperation <>4__this; //Field offset: 0x18
		public SafeTaskCompleteSource addAmmoInMag; //Field offset: 0x20

		public <>c__DisplayClass3_0() { }

		internal void <Start>b__0() { }

		internal void <Start>b__1() { }

	}

	internal struct OperationCallbacks : IHandsOperationResult
	{
		[CompilerGenerated]
		private Task <Complete>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private Task <AddAmmoInChamber>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private Task <AddAmmoInMag>k__BackingField; //Field offset: 0x10

		public Task AddAmmoInChamber
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public Task AddAmmoInMag
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

		[CompilerGenerated]
		[IsReadOnly]
		public Task get_AddAmmoInChamber() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Task get_AddAmmoInMag() { }

		[CompilerGenerated]
		[IsReadOnly]
		public override Task get_Complete() { }

		[CompilerGenerated]
		public void set_AddAmmoInChamber(Task value) { }

		[CompilerGenerated]
		public void set_AddAmmoInMag(Task value) { }

		[CompilerGenerated]
		public void set_Complete(Task value) { }

	}

	private const int DEFAULT_CAMORA_WITH_SHELL_INDEX = -1; //Field offset: 0x0

	public LoadAmmoToCamoraHandsOperation() { }

	public static LoadAmmoToCamoraHandsOperation CreateInstance() { }

	public virtual void FastForward() { }

	public virtual OperationCallbacks Start(LoadAmmoToCamoraCommandMessage input) { }

}

