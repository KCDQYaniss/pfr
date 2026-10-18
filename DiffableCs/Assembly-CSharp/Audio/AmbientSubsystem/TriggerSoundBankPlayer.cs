namespace Audio.AmbientSubsystem;

public class TriggerSoundBankPlayer : MonoBehaviour
{
	private struct PlayerPlayingData
	{
		public float NextPLayingTime; //Field offset: 0x0
		public Vector3 Position; //Field offset: 0x4

	}

	[SerializeField]
	private AudioTriggerArea _audioTriggerArea; //Field offset: 0x20
	[SerializeField]
	private SoundBank _soundBank; //Field offset: 0x28
	[SerializeField]
	private float _volume; //Field offset: 0x30
	[SerializeField]
	private int _rolloff; //Field offset: 0x34
	[SerializeField]
	private EnvironmentType _environmentType; //Field offset: 0x38
	[SerializeField]
	private AudioSourceGroupType _groupType; //Field offset: 0x3C
	[SerializeField]
	private AudioMixerGroup _mixerGroup; //Field offset: 0x40
	[SerializeField]
	private float _cooldown; //Field offset: 0x48
	private readonly Dictionary _playersData; //Field offset: 0x50
	private readonly List _currentPlayers; //Field offset: 0x58

	public TriggerSoundBankPlayer() { }

	private void Awake() { }

	private void OnDestroy() { }

	private void PlayerDeadOrUnspawnEventHandler(IPlayer player) { }

	private void PlaySound(IPlayer player) { }

	private void TriggerEventHandler(object sender, AudioTriggerAreaEventArgs audioTriggerAreaEventArgs) { }

	private void Update() { }

}

