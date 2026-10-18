namespace EFT.Dialogs;

public sealed class DialogEmbedQuestDialogAction : DialogQuestAction
{
	[CompilerGenerated]
	private Nullable <TargetDialogId>k__BackingField; //Field offset: 0x40

	public virtual bool Queued
	{
		 get { } //Length: 3
	}

	public private Nullable TargetDialogId
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public virtual EActionType Type
	{
		 get { } //Length: 6
	}

	public DialogEmbedQuestDialogAction() { }

	public DialogEmbedQuestDialogAction(MongoID targetDialogId) { }

	public virtual bool get_Queued() { }

	[CompilerGenerated]
	public Nullable get_TargetDialogId() { }

	public virtual EActionType get_Type() { }

	[CompilerGenerated]
	private void set_TargetDialogId(Nullable value) { }

	public virtual string ToString() { }

}

