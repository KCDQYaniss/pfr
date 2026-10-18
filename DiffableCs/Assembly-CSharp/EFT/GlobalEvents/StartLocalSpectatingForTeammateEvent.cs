namespace EFT.GlobalEvents;

public class StartLocalSpectatingForTeammateEvent : BaseEvent
{
	[CompilerGenerated]
	private int <PlayerRaidID>k__BackingField; //Field offset: 0x18

	public int PlayerRaidID
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public StartLocalSpectatingForTeammateEvent() { }

	[CompilerGenerated]
	public int get_PlayerRaidID() { }

	public void Invoke(int playerRaidId) { }

	public virtual void Reset() { }

	[CompilerGenerated]
	public void set_PlayerRaidID(int value) { }

}

