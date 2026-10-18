//Type is in global namespace

[RequireComponent(typeof(AudioSource))]
public class MetaXRAudioSource : MonoBehaviour
{
	internal enum NativeParameterIndex
	{
		P_GAIN = 0,
		P_USEINVSQR = 1,
		P_NEAR = 2,
		P_FAR = 3,
		P_RADIUS = 4,
		P_DISABLE_RFL = 5,
		P_AMBISTAT = 6,
		P_READONLY_GLOBAL_RFL_ENABLED = 7,
		P_READONLY_NUM_VOICES = 8,
		P_HRTF_INTENSITY = 9,
		P_REFLECTIONS_SEND = 10,
		P_REVERB_SEND = 11,
		P_DIRECTIVITY_ENABLED = 12,
		P_DIRECTIVITY_INTENSITY = 13,
		P_AMBI_DIRECT_ENABLED = 14,
		P_REVERB_REACH = 15,
		P_DIRECT_ENABLED = 16,
		P_OCCLUSION_INTENSITY = 17,
		P_NUM = 18,
	}

	private AudioSource source_; //Field offset: 0x20
	private bool wasPlaying_; //Field offset: 0x28
	private bool _initialized; //Field offset: 0x29
	[SerializeField]
	[Tooltip("Enables HRTF Spatialization.")]
	private bool enableSpatialization; //Field offset: 0x2A
	[Range(0, 20)]
	[SerializeField]
	[Tooltip("Additional gain beyond 0dB")]
	private float gainBoostDb; //Field offset: 0x2C
	[SerializeField]
	[Tooltip("Enables room acoustics simulation (early reflections and reverberation) for this audio source only")]
	private bool enableAcoustics; //Field offset: 0x30
	[Range(-60, 20)]
	[SerializeField]
	[Tooltip("Additional gain applied to reverb send for this audio source only")]
	private float reverbSendDb; //Field offset: 0x34

	public bool EnableAcoustics
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool EnableSpatialization
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public float GainBoostDb
	{
		 get { } //Length: 6
		 set { } //Length: 33
	}

	public float ReverbSendDb
	{
		 get { } //Length: 6
		 set { } //Length: 38
	}

	public MetaXRAudioSource() { }

	private void Awake() { }

	public bool get_EnableAcoustics() { }

	public bool get_EnableSpatialization() { }

	public float get_GainBoostDb() { }

	public float get_ReverbSendDb() { }

	public void Init() { }

	public void ManualUpdate() { }

	private static int MetaXRAudio_SetGlobalVoiceLimit(int VoiceLimit) { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	private static void OnBeforeSceneLoadRuntimeMethod() { }

	public void set_EnableAcoustics(bool value) { }

	public void set_EnableSpatialization(bool value) { }

	public void set_GainBoostDb(float value) { }

	public void set_ReverbSendDb(float value) { }

	public void UpdateParameters() { }

}

