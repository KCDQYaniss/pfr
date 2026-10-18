namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public class LocalSpectatorTargetChangedEvent : BaseEvent
{
	[CompilerGenerated]
	private int <TargetRaidId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <TargetPlayerId>k__BackingField; //Field offset: 0x1C

	public private int TargetPlayerId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int TargetRaidId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public LocalSpectatorTargetChangedEvent() { }

	[CompilerGenerated]
	public int get_TargetPlayerId() { }

	[CompilerGenerated]
	public int get_TargetRaidId() { }

	public void Invoke(int targetRaidId, int targetPlayerId) { }

	public virtual void Reset() { }

	[CompilerGenerated]
	private void set_TargetPlayerId(int value) { }

	[CompilerGenerated]
	private void set_TargetRaidId(int value) { }

}

