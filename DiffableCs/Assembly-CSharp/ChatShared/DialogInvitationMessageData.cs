namespace ChatShared;

[IsReadOnly]
public struct DialogInvitationMessageData
{
	[CompilerGenerated]
	private readonly string <TraderId>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly string <MessageLocaleKey>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private readonly EDialogEntryPoint <EntryPoint>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <QuestId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly Nullable <DialogId>k__BackingField; //Field offset: 0x20

	public Nullable DialogId
	{
		[CompilerGenerated]
		 get { } //Length: 19
	}

	public EDialogEntryPoint EntryPoint
	{
		[CompilerGenerated]
		 get { } //Length: 164
	}

	public string MessageLocaleKey
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string QuestId
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string TraderId
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public DialogInvitationMessageData(string traderId, string messageLocaleKey, string questId, EDialogEntryPoint entryPoint, Nullable dialogId) { }

	[CompilerGenerated]
	public Nullable get_DialogId() { }

	[CompilerGenerated]
	public EDialogEntryPoint get_EntryPoint() { }

	[CompilerGenerated]
	public string get_MessageLocaleKey() { }

	[CompilerGenerated]
	public string get_QuestId() { }

	[CompilerGenerated]
	public string get_TraderId() { }

}

