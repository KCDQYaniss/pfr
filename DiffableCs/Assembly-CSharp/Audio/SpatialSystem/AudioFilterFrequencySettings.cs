namespace Audio.SpatialSystem;

public class AudioFilterFrequencySettings
{
	[Range(100, 22000)]
	[SerializeField]
	private float _defaultIndoorOcclusionFrequency; //Field offset: 0x10
	[Range(100, 22000)]
	[SerializeField]
	private float _defaultOutdoorOcclusionFrequency; //Field offset: 0x14
	[Range(100, 22000)]
	[SerializeField]
	private float _lowerOcclusionFrequency; //Field offset: 0x18
	[Range(100, 22000)]
	[SerializeField]
	private float _upperOcclusionFrequency; //Field offset: 0x1C
	[Range(100, 22000)]
	[SerializeField]
	private float _wallOcclusionFrequency; //Field offset: 0x20
	[Range(100, 22000)]
	[SerializeField]
	private float _fullOcclusionFrequency; //Field offset: 0x24
	[Range(100, 22000)]
	[SerializeField]
	private float _differentEnvironmentsFrequency; //Field offset: 0x28

	public AudioFilterFrequencySettings() { }

	public float GetLowerFrequency(ISpatialAudioRoom sourceRoom, Vector3 soundPosition, Vector3 listenerPosition, float obstruction, float propagation, bool isolated = false) { }

}

