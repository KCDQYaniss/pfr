namespace Audio.AmbientSubsystem;

public class CustomShakeFromAudioPlayerEventsProvider : MonoBehaviour
{
	private class AudioPlayerShakeHandler
	{
		private readonly AudioShakeSettings _audioShakeSettings; //Field offset: 0x10
		private readonly BaseAmbientSoundPlayer _audioPlayer; //Field offset: 0x18

		public AudioPlayerShakeHandler(AudioShakeSettings settings) { }

		private void SoundPlayHandler() { }

		public void Subscribe() { }

		public void Unsubscribe() { }

	}

	private class AudioShakeSettings
	{
		public BaseAmbientSoundPlayer audioPlayer; //Field offset: 0x10
		public float maxReactionDistance; //Field offset: 0x18
		public float exponentValue; //Field offset: 0x1C
		public CustomExplosionShakeSettings explosionShakeSettings; //Field offset: 0x20

		public AudioShakeSettings() { }

	}

	[SerializeField]
	private AudioShakeSettings[] _playSettings; //Field offset: 0x20
	private readonly List _handlers; //Field offset: 0x28

	public CustomShakeFromAudioPlayerEventsProvider() { }

	private void Awake() { }

	private void OnDestroy() { }

}

