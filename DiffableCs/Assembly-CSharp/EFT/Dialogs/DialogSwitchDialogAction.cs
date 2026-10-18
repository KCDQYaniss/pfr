namespace EFT.Dialogs;

public sealed class DialogSwitchDialogAction : DialogNotifiedAction
{
	[CompilerGenerated]
	private MongoID <DialogId>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private Nullable <SplitterId>k__BackingField; //Field offset: 0x50

	[JsonProperty("dialogId")]
	public private MongoID DialogId
	{
		[CompilerGenerated]
		 get { } //Length: 21
		[CompilerGenerated]
		private set { } //Length: 98
	}

	public virtual bool Queued
	{
		 get { } //Length: 3
	}

	[JsonProperty("splitterNodeId")]
	public private Nullable SplitterId
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

	public DialogSwitchDialogAction() { }

	public DialogSwitchDialogAction(MongoID dialogId) { }

	[CompilerGenerated]
	public MongoID get_DialogId() { }

	public virtual bool get_Queued() { }

	[CompilerGenerated]
	public Nullable get_SplitterId() { }

	public virtual EActionType get_Type() { }

	[CompilerGenerated]
	private void set_DialogId(MongoID value) { }

	[CompilerGenerated]
	private void set_SplitterId(Nullable value) { }

	public virtual string ToString() { }

}

