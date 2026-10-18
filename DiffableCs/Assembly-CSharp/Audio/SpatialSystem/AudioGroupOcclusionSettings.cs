namespace Audio.SpatialSystem;

public class AudioGroupOcclusionSettings : ISettingsFromJson
{
	public bool occlusionEnabled; //Field offset: 0x10
	[Range(0, 1)]
	public float occlusionIntensity; //Field offset: 0x14
	[Range(0, 1)]
	public float maxQualityFactor; //Field offset: 0x18
	public bool useQualityCompression; //Field offset: 0x1C
	public bool obstructionInSameIndoorRoom; //Field offset: 0x1D
	[Range(0.1, 2)]
	public float indoorToOutdoorFactor; //Field offset: 0x20
	[Range(0.1, 2)]
	public float outdoorToIndoorFactor; //Field offset: 0x24
	[Range(0.1, 1)]
	public float rolloffScale; //Field offset: 0x28
	public AudioOcclusionEQPreset obstructionEQPreset; //Field offset: 0x30
	public AudioOcclusionEQPreset propagationEQPreset; //Field offset: 0x38
	public AnimationCurve stairsHeightCurve; //Field offset: 0x40

	public AudioGroupOcclusionSettings() { }

	public override void ApplyFromJson(string json) { }

}

