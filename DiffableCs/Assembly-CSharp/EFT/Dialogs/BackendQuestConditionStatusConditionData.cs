namespace EFT.Dialogs;

public sealed class BackendQuestConditionStatusConditionData : BackendDialogNodeConditionData
{
	[CompilerGenerated]
	private string <QuestId>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private MongoID <ConditionId>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private bool <IsDone>k__BackingField; //Field offset: 0x48

	[JsonProperty("conditionId")]
	public private MongoID ConditionId
	{
		[CompilerGenerated]
		 get { } //Length: 21
		[CompilerGenerated]
		private set { } //Length: 98
	}

	[JsonProperty("status")]
	public private bool IsDone
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

	public virtual EConditionType Type
	{
		 get { } //Length: 6
	}

	public BackendQuestConditionStatusConditionData() { }

	[CompilerGenerated]
	public MongoID get_ConditionId() { }

	[CompilerGenerated]
	public bool get_IsDone() { }

	[CompilerGenerated]
	public string get_QuestId() { }

	public virtual EConditionType get_Type() { }

	[CompilerGenerated]
	private void set_ConditionId(MongoID value) { }

	[CompilerGenerated]
	private void set_IsDone(bool value) { }

	[CompilerGenerated]
	private void set_QuestId(string value) { }

	public virtual DialogCondition ToDialogCondition() { }

}

