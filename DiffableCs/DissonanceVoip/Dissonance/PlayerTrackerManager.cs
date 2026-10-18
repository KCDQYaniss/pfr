namespace Dissonance;

internal class PlayerTrackerManager
{
	private static readonly Log Log; //Field offset: 0x0
	private readonly Dictionary _unlinkedPlayerTrackers; //Field offset: 0x10
	private readonly PlayerCollection _players; //Field offset: 0x18

	private static PlayerTrackerManager() { }

	public PlayerTrackerManager(PlayerCollection players) { }

	public void AddPlayer(VoicePlayerState state) { }

	public void AddTracker(IDissonancePlayer player) { }

	public void RemovePlayer(VoicePlayerState state) { }

	public void RemoveTracker(IDissonancePlayer player) { }

}

