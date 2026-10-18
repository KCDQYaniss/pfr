namespace Dissonance.Audio.Playback;

internal class PriorityManager : IPriorityManager
{
	private static readonly Log Log; //Field offset: 0x0
	private readonly PlayerCollection _players; //Field offset: 0x10
	[CompilerGenerated]
	private ChannelPriority <TopPriority>k__BackingField; //Field offset: 0x18

	public private override ChannelPriority TopPriority
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private static PriorityManager() { }

	public PriorityManager(PlayerCollection players) { }

	[CompilerGenerated]
	public override ChannelPriority get_TopPriority() { }

	[CompilerGenerated]
	private void set_TopPriority(ChannelPriority value) { }

	public void Update() { }

}

