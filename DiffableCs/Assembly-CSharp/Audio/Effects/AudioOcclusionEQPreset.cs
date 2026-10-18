namespace Audio.Effects;

public class AudioOcclusionEQPreset
{
	internal class AudioFilterSettings
	{
		public AnimationCurve frequencyCurve; //Field offset: 0x10
		public AnimationCurve resonanceCurve; //Field offset: 0x18
		public AnimationCurve distanceCurve; //Field offset: 0x20
		public AnimationCurve heightCurve; //Field offset: 0x28
		public PositionEQThresholds positionEqThresholds; //Field offset: 0x30
		public EnvironmentAudioThresholds environmentEqThresholds; //Field offset: 0x38

		public AudioFilterSettings() { }

	}

	internal class EnvironmentAudioThresholds
	{
		public float indoorIsolated; //Field offset: 0x10
		public float diffRoomsTypeIsolated; //Field offset: 0x14
		public float diffEnvironmentIsolated; //Field offset: 0x18
		public float indoorToOutdoor; //Field offset: 0x1C
		public float outdoorToIndoor; //Field offset: 0x20
		public float baseValue; //Field offset: 0x24

		public EnvironmentAudioThresholds() { }

	}

	internal class PositionEQThresholds
	{
		[Range(20, 20000)]
		public float levelFreq; //Field offset: 0x10
		[Range(20, 20000)]
		public float aboveFreq; //Field offset: 0x14
		[Range(20, 20000)]
		public float belowFreq; //Field offset: 0x18
		[Range(20, 20000)]
		public float behindFreq; //Field offset: 0x1C

		public PositionEQThresholds() { }

	}

	public AnimationCurve volumeCurve; //Field offset: 0x10
	public EnvironmentAudioThresholds environmentVolumeThresholds; //Field offset: 0x18
	public AnimationCurve heightVolumeCurve; //Field offset: 0x20
	public AudioFilterSettings hpfSettings; //Field offset: 0x28
	public AudioFilterSettings lpfSettings; //Field offset: 0x30
	[Range(0, 0.5)]
	public float distanceCoefficient; //Field offset: 0x38
	[Range(0, 0.2)]
	public float rotationCoefficient; //Field offset: 0x3C

	public AudioOcclusionEQPreset() { }

}

