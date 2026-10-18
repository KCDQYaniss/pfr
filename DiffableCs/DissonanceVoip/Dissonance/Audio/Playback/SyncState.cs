namespace Dissonance.Audio.Playback;

public struct SyncState
{
	public readonly TimeSpan ActualPlaybackPosition; //Field offset: 0x0
	public readonly TimeSpan IdealPlaybackPosition; //Field offset: 0x8
	public readonly TimeSpan Desync; //Field offset: 0x10
	public readonly float CompensatedPlaybackSpeed; //Field offset: 0x18
	public readonly bool Enabled; //Field offset: 0x1C

	public SyncState(TimeSpan actualPlaybackPosition, TimeSpan idealPlaybackPosition, TimeSpan desync, float compensatedPlaybackSpeed, bool enabled) { }

}

