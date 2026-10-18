namespace EFT.Dialogs;

public abstract class DialogQuestAction : DialogNotifiedAction
{
	[CompilerGenerated]
	private string <QuestId>k__BackingField; //Field offset: 0x38

	[JsonProperty("questId")]
	public string QuestId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public virtual bool Queued
	{
		 get { } //Length: 3
	}

	protected DialogQuestAction() { }

	[CompilerGenerated]
	public string get_QuestId() { }

	public virtual bool get_Queued() { }

	[CompilerGenerated]
	protected void set_QuestId(string value) { }

}

