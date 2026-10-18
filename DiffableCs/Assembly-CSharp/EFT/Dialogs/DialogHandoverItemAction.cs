namespace EFT.Dialogs;

public sealed class DialogHandoverItemAction : DialogQuestConditionAction
{
	[CompilerGenerated]
	private bool <PartialHandover>k__BackingField; //Field offset: 0x60

	[JsonProperty("partialHandover")]
	public private bool PartialHandover
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public virtual EActionType Type
	{
		 get { } //Length: 6
	}

	public DialogHandoverItemAction() { }

	public DialogHandoverItemAction(string questId, Nullable conditionId, bool partialHandover) { }

	[CompilerGenerated]
	public bool get_PartialHandover() { }

	public virtual EActionType get_Type() { }

	[CompilerGenerated]
	private void set_PartialHandover(bool value) { }

	public virtual string ToString() { }

}

