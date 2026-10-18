namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public abstract class SyncEventFromClient : SyncEvent, ISyncFromClientEvent, ISyncEvent, IEvent
{
	[CompilerGenerated]
	private int <OriginPlayerRaidId>k__BackingField; //Field offset: 0x18

	public override int OriginPlayerRaidId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	protected SyncEventFromClient() { }

	[CompilerGenerated]
	public override int get_OriginPlayerRaidId() { }

	[CompilerGenerated]
	public override void set_OriginPlayerRaidId(int value) { }

}

