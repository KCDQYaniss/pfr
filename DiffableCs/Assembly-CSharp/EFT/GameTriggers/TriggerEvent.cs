namespace EFT.GameTriggers;

[Obfuscation(Exclude = True)]
public class TriggerEvent : BaseEvent
{
	[CompilerGenerated]
	private int <TriggerId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <OriginPlayerRaidId>k__BackingField; //Field offset: 0x1C

	public int OriginPlayerRaidId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int TriggerId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public TriggerEvent() { }

	[CompilerGenerated]
	public int get_OriginPlayerRaidId() { }

	[CompilerGenerated]
	public int get_TriggerId() { }

	public virtual void Reset() { }

	[CompilerGenerated]
	public void set_OriginPlayerRaidId(int value) { }

	[CompilerGenerated]
	public void set_TriggerId(int value) { }

}

