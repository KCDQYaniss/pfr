namespace EFT.Dialogs;

public sealed class QuestStatusCondition : DialogCondition
{
	[CompilerGenerated]
	private string <QuestId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private IReadOnlyList <Statuses>k__BackingField; //Field offset: 0x18

	[JsonProperty("QuestId")]
	public private string QuestId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonProperty("Status")]
	public private IReadOnlyList Statuses
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

	public QuestStatusCondition(string questId, IReadOnlyList statuses) { }

	public QuestStatusCondition() { }

	[CompilerGenerated]
	private bool <Test>b__12_0(QuestStatusData q) { }

	[CompilerGenerated]
	public string get_QuestId() { }

	[CompilerGenerated]
	public IReadOnlyList get_Statuses() { }

	public virtual EDialogConditionType get_Type() { }

	[CompilerGenerated]
	private void set_QuestId(string value) { }

	[CompilerGenerated]
	private void set_Statuses(IReadOnlyList value) { }

	public virtual bool Test(IDialogContext context) { }

	public virtual string ToString() { }

}

