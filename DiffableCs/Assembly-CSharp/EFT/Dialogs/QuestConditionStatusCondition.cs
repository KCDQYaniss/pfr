namespace EFT.Dialogs;

public sealed class QuestConditionStatusCondition : DialogCondition
{
	[CompilerGenerated]
	private string <QuestId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private MongoID <ConditionId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <IsDone>k__BackingField; //Field offset: 0x30

	[JsonProperty("ConditionId")]
	public private MongoID ConditionId
	{
		[CompilerGenerated]
		 get { } //Length: 21
		[CompilerGenerated]
		private set { } //Length: 98
	}

	[JsonProperty("Status")]
	public private bool IsDone
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty("QuestId")]
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

	public QuestConditionStatusCondition(string questId, MongoID conditionId, bool isDone) { }

	public QuestConditionStatusCondition() { }

	[CompilerGenerated]
	public MongoID get_ConditionId() { }

	[CompilerGenerated]
	public bool get_IsDone() { }

	[CompilerGenerated]
	public string get_QuestId() { }

	public virtual EDialogConditionType get_Type() { }

	[CompilerGenerated]
	private void set_ConditionId(MongoID value) { }

	[CompilerGenerated]
	private void set_IsDone(bool value) { }

	[CompilerGenerated]
	private void set_QuestId(string value) { }

	public virtual bool Test(IDialogContext context) { }

	public virtual string ToString() { }

}

