namespace NPC;

public class NPCCrossfadeAnimationSoundPlayer : NPCSoundPlayerBase
{
	[SerializeField]
	private AudioClipConfigDictionary _audioConfigDictionary; //Field offset: 0x30
	[SerializeField]
	private AudioMixerGroup _mixerGroup; //Field offset: 0x38
	private CrossfadeUnityAudioPlayer _audioPlayer; //Field offset: 0x40

	public NPCCrossfadeAnimationSoundPlayer() { }

	protected virtual void Clear() { }

	protected virtual void OnAwake() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	protected virtual void OnNeedToPlaySomeSound(string soundID) { }

	private void SequencePlayerStateChanged(bool isPlaying) { }

}

