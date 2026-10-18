namespace Audio.AmbientSubsystem;

public class SeasonLoopAmbientSoundPlayer : BaseLoopAmbientSoundPlayer, ISeasonDependent, IAudioClipChangeable
{
	internal class SeasonSoundClips : SerializableEnumDictionary
	{

		public SeasonSoundClips() { }

	}

	[HideInInspector]
	[SerializeField]
	private SeasonSoundClips _seasonSoundClips; //Field offset: 0xF0
	private AudioClip _currentClip; //Field offset: 0xF8
	private bool _seasonInitialized; //Field offset: 0x100

	public SeasonLoopAmbientSoundPlayer() { }

	protected virtual bool CanPlay() { }

	public override void ChangeAudioClip(AudioClip newClip) { }

	protected virtual AudioClip GetClip() { }

	public override void SetSeasonStatus(ESeasonStatus targetSeasonStatus) { }

}

