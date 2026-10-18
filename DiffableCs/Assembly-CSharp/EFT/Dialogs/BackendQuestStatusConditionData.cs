namespace EFT.Dialogs;

public sealed class BackendQuestStatusConditionData : BackendDialogNodeConditionData
{
	[CompilerGenerated]
	private string <QuestId>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private IReadOnlyList <Status>k__BackingField; //Field offset: 0x30

	[JsonProperty("questId")]
	public private string QuestId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonProperty("status")]
	public private IReadOnlyList Status
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public virtual EConditionType Type
	{
		 get { } //Length: 6
	}

	public BackendQuestStatusConditionData() { }

	[CompilerGenerated]
	public string get_QuestId() { }

	[CompilerGenerated]
	public IReadOnlyList get_Status() { }

	public virtual EConditionType get_Type() { }

	[CompilerGenerated]
	private void set_QuestId(string value) { }

	[CompilerGenerated]
	private void set_Status(IReadOnlyList value) { }

	public virtual DialogCondition ToDialogCondition() { }

}

