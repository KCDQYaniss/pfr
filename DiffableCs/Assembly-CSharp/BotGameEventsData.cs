//Type is in global namespace

public class BotGameEventsData : BotData
{
	[CompilerGenerated]
	private readonly KhorovodBotGameEvent <KhorovodGameEvent>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly BotHalloweenWithZombiesGameEvent <HalloweenGameEvent>k__BackingField; //Field offset: 0x20

	public BotHalloweenWithZombiesGameEvent HalloweenGameEvent
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public KhorovodBotGameEvent KhorovodGameEvent
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public BotGameEventsData(BotOwner owner) { }

	[CompilerGenerated]
	public BotHalloweenWithZombiesGameEvent get_HalloweenGameEvent() { }

	[CompilerGenerated]
	public KhorovodBotGameEvent get_KhorovodGameEvent() { }

}

