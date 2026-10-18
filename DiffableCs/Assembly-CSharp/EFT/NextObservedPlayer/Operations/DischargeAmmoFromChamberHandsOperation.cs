namespace EFT.NextObservedPlayer.Operations;

public class DischargeAmmoFromChamberHandsOperation : BaseHandsOperation
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public SafeTaskCompleteSource magHide; //Field offset: 0x10
		public DischargeAmmoFromChamberHandsOperation <>4__this; //Field offset: 0x18
		public DischargeAmmoFromChamberCommandMessage input; //Field offset: 0x20

		public <>c__DisplayClass2_0() { }

		internal void <Start>b__0() { }

	}

	internal struct OperationCallbacks : IHandsOperationResult
	{
		[CompilerGenerated]
		private Task <Complete>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private Task <MagHide>k__BackingField; //Field offset: 0x8

		public override Task Complete
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public Task MagHide
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
		public Task get_MagHide() { }

		[CompilerGenerated]
		public void set_Complete(Task value) { }

		[CompilerGenerated]
		public void set_MagHide(Task value) { }

	}


	public DischargeAmmoFromChamberHandsOperation() { }

	public static DischargeAmmoFromChamberHandsOperation CreateInstance() { }

	public virtual void FastForward() { }

	public virtual OperationCallbacks Start(DischargeAmmoFromChamberCommandMessage input) { }

}

