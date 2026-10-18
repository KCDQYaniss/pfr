namespace CommonAssets.Scripts.Cutscenes.Client.Audio;

public class SyncedAudioTrackMixer : PlayableBehaviour
{
	public AudioSource audioSource; //Field offset: 0x10
	public string trackName; //Field offset: 0x18
	private bool _isInitialized; //Field offset: 0x20

	public SyncedAudioTrackMixer() { }

	public virtual void OnPlayableDestroy(Playable playable) { }

	public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) { }

}

