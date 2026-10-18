namespace EFT.NextObservedPlayer.Operations;

public class DischargeAmmoFromCamoraHandsOperation : BaseHandsOperation
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public DischargeAmmoFromCamoraHandsOperation <>4__this; //Field offset: 0x10
		public SafeTaskCompleteSource magShow; //Field offset: 0x18

		public <>c__DisplayClass2_0() { }

		internal void <Start>b__0() { }

	}

	internal struct OperationCallbacks : IHandsOperationResult
	{
		[CompilerGenerated]
		private Task <Complete>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private Task <MagShow>k__BackingField; //Field offset: 0x8

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

		[CompilerGenerated]
		[IsReadOnly]
		public override Task get_Complete() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Task get_MagShow() { }

		[CompilerGenerated]
		public void set_Complete(Task value) { }

		[CompilerGenerated]
		public void set_MagShow(Task value) { }

	}


	public DischargeAmmoFromCamoraHandsOperation() { }

	public static DischargeAmmoFromCamoraHandsOperation CreateInstance() { }

	public virtual void FastForward() { }

	public virtual OperationCallbacks Start(DischargeAmmoFromCamoraCommandMessage input) { }

}

