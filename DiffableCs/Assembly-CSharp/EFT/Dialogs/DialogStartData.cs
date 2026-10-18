namespace EFT.Dialogs;

[IsReadOnly]
public struct DialogStartData
{
	[CompilerGenerated]
	private readonly MongoID <TraderId>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly EDialogEntryPoint <EntryPoint>k__BackingField; //Field offset: 0x18
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
		 get { } //Length: 4
	}

	public MongoID TraderId
	{
		[CompilerGenerated]
		 get { } //Length: 20
	}

	public DialogStartData(MongoID traderId, EDialogEntryPoint entryPoint, Nullable dialogId = null) { }

	[CompilerGenerated]
	public Nullable get_DialogId() { }

	[CompilerGenerated]
	public EDialogEntryPoint get_EntryPoint() { }

	[CompilerGenerated]
	public MongoID get_TraderId() { }

}

