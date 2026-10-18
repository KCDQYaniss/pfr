namespace Audio.Vehicles;

public class SoundSuspensionImpactSoundPlayer : MonoBehaviour
{
	private const float MIN_IMPACT_VOLUME_THRESHOLD = 0.5; //Field offset: 0x0
	[SerializeField]
	private VehicleSuspensionSpring _suspensionSpring; //Field offset: 0x20
	[SerializeField]
	private int _rolloff; //Field offset: 0x28
	private ISoundSuspensionController _suspensionController; //Field offset: 0x30
	private bool _initialized; //Field offset: 0x38
	private float _prevPlayingTime; //Field offset: 0x3C
	private int _sqrRolloff; //Field offset: 0x40

	private int SqrRolloff
	{
		private get { } //Length: 4
		private set { } //Length: 4
	}

	public SoundSuspensionImpactSoundPlayer() { }

	private int get_SqrRolloff() { }

	public void Init(ISoundSuspensionController suspensionController) { }

	private void PlayImpactSound(float volume, float pitch, AudioMixerGroup mixerGroup) { }

	private void set_SqrRolloff(int value) { }

	public void TryPlayImpactSound(AudioMixerGroup mixerGroup) { }

}

