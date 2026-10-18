namespace Audio.SpatialSystem;

public class InteractiveObjectOccluder : IDisposable
{
	private readonly SpatialAudioSystem _audioSystem; //Field offset: 0x10
	private Action _unsubOnDispose; //Field offset: 0x18

	public InteractiveObjectOccluder(SpatialAudioSystem audioSystem) { }

	public bool CheckOcclusion(string targetID, BetterSource source, Vector3 position, EOcclusionTest test) { }

	public override void Dispose() { }

	private void OcclusionRequestEventHandler(AudioOcclusionRequestEvent requestEvent) { }

}

