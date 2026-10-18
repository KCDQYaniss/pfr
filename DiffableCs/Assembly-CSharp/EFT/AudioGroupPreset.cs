namespace EFT;

[CreateAssetMenu(menuName = "Scriptable objects/AudioGroupPreset", fileName = "AudioGroupPreset")]
public class AudioGroupPreset : ScriptableObject
{
	internal class AcousticSettings
	{
		public bool enabledReverb; //Field offset: 0x10
		[Range(-60, 20)]
		public float reverbSendDb; //Field offset: 0x14
		[Range(-60, 20)]
		public float earlyReflectionsSendDb; //Field offset: 0x18
		[Range(0, 1)]
		public float reverbReach; //Field offset: 0x1C

		public AcousticSettings() { }

		public void Apply(AcousticSettings settings) { }

	}

	internal class AudioGroupAcousticSettings : ISettingsFromJson
	{
		public AcousticSettings mono; //Field offset: 0x10
		public AcousticSettings stereo; //Field offset: 0x18
		public bool enabledPrewarm; //Field offset: 0x20

		public AudioGroupAcousticSettings() { }

		public override void ApplyFromJson(string json) { }

	}

	internal class AudioGroupPoolSettings
	{
		[Min(0)]
		public int preCachedSourcesCount; //Field offset: 0x10
		[Min(0)]
		public int sourcesCountLimit; //Field offset: 0x14
		[Range(0, 10)]
		public float warmWindowSeconds; //Field offset: 0x18
		[Range(0, 1)]
		public float warmJitterSeconds; //Field offset: 0x1C
		public bool enableHotPool; //Field offset: 0x20
		[Range(0, 64)]
		public int hotSourcesCount; //Field offset: 0x24

		public AudioGroupPoolSettings() { }

	}

	internal class BetterSourceSettings
	{
		public float volumeUpdateSpeed; //Field offset: 0x10
		public float pitchEndFadeMinSec; //Field offset: 0x14
		public float pitchEndFadePercent; //Field offset: 0x18
		public double pitchEndPlaybackOffsetSec; //Field offset: 0x20
		public float pitchDetuneThreshold; //Field offset: 0x28

		public BetterSourceSettings() { }

	}

	internal class SpatializerSettings
	{
		[Header("Common Settings")]
		public bool UseSimpleSpatializer; //Field offset: 0x10
		[Range(0, 10)]
		public float SpatializerGainBoostDB; //Field offset: 0x14
		public DirectivityPatternType DirectivityPatternType; //Field offset: 0x18
		[Range(0, 1)]
		public float DirectivityIntensity; //Field offset: 0x1C
		[Range(0.1, 10)]
		public float OcclusionSourceRadius; //Field offset: 0x20
		[Header("HRTF Settings")]
		public bool EnableDynamicHRTFBlend; //Field offset: 0x24
		public float MinDistanceToHRTFBlend; //Field offset: 0x28
		public float MinHeightDiffToHRTFBlend; //Field offset: 0x2C
		public float MinAngleToToHRTFBlend; //Field offset: 0x30
		[Range(0, 1)]
		public float HrtfBlendIntensity; //Field offset: 0x34
		[Range(0, 20)]
		public float HrtfBlendSmoothSpeed; //Field offset: 0x38
		public AnimationCurve HrtfBlendCurve; //Field offset: 0x40

		public SpatializerSettings() { }

	}

	public AudioSourceGroupType Type; //Field offset: 0x18
	[Range(0, 1)]
	public float OverallVolume; //Field offset: 0x1C
	[Range(0, 1)]
	public float SpatialBlend; //Field offset: 0x20
	public AnimationCurve SpreadCurve; //Field offset: 0x28
	public AnimationCurve SoundRolloff; //Field offset: 0x30
	[HideInInspector]
	public Vector3Int AudioSourcePriorityRange; //Field offset: 0x38
	public float DefaultMaxDistance; //Field offset: 0x44
	[Space]
	public BetterSourceSettings betterSourceSettings; //Field offset: 0x48
	[Space]
	public AudioGroupPoolSettings poolSettings; //Field offset: 0x50
	[Space]
	public bool Spatialize; //Field offset: 0x58
	public SpatializerSettings spatializationSettings; //Field offset: 0x60
	[Space]
	public AudioGroupAcousticSettings acousticSettings; //Field offset: 0x68
	[Space]
	public AudioGroupOcclusionSettings occlusionSettings; //Field offset: 0x70

	public int DefaultAudioSourcePriority
	{
		 get { } //Length: 6
	}

	public static AudioGroupPreset DefaultPreset
	{
		 get { } //Length: 53
	}

	public AudioGroupPreset() { }

	public int get_DefaultAudioSourcePriority() { }

	public static AudioGroupPreset get_DefaultPreset() { }

}

