namespace Dissonance;

internal class PlaybackPool
{
	private readonly Pool _pool; //Field offset: 0x10
	[NotNull]
	private readonly IPriorityManager _priority; //Field offset: 0x18
	[NotNull]
	private readonly IVolumeProvider _volume; //Field offset: 0x20
	private GameObject _prefab; //Field offset: 0x28
	private Transform _parent; //Field offset: 0x30

	public PlaybackPool(IPriorityManager priority, IVolumeProvider volume) { }

	[NotNull]
	private VoicePlayback CreatePlayback() { }

	[NotNull]
	public VoicePlayback Get(string playerId) { }

	public void Put(VoicePlayback playback) { }

	public void Start(GameObject playbackPrefab, Transform transform) { }

}

