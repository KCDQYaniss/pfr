namespace Audio.SpatialSystem;

public sealed class OcclusionParameters : IDisposable
{
	public float ObstructionVolumeFactor; //Field offset: 0x10
	public float PropagationVolumeFactor; //Field offset: 0x14
	public float OcclusionVolumeFactor; //Field offset: 0x18
	public float DistanceHiCutFrequency; //Field offset: 0x1C
	public float DistanceLowCutFrequency; //Field offset: 0x20
	public float DistancePercentage; //Field offset: 0x24
	public float IsolationFactor; //Field offset: 0x28
	[CompilerGenerated]
	private float <HighPassResonance>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private float <LowPassResonance>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private float <OcclusionRolloffScale>k__BackingField; //Field offset: 0x34

	public float HighPassResonance
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public float LowPassResonance
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public float OcclusionRolloffScale
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public OcclusionParameters() { }

	public void Apply(OcclusionParameters parameters) { }

	public override void Dispose() { }

	[CompilerGenerated]
	public float get_HighPassResonance() { }

	[CompilerGenerated]
	public float get_LowPassResonance() { }

	[CompilerGenerated]
	public float get_OcclusionRolloffScale() { }

	[CompilerGenerated]
	public void set_HighPassResonance(float value) { }

	[CompilerGenerated]
	public void set_LowPassResonance(float value) { }

	[CompilerGenerated]
	public void set_OcclusionRolloffScale(float value) { }

}

