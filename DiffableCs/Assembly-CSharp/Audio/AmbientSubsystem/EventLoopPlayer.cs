namespace Audio.AmbientSubsystem;

public class EventLoopPlayer : BaseLoopAmbientSoundPlayer, IEventSoundContentChanger
{
	[HideInInspector]
	[SerializeField]
	private EventAudioClips _soundClips; //Field offset: 0xF0
	private AudioClip _currentClip; //Field offset: 0xF8
	private bool _eventInitialized; //Field offset: 0x100

	public EventLoopPlayer() { }

	protected virtual bool CanPlay() { }

	public override void ChangeSoundContent(EEventType eventType) { }

	protected virtual AudioClip GetClip() { }

}

