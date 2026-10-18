namespace EFT.Dialogs;

public sealed class HasFreeSpecialSlotCondition : DialogCondition
{
	[CompilerGenerated]
	private bool <HasFreeSlot>k__BackingField; //Field offset: 0x10

	[JsonProperty("hasFreeSlot")]
	public private bool HasFreeSlot
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public virtual EDialogConditionType Type
	{
		 get { } //Length: 6
	}

	public HasFreeSpecialSlotCondition() { }

	public HasFreeSpecialSlotCondition(bool hasFreeSlot) { }

	[CompilerGenerated]
	public bool get_HasFreeSlot() { }

	public virtual EDialogConditionType get_Type() { }

	[CompilerGenerated]
	private void set_HasFreeSlot(bool value) { }

	public virtual bool Test(IDialogContext context) { }

}

