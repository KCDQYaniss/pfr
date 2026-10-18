//Type is in global namespace

[RequireComponent(typeof(MetaXRAudioSource))]
public class MetaXRAudioSourceExperimentalFeatures : MonoBehaviour
{
	internal enum DirectivityPatternType
	{
		None = 0,
		HumanVoice = 1,
	}

	private AudioSource source_; //Field offset: 0x20
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("How much of the HRTF EQ is applied to the sound. Interaural time delay (ITD) and interaural level differences (ILD) are kept the same.")]
	private float hrtfIntensity; //Field offset: 0x28
	[SerializeField]
	[Tooltip("Used to increase the spatial audio emitter radius. Useful for sounds that come from a large area rather than a precise point. If increased too large, users may end up inside the radius if the sound source is too close.")]
	private float volumetricRadius; //Field offset: 0x2C
	[Range(-60, 20)]
	[SerializeField]
	[Tooltip("Additional gain applied to early reflections for this audio source only")]
	private float earlyReflectionsSendDb; //Field offset: 0x30
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("Adjust how much the direct-to-reverberant ratio increases with distance")]
	private float reverbReach; //Field offset: 0x34
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("Adjust how much the direct-to-reverberant ratio increases with distance")]
	private float occlusionIntensity; //Field offset: 0x38
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("Intensity controller for Directvity , Value of 1 will apply full directivity")]
	private float directivityIntensity; //Field offset: 0x3C
	[SerializeField]
	[Tooltip("Option for human voice directivity pattern that makes this sound more muffled when the source is facing away from listener")]
	private DirectivityPatternType directivityPattern; //Field offset: 0x40
	[SerializeField]
	[Tooltip("This switch can disable direct sound propagation, so only late reverberations is heard from this source")]
	private bool directSoundEnabled; //Field offset: 0x44
	private bool _initialized; //Field offset: 0x45

	public float DirectivityIntensity
	{
		 get { } //Length: 6
		 set { } //Length: 33
	}

	public DirectivityPatternType DirectivityPattern
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public bool DirectSoundEnabled
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public float EarlyReflectionsSendDb
	{
		 get { } //Length: 6
		 set { } //Length: 38
	}

	public float HrtfIntensity
	{
		 get { } //Length: 6
		 set { } //Length: 33
	}

	public float OcclusionIntensity
	{
		 get { } //Length: 6
		 set { } //Length: 33
	}

	public float ReverbReach
	{
		 get { } //Length: 6
		 set { } //Length: 33
	}

	public float VolumetricRadius
	{
		 get { } //Length: 6
		 set { } //Length: 15
	}

	public MetaXRAudioSourceExperimentalFeatures() { }

	private void Awake() { }

	public float get_DirectivityIntensity() { }

	public DirectivityPatternType get_DirectivityPattern() { }

	public bool get_DirectSoundEnabled() { }

	public float get_EarlyReflectionsSendDb() { }

	public float get_HrtfIntensity() { }

	public float get_OcclusionIntensity() { }

	public float get_ReverbReach() { }

	public float get_VolumetricRadius() { }

	public void Init() { }

	public void ManualUpdate() { }

	private static void MetaXRAudio_GetGlobalRoomReflectionValues(ref bool reflOn, ref bool reverbOn, ref float width, ref float height, ref float length) { }

	private void OnValidate() { }

	public void set_DirectivityIntensity(float value) { }

	public void set_DirectivityPattern(DirectivityPatternType value) { }

	public void set_DirectSoundEnabled(bool value) { }

	public void set_EarlyReflectionsSendDb(float value) { }

	public void set_HrtfIntensity(float value) { }

	public void set_OcclusionIntensity(float value) { }

	public void set_ReverbReach(float value) { }

	public void set_VolumetricRadius(float value) { }

	public void UpdateParameters() { }

}

