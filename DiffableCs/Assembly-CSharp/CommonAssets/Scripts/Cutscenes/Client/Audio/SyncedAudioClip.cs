namespace CommonAssets.Scripts.Cutscenes.Client.Audio;

public class SyncedAudioClip : PlayableAsset, ITimelineClipAsset
{
	[Header("Audio Settings")]
	public AudioClip audioClip; //Field offset: 0x18
	public AudioMixerGroup mixerGroup; //Field offset: 0x20
	[Range(0, 1)]
	public float volume; //Field offset: 0x28
	public bool loop; //Field offset: 0x2C

	public override ClipCaps clipCaps
	{
		 get { } //Length: 3
	}

	public virtual double duration
	{
		 get { } //Length: 375
	}

	public SyncedAudioClip() { }

	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	public override ClipCaps get_clipCaps() { }

	public virtual double get_duration() { }

}

