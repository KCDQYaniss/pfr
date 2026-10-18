namespace Dissonance.Networking;

public static class TrafficCounters
{
	[CompilerGenerated]
	private static TrafficCounter <GameSentTraffic>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static TrafficCounter <GameReceivedTraffic>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private static TrafficCounter <VoipSentTraffic>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private static TrafficCounter <VoipReceivedTraffic>k__BackingField; //Field offset: 0x18

	public private static TrafficCounter GameReceivedTraffic
	{
		[CompilerGenerated]
		 get { } //Length: 60
		[CompilerGenerated]
		private set { } //Length: 151
	}

	public private static TrafficCounter GameSentTraffic
	{
		[CompilerGenerated]
		 get { } //Length: 59
		[CompilerGenerated]
		private set { } //Length: 151
	}

	public private static TrafficCounter VoipReceivedTraffic
	{
		[CompilerGenerated]
		 get { } //Length: 60
		[CompilerGenerated]
		private set { } //Length: 151
	}

	public private static TrafficCounter VoipSentTraffic
	{
		[CompilerGenerated]
		 get { } //Length: 60
		[CompilerGenerated]
		private set { } //Length: 151
	}

	[CompilerGenerated]
	public static TrafficCounter get_GameReceivedTraffic() { }

	[CompilerGenerated]
	public static TrafficCounter get_GameSentTraffic() { }

	[CompilerGenerated]
	public static TrafficCounter get_VoipReceivedTraffic() { }

	[CompilerGenerated]
	public static TrafficCounter get_VoipSentTraffic() { }

	public static void Reset() { }

	[CompilerGenerated]
	private static void set_GameReceivedTraffic(TrafficCounter value) { }

	[CompilerGenerated]
	private static void set_GameSentTraffic(TrafficCounter value) { }

	[CompilerGenerated]
	private static void set_VoipReceivedTraffic(TrafficCounter value) { }

	[CompilerGenerated]
	private static void set_VoipSentTraffic(TrafficCounter value) { }

}

