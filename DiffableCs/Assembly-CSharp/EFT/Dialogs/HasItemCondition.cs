namespace EFT.Dialogs;

public sealed class HasItemCondition : DialogCondition
{
	[CompilerGenerated]
	private string <QuestId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Nullable <ConditionId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <PartialHandover>k__BackingField; //Field offset: 0x38

	[JsonProperty("conditionId")]
	public private Nullable ConditionId
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonProperty("partial")]
	public private bool PartialHandover
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty("questId")]
	public private string QuestId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public virtual EDialogConditionType Type
	{
		 get { } //Length: 6
	}

	public HasItemCondition() { }

	public HasItemCondition(string questId, Nullable conditionId, bool partialHandover) { }

	[CompilerGenerated]
	public Nullable get_ConditionId() { }

	[CompilerGenerated]
	public bool get_PartialHandover() { }

	[CompilerGenerated]
	public string get_QuestId() { }

	public virtual EDialogConditionType get_Type() { }

	[CompilerGenerated]
	private void set_ConditionId(Nullable value) { }

	[CompilerGenerated]
	private void set_PartialHandover(bool value) { }

	[CompilerGenerated]
	private void set_QuestId(string value) { }

	public virtual bool Test(IDialogContext context) { }

}

