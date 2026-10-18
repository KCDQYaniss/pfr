namespace Audio.AuxiliaryAudioUtils;

public class AudioSourcePriorityCalculator
{
	[CompilerGenerated]
	private readonly int <HighAudioSourcePriority>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly int <MedAudioSourcePriority>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private readonly int <LowAudioSourcePriority>k__BackingField; //Field offset: 0x18
	private readonly int[] _priorities; //Field offset: 0x20

	public int HighAudioSourcePriority
	{
		[CompilerGenerated]
		 get { } //Length: 164
	}

	public int LowAudioSourcePriority
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public int MedAudioSourcePriority
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public AudioSourcePriorityCalculator(int lowPriority = 256, int medPriority = 128, int highPriority = 64) { }

	public int CalculatePriority(float currentDistance, float maxDistance) { }

	public int CalculatePrioritySq(float sqrDistanceToListener, float sqrMaxDistance) { }

	public float CalculateQualityFactorSq(float currentDistanceSquared, float maxDistanceSquared) { }

	[CompilerGenerated]
	public int get_HighAudioSourcePriority() { }

	[CompilerGenerated]
	public int get_LowAudioSourcePriority() { }

	[CompilerGenerated]
	public int get_MedAudioSourcePriority() { }

	public EAudioSourcePriority GetPriority(float currentDistance, float maxDistance) { }

	public void SetCustomPriorityRange(int lowPriority, int medPriority, int highPriority) { }

}

