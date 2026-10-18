namespace EFT.Dialogs;

public sealed class DialogDiaryNoteAction : DialogQuestAction
{
	[CompilerGenerated]
	private string <NoteId>k__BackingField; //Field offset: 0x40

	[JsonProperty("value")]
	public private string NoteId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public virtual EActionType Type
	{
		 get { } //Length: 3
	}

	public DialogDiaryNoteAction() { }

	[CompilerGenerated]
	public string get_NoteId() { }

	public virtual EActionType get_Type() { }

	[CompilerGenerated]
	private void set_NoteId(string value) { }

}

